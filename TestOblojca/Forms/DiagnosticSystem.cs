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
using Microsoft.Office.Interop.Excel;
using System.Windows.Media;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestOblojca.Forms
{
    public partial class DiagnosticSystem : Form
    {
        private System.Windows.Forms.Label label;
        bool isConnected = false;
        bool checkingStartOrStop = false;
        bool isFullScreen = false;

        Double y = -0.0;
        Double y1 = 0.0;
        Double y2 = 90.0;
        Double yy = 0.0;
        Double y11 = 0.0;
        Double y22 = 90.0;
        int X = 1400;
        int Y = 50;
        int X1 = 1500;
        int Y1 = 50;
        float l1 = 0;
        float l2 = 0;
        float l3 = 0;
        float l11 = 0;
        float l22 = 0;
        float l33 = 0;
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;
        int p6 = 0;
        int p11 = 0;
        int p22 = 0;
        int p33 = 0;
        int p44 = 0;
        int p55 = 0;
        int p66 = 0;

        public DiagnosticSystem()
        {
            InitializeComponent();
            ActivateLabel();
            chart1.MouseClick += chart1_MouseClick;

            panelChartDiagnostic.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            timer1.Interval = 1;
            timer1.Tick += (_, __) =>
            {
                l1 = (float)Math.Sqrt((Math.Pow((X - X), 2) + Math.Pow(((Y + 120) - Y), 2)));
                p1 = (int)(X + l1 * Math.Sin((y * 3.14) / 180));
                p2 = (int)(Y + l1 * Math.Cos((y * 3.14) / 180));

                l2 = (float)Math.Sqrt(Math.Pow((150 - 150), 2) + Math.Pow((120 - 0), 2));
                p3 = (int)(p1 + (l2 * Math.Sin(((y * 3.14) / 180) + ((y1 * 3.14) / 180))));
                p4 = (int)(p2 + (l2 * Math.Cos(((y * 3.14) / 180) + ((y1 * 3.14) / 180))));

                l3 = (float)Math.Sqrt(Math.Pow((25 - 0), 2) + Math.Pow((150 - 150), 2));
                p5 = (int)(p3 + (l3 * Math.Sin(((y * 3.14) / 180) + ((y1 * 3.14) / 180) + ((y2 * 3.14) / 180))));
                p6 = (int)(p4 + (l3 * Math.Cos(((y * 3.14) / 180) + ((y1 * 3.14) / 180) + ((y2 * 3.14) / 180))));

                l11 = (float)Math.Sqrt((Math.Pow((X1 - X1), 2) + Math.Pow(((Y1 + 120) - Y1), 2)));
                p11 = (int)(X1 + l11 * Math.Sin((yy * 3.14) / 180));
                p22 = (int)(Y1 + l11 * Math.Cos((yy * 3.14) / 180));

                l22 = (float)Math.Sqrt(Math.Pow((150 - 150), 2) + Math.Pow((120 - 0), 2));
                p33 = (int)(p11 + (l22 * Math.Sin(((yy * 3.14) / 180) + ((y11 * 3.14) / 180))));
                p44 = (int)(p22 + (l22 * Math.Cos(((yy * 3.14) / 180) + ((y11 * 3.14) / 180))));

                l33 = (float)Math.Sqrt(Math.Pow((25 - 0), 2) + Math.Pow((150 - 150), 2));
                p55 = (int)(p33 + (l33 * Math.Sin(((yy * 3.14) / 180) + ((y11 * 3.14) / 180) + ((y22 * 3.14) / 180))));
                p66 = (int)(p44 + (l33 * Math.Cos(((yy * 3.14) / 180) + ((y11 * 3.14) / 180) + ((y22 * 3.14) / 180))));
                Invalidate();
            };
            timer1.Start();
        }

        private void ActivateLabel()
        {
            foreach (System.Windows.Forms.Control previousLbl in panelChartDiagnostic.Controls)
            {
                if (previousLbl.GetType() == typeof(System.Windows.Forms.Label))
                {
                    previousLbl.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
                    previousLbl.ForeColor = System.Drawing.Color.Black;
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

        private byte[] sensorData = new byte[10];
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
                    for (int i = 0; i < 10; i++)
                    {
                        sensorData[i] = (byte)serialPort.ReadByte();
                    }
                }
                else if (isReadingData && receivedByte == endMarker)
                {
                    //byte checksum = (byte)serialPort.ReadByte();

                    //byte calculatedChecksum = (byte)(sensorData[0] + sensorData[1]);


                    chart5.Invoke(new System.Action(() =>
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

                    textBox11.Invoke(new System.Action(() =>
                    {
                        textBox11.Text = sensorStringFirstLeftFootSensor;
                    }));

                    textBox12.Invoke(new System.Action(() =>
                    {
                        textBox12.Text = sensorStringSecondLeftFootSensor;
                    }));

                    textBox13.Invoke(new System.Action(() =>
                    {
                        textBox13.Text = sensorStringThirdLeftFootSensor; 
                    }));

                    checkingLoadOnTheFeet(0, panelFirstLeftFootSensor);
                    checkingLoadOnTheFeet(1, panelSecondLeftFootSensor);
                    checkingLoadOnTheFeet(2, panelThirdLeftFootSensor);

                    y = Convert.ToDouble(sensorData[4]);
                    y1 = Convert.ToDouble(sensorData[5] * -1);
                    y2 = Convert.ToDouble(sensorData[6] + 90);
                    yy = Convert.ToDouble(sensorData[7]);
                    y11 = Convert.ToDouble(sensorData[8] * -1);
                    y22 = Convert.ToDouble(sensorData[9] + 90);

                    isReadingData = false;
                }
                else if (isReadingData) 
                {
                    sensorData[0] = receivedByte;
                    sensorData[1] = (byte)serialPort.ReadByte();
                    sensorData[2] = (byte)serialPort.ReadByte(); 
                    sensorData[3] = (byte)serialPort.ReadByte();
                    sensorData[4] = (byte)serialPort.ReadByte();
                    sensorData[5] = (byte)serialPort.ReadByte();
                    sensorData[6] = (byte)serialPort.ReadByte();
                    sensorData[7] = (byte)serialPort.ReadByte();
                    sensorData[8] = (byte)serialPort.ReadByte();
                    sensorData[9] = (byte)serialPort.ReadByte();
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
                position.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                position.BackColor = System.Drawing.Color.Green;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), X, Y, X1, Y1);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), X1, Y1, p11, p22);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), p11, p22, p33, p44);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), p33, p44, p55, p66);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), X, Y, p1, p2);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), p1, p2, p3, p4);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), p1, p2, p3, p4);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 5), p3, p4, p5, p6);
            // e.Graphics.FillEllipse(Brushes.Red, _ballLocation.X - 30, _ballLocation.Y - 30, 60, 60);
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

