using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.Windows.Forms;

namespace TestOblojca.Forms
{
    public partial class DiagnosticSystem : Form
    {
        private System.Windows.Forms.Label label;
        bool isConnected = false;

        public DiagnosticSystem()
        {
            InitializeComponent();
            ActivateLabel();
        }

        private void ActivateLabel()
        {
            foreach (Control previousLbl in panelChartDiagnostic.Controls)
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
            ConnectOrDisconnectToArduino();
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

        //private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    SerialPort sp = (SerialPort)sender;
        //    string data = sp.ReadLine();
        //    //string data1 = sp.ReadLine();

        //    //textBoxArduinoData.Invoke(new Action(() => textBoxArduinoData.Text = data));
        //    //textBox2.Invoke(new Action(() => textBox2.Text = data1));
        //    chart1.Invoke(new Action(() => {
        //        chart1.Series[0].Points.AddY(data);
        //        //chart1.Series[1].Points.AddY(data1);
        //        //if (chart1.Series[0].Points.Count >= 50)
        //        //{
        //        //    chart1.Series[0].Points.Clear();
        //        //}
        //        //if (chart1.Series[1].Points.Count >= 50)
        //        //{
        //        //    chart1.Series[1].Points.Clear();
        //        //}
        //    }));
        //}

        private byte[] sensorData = new byte[3];
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
                    for (int i = 0; i < 3; i++)
                    {
                        sensorData[i] = (byte)serialPort.ReadByte();
                    }
                }
                else if (isReadingData && receivedByte == endMarker)
                {
                    byte checksum = (byte)serialPort.ReadByte();

                    //byte calculatedChecksum = (byte)(sensorData[0] + sensorData[1]);

                    chart1.Invoke(new Action(() =>
                    {
                        chart1.Series[0].Points.AddY(sensorData[0]);
                        chart1.Series[1].Points.AddY(sensorData[1]);
                        chart1.Series[2].Points.AddY(sensorData[2]);
                    }));

                    //if (calculatedChecksum == checksum)
                    //{
                    //    chart1.Invoke(new Action(() =>
                    //    {
                    //        chart1.Series[0].Points.AddY(sensorData[0]);
                    //        chart1.Series[1].Points.AddY(sensorData[1]);
                    //    }));
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ошибка: контрольная сумма не совпадает!");
                    //}

                    isReadingData = false;
                }
                else if (isReadingData) 
                {
                    sensorData[0] = receivedByte;
                    sensorData[1] = (byte)serialPort.ReadByte();
                    sensorData[2] = (byte)serialPort.ReadByte();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
        }
    }
}

