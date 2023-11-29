using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Drawing;

namespace TestOblojca.Forms
{
    public partial class DiagnosticSystem : Form
    {
        private System.Windows.Forms.Label label;
        bool isConnected = false;
        bool checkingStartOrStop = false;

        public DiagnosticSystem()
        {
            InitializeComponent();
            ActivateLabel();
        }

        private void ActivateLabel()
        {
            foreach (System.Windows.Forms.Control previousLbl in panelChartDiagnostic.Controls)
            {
                if (previousLbl.GetType() == typeof(System.Windows.Forms.Label))
                {
                    previousLbl.BackColor = Color.FromArgb(70, 130, 180);
                    previousLbl.ForeColor = Color.Black;
                    previousLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                ConnectOrDisconnectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private string DetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException)
            {

            }

            return null;
        }

        private void ConnectOrDisconnectToArduino()
        {
            if (!isConnected)
            {
                string arduinoPort = DetectArduinoPort();
                if (!string.IsNullOrEmpty(arduinoPort))
                {
                    isConnected = true;
                    serialPort.PortName = arduinoPort;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialPort.Open();
                    connectButton.Text = "Отключиться";
                }
                else
                {
                    MessageBox.Show("Arduino не обнаружена. Убедитесь, что она подключена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void disconnectFromArduino()
        {
            if (isConnected)
            {
                isConnected = false;
                serialPort.Close();
                connectButton.Text = "Подключиться";
            }
        }

        private byte[] sensorData = new byte[4];
        private bool isReadingData = false;
        private byte startMarker = 0xA0;
        private byte endMarker = 0xC0;

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort.BytesToRead > 0)
            {
                byte receivedByte = (byte)serialPort.ReadByte();

                if (!isReadingData && receivedByte == startMarker)
                {
                    isReadingData = true;
                    for (int i = 0; i < 4; i++)
                    {
                        sensorData[i] = (byte)serialPort.ReadByte();
                    }
                }
                else if (isReadingData && receivedByte == endMarker)
                {
                    //byte checksum = (byte)serialPort.ReadByte();

                    //byte calculatedChecksum = (byte)(sensorData[0] + sensorData[1]);


                    chart5.Invoke(new Action(() =>
                    {
                        chart5.Series[0].Points.AddXY(sensorData[3] / 100, sensorData[0]);
                        chart5.Series[1].Points.AddXY(sensorData[3] / 100, sensorData[1]);
                        chart5.Series[2].Points.AddXY(sensorData[3] / 100, sensorData[2]);

                        if (chart5.Series[0].Points.Count >= 60)
                        {
                            chart5.Series[0].Points.Clear();
                            sensorData[3] = 0;
                        }
                        if (chart5.Series[1].Points.Count >= 60)
                        {
                            chart5.Series[1].Points.Clear();
                            sensorData[3] = 0;
                        }
                        if (chart5.Series[2].Points.Count >= 60)
                        {
                            chart5.Series[2].Points.Clear();
                            sensorData[3] = 0;
                        }

                    }));

                    string sensorStringFirstLeftFootSensor = sensorData[0].ToString();
                    string sensorStringSecondLeftFootSensor = sensorData[1].ToString();
                    string sensorStringThirdLeftFootSensor = sensorData[2].ToString();

                    textBox11.Invoke(new Action(() =>
                    {
                        textBox11.Text = sensorStringFirstLeftFootSensor;
                    }));

                    textBox12.Invoke(new Action(() =>
                    {
                        textBox12.Text = sensorStringSecondLeftFootSensor;
                    }));

                    textBox13.Invoke(new Action(() =>
                    {
                        textBox13.Text = sensorStringThirdLeftFootSensor;
                    }));

                    checkingLoadOnTheFeet(0, panelFirstLeftFootSensor);
                    checkingLoadOnTheFeet(1, panelSecondLeftFootSensor);
                    checkingLoadOnTheFeet(2, panelThirdLeftFootSensor);     

                    isReadingData = false;
                }
                else if (isReadingData) 
                {
                    sensorData[0] = receivedByte;
                    sensorData[1] = (byte)serialPort.ReadByte();
                    sensorData[2] = (byte)serialPort.ReadByte(); 
                    sensorData[3] = (byte)serialPort.ReadByte();
                }
            }
        }

        private void btnStartOrStop_Click(object sender, EventArgs e)
        {
            if (isConnected) {
                if (!checkingStartOrStop)
                {
                    serialPort.Write("1");
                    btnStartOrStop.Text = "Стоп";
                    checkingStartOrStop = true;
                }
                else
                {
                    serialPort.Write("0");
                    btnStartOrStop.Text = "Старт";
                    checkingStartOrStop = false;
                }
            }
            else
            {
                MessageBox.Show("Необходимо установить подключение к устройству", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkingLoadOnTheFeet(int i, System.Windows.Forms.Panel position)
        {
            if (sensorData[i] >= 2)
            {
                position.BackColor = Color.Red;
            }
            else
            {
                position.BackColor = Color.Green;
            }
        }
    }
}

