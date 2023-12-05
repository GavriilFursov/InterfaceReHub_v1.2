using System.IO.Ports;

namespace TestOblojca.Forms
{
    partial class DiagnosticSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.btnStartOrStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMenuValue = new System.Windows.Forms.Panel();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChartDiagnostic = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSecondRightFootSensor = new System.Windows.Forms.Panel();
            this.panelFirstRightFootSensor = new System.Windows.Forms.Panel();
            this.panelThirdRightFootSensor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSecondLeftFootSensor = new System.Windows.Forms.Panel();
            this.panelFirstLeftFootSensor = new System.Windows.Forms.Panel();
            this.panelThirdLeftFootSensor = new System.Windows.Forms.Panel();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.titleChartLeftLeg = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenuValue.SuspendLayout();
            this.panelChartDiagnostic.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.connectButton.Location = new System.Drawing.Point(0, -1);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(185, 56);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // btnStartOrStop
            // 
            this.btnStartOrStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnStartOrStop.FlatAppearance.BorderSize = 0;
            this.btnStartOrStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOrStop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartOrStop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStartOrStop.Location = new System.Drawing.Point(185, 0);
            this.btnStartOrStop.Name = "btnStartOrStop";
            this.btnStartOrStop.Size = new System.Drawing.Size(185, 55);
            this.btnStartOrStop.TabIndex = 2;
            this.btnStartOrStop.Text = "Старт";
            this.btnStartOrStop.UseVisualStyleBackColor = false;
            this.btnStartOrStop.Click += new System.EventHandler(this.btnStartOrStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 5;
            // 
            // panelMenuValue
            // 
            this.panelMenuValue.BackColor = System.Drawing.Color.Teal;
            this.panelMenuValue.Controls.Add(this.textBox16);
            this.panelMenuValue.Controls.Add(this.label18);
            this.panelMenuValue.Controls.Add(this.textBox15);
            this.panelMenuValue.Controls.Add(this.label19);
            this.panelMenuValue.Controls.Add(this.textBox14);
            this.panelMenuValue.Controls.Add(this.label20);
            this.panelMenuValue.Controls.Add(this.textBox13);
            this.panelMenuValue.Controls.Add(this.label16);
            this.panelMenuValue.Controls.Add(this.textBox12);
            this.panelMenuValue.Controls.Add(this.label15);
            this.panelMenuValue.Controls.Add(this.textBox11);
            this.panelMenuValue.Controls.Add(this.label21);
            this.panelMenuValue.Controls.Add(this.textBox10);
            this.panelMenuValue.Controls.Add(this.label13);
            this.panelMenuValue.Controls.Add(this.textBox9);
            this.panelMenuValue.Controls.Add(this.label14);
            this.panelMenuValue.Controls.Add(this.textBox8);
            this.panelMenuValue.Controls.Add(this.label12);
            this.panelMenuValue.Controls.Add(this.textBox7);
            this.panelMenuValue.Controls.Add(this.label17);
            this.panelMenuValue.Controls.Add(this.label5);
            this.panelMenuValue.Controls.Add(this.textBox6);
            this.panelMenuValue.Controls.Add(this.label6);
            this.panelMenuValue.Controls.Add(this.textBox5);
            this.panelMenuValue.Controls.Add(this.label3);
            this.panelMenuValue.Controls.Add(this.textBox4);
            this.panelMenuValue.Controls.Add(this.label4);
            this.panelMenuValue.Controls.Add(this.textBox3);
            this.panelMenuValue.Controls.Add(this.label2);
            this.panelMenuValue.Controls.Add(this.textBox2);
            this.panelMenuValue.Controls.Add(this.label1);
            this.panelMenuValue.Controls.Add(this.textBox1);
            this.panelMenuValue.Controls.Add(this.btnStartOrStop);
            this.panelMenuValue.Controls.Add(this.connectButton);
            this.panelMenuValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuValue.Location = new System.Drawing.Point(0, 0);
            this.panelMenuValue.Name = "panelMenuValue";
            this.panelMenuValue.Size = new System.Drawing.Size(370, 1061);
            this.panelMenuValue.TabIndex = 9;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(249, 896);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(111, 20);
            this.textBox16.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(3, 872);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(325, 44);
            this.label18.TabIndex = 36;
            this.label18.Text = "Показания третьего тензодатчика\nправой стопы:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(249, 849);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(111, 20);
            this.textBox15.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(3, 825);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(318, 44);
            this.label19.TabIndex = 34;
            this.label19.Text = "Показания второго тензодатчика\nправой стопы:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(249, 796);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(111, 20);
            this.textBox14.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(3, 772);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(322, 44);
            this.label20.TabIndex = 32;
            this.label20.Text = "Показания первого тензодатчика\nправой стопы:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(249, 709);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(111, 20);
            this.textBox13.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(3, 685);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(325, 44);
            this.label16.TabIndex = 30;
            this.label16.Text = "Показания третьего тензодатчика\nлевой стопы:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(249, 662);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(111, 20);
            this.textBox12.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(3, 638);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(318, 44);
            this.label15.TabIndex = 28;
            this.label15.Text = "Показания второго тензодатчика\nлевой стопы:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(249, 609);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(111, 20);
            this.textBox11.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(3, 585);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(322, 44);
            this.label21.TabIndex = 26;
            this.label21.Text = "Показания первого тензодатчика\nлевой стопы:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(249, 515);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(111, 20);
            this.textBox10.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(3, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 44);
            this.label13.TabIndex = 24;
            this.label13.Text = "Показания тензометрического\nдатчика правой голени:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(249, 463);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(111, 20);
            this.textBox9.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(3, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 44);
            this.label14.TabIndex = 22;
            this.label14.Text = "Показания тензометрического\nдатчика правого бедра:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(252, 400);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(111, 20);
            this.textBox8.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(6, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 44);
            this.label12.TabIndex = 20;
            this.label12.Text = "Показания тензометрического\nдатчика левой голени:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(252, 348);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(111, 20);
            this.textBox7.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(6, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 44);
            this.label17.TabIndex = 18;
            this.label17.Text = "Показания тензометрического\nдатчика левого бедра:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(6, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Угол стопы правой ноги:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(252, 263);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Угол голени правой ноги:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(252, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Угол бедра правой ноги:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(252, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Угол стопы левой ноги:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Угол голени левой ноги:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Угол бедра левой ноги:";
            // 
            // panelChartDiagnostic
            // 
            this.panelChartDiagnostic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChartDiagnostic.Controls.Add(this.label23);
            this.panelChartDiagnostic.Controls.Add(this.label22);
            this.panelChartDiagnostic.Controls.Add(this.panel3);
            this.panelChartDiagnostic.Controls.Add(this.panel2);
            this.panelChartDiagnostic.Controls.Add(this.chart6);
            this.panelChartDiagnostic.Controls.Add(this.label10);
            this.panelChartDiagnostic.Controls.Add(this.label11);
            this.panelChartDiagnostic.Controls.Add(this.chart5);
            this.panelChartDiagnostic.Controls.Add(this.label9);
            this.panelChartDiagnostic.Controls.Add(this.chart4);
            this.panelChartDiagnostic.Controls.Add(this.label8);
            this.panelChartDiagnostic.Controls.Add(this.chart3);
            this.panelChartDiagnostic.Controls.Add(this.label7);
            this.panelChartDiagnostic.Controls.Add(this.chart2);
            this.panelChartDiagnostic.Controls.Add(this.titleChartLeftLeg);
            this.panelChartDiagnostic.Controls.Add(this.chart1);
            this.panelChartDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartDiagnostic.Location = new System.Drawing.Point(370, 0);
            this.panelChartDiagnostic.Name = "panelChartDiagnostic";
            this.panelChartDiagnostic.Size = new System.Drawing.Size(1339, 1061);
            this.panelChartDiagnostic.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1104, 609);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 44);
            this.label23.TabIndex = 32;
            this.label23.Text = "Показания усилий\nна правой стопе";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(897, 607);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(184, 44);
            this.label22.TabIndex = 31;
            this.label22.Text = "Показания усилий\nна левой стопе";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.panelSecondRightFootSensor);
            this.panel3.Controls.Add(this.panelFirstRightFootSensor);
            this.panel3.Controls.Add(this.panelThirdRightFootSensor);
            this.panel3.Location = new System.Drawing.Point(1121, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 240);
            this.panel3.TabIndex = 30;
            // 
            // panelSecondRightFootSensor
            // 
            this.panelSecondRightFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecondRightFootSensor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSecondRightFootSensor.Location = new System.Drawing.Point(76, 0);
            this.panelSecondRightFootSensor.Name = "panelSecondRightFootSensor";
            this.panelSecondRightFootSensor.Size = new System.Drawing.Size(76, 123);
            this.panelSecondRightFootSensor.TabIndex = 2;
            // 
            // panelFirstRightFootSensor
            // 
            this.panelFirstRightFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFirstRightFootSensor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFirstRightFootSensor.Location = new System.Drawing.Point(0, 0);
            this.panelFirstRightFootSensor.Name = "panelFirstRightFootSensor";
            this.panelFirstRightFootSensor.Size = new System.Drawing.Size(76, 123);
            this.panelFirstRightFootSensor.TabIndex = 1;
            // 
            // panelThirdRightFootSensor
            // 
            this.panelThirdRightFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThirdRightFootSensor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThirdRightFootSensor.Location = new System.Drawing.Point(0, 123);
            this.panelThirdRightFootSensor.Name = "panelThirdRightFootSensor";
            this.panelThirdRightFootSensor.Size = new System.Drawing.Size(152, 117);
            this.panelThirdRightFootSensor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.panelSecondLeftFootSensor);
            this.panel2.Controls.Add(this.panelFirstLeftFootSensor);
            this.panel2.Controls.Add(this.panelThirdLeftFootSensor);
            this.panel2.Location = new System.Drawing.Point(911, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 240);
            this.panel2.TabIndex = 29;
            // 
            // panelSecondLeftFootSensor
            // 
            this.panelSecondLeftFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecondLeftFootSensor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSecondLeftFootSensor.Location = new System.Drawing.Point(76, 0);
            this.panelSecondLeftFootSensor.Name = "panelSecondLeftFootSensor";
            this.panelSecondLeftFootSensor.Size = new System.Drawing.Size(76, 123);
            this.panelSecondLeftFootSensor.TabIndex = 2;
            // 
            // panelFirstLeftFootSensor
            // 
            this.panelFirstLeftFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFirstLeftFootSensor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFirstLeftFootSensor.Location = new System.Drawing.Point(0, 0);
            this.panelFirstLeftFootSensor.Name = "panelFirstLeftFootSensor";
            this.panelFirstLeftFootSensor.Size = new System.Drawing.Size(76, 123);
            this.panelFirstLeftFootSensor.TabIndex = 1;
            // 
            // panelThirdLeftFootSensor
            // 
            this.panelThirdLeftFootSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThirdLeftFootSensor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThirdLeftFootSensor.Location = new System.Drawing.Point(0, 123);
            this.panelThirdLeftFootSensor.Name = "panelThirdLeftFootSensor";
            this.panelThirdLeftFootSensor.Size = new System.Drawing.Size(152, 117);
            this.panelThirdLeftFootSensor.TabIndex = 0;
            // 
            // chart6
            // 
            chartArea1.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart6.Legends.Add(legend1);
            this.chart6.Location = new System.Drawing.Point(462, 662);
            this.chart6.Name = "chart6";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Первый датчик";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Второй датчик";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Третий датчик";
            series3.Name = "Series3";
            this.chart6.Series.Add(series1);
            this.chart6.Series.Add(series2);
            this.chart6.Series.Add(series3);
            this.chart6.Size = new System.Drawing.Size(412, 240);
            this.chart6.TabIndex = 28;
            this.chart6.Text = "chart6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(396, 44);
            this.label10.TabIndex = 27;
            this.label10.Text = "Показания с тензометрических датчиков\nправой стопы";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(396, 44);
            this.label11.TabIndex = 25;
            this.label11.Text = "Показания с тензометрических датчиков\n левой стопы";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart5
            // 
            chartArea2.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart5.Legends.Add(legend2);
            this.chart5.Location = new System.Drawing.Point(15, 662);
            this.chart5.Name = "chart5";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "Первый датчик";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "Второй датчик";
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.LegendText = "Третий датчик";
            series6.Name = "Series3";
            this.chart5.Series.Add(series4);
            this.chart5.Series.Add(series5);
            this.chart5.Series.Add(series6);
            this.chart5.Size = new System.Drawing.Size(412, 240);
            this.chart5.TabIndex = 24;
            this.chart5.Text = "chart5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 44);
            this.label9.TabIndex = 23;
            this.label9.Text = "Показания с тензометрических датчиков\r\n правой ноги";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart4
            // 
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(462, 351);
            this.chart4.Name = "chart4";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.LegendText = "Бедро";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.LegendText = "Голень";
            series8.Name = "Series2";
            this.chart4.Series.Add(series7);
            this.chart4.Series.Add(series8);
            this.chart4.Size = new System.Drawing.Size(412, 240);
            this.chart4.TabIndex = 22;
            this.chart4.Text = "chart4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(396, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "Показания с тензометрических датчиков\n левой ноги";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(15, 351);
            this.chart3.Name = "chart3";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.LegendText = "Бедро";
            series9.Name = "Series1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.LegendText = "Голень";
            series10.Name = "Series2";
            this.chart3.Series.Add(series9);
            this.chart3.Series.Add(series10);
            this.chart3.Size = new System.Drawing.Size(412, 240);
            this.chart3.TabIndex = 20;
            this.chart3.Text = "chart3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Изменение углов звеньев правой ноги";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(462, 41);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.LegendText = "Бедро";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.LegendText = "Голень";
            series12.Name = "Series2";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.LegendText = "Ступня";
            series13.Name = "Series3";
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Series.Add(series13);
            this.chart2.Size = new System.Drawing.Size(412, 240);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // titleChartLeftLeg
            // 
            this.titleChartLeftLeg.AutoSize = true;
            this.titleChartLeftLeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleChartLeftLeg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleChartLeftLeg.Location = new System.Drawing.Point(43, 9);
            this.titleChartLeftLeg.Name = "titleChartLeftLeg";
            this.titleChartLeftLeg.Size = new System.Drawing.Size(355, 22);
            this.titleChartLeftLeg.TabIndex = 17;
            this.titleChartLeftLeg.Text = "Изменение углов звеньев левой ноги";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(15, 41);
            this.chart1.Name = "chart1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.LegendText = "Бедро";
            series14.Name = "Series1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.LegendText = "Голень";
            series15.Name = "Series2";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.LegendText = "Ступня";
            series16.Name = "Series3";
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(412, 240);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // DiagnosticSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1709, 1061);
            this.Controls.Add(this.panelChartDiagnostic);
            this.Controls.Add(this.panelMenuValue);
            this.Name = "DiagnosticSystem";
            this.Text = "Диагностика системы";
            this.panelMenuValue.ResumeLayout(false);
            this.panelMenuValue.PerformLayout();
            this.panelChartDiagnostic.ResumeLayout(false);
            this.panelChartDiagnostic.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnStartOrStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelMenuValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelChartDiagnostic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label titleChartLeftLeg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSecondLeftFootSensor;
        private System.Windows.Forms.Panel panelFirstLeftFootSensor;
        private System.Windows.Forms.Panel panelThirdLeftFootSensor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSecondRightFootSensor;
        private System.Windows.Forms.Panel panelFirstRightFootSensor;
        private System.Windows.Forms.Panel panelThirdRightFootSensor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer timer1;
    }
}