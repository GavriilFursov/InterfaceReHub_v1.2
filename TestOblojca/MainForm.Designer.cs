namespace TestOblojca
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblPrintNameProduct = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBtnHelp = new System.Windows.Forms.Panel();
            this.pictureBoxForHelp = new System.Windows.Forms.PictureBox();
            this.btnAboutDevelopers = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelBtnSetting = new System.Windows.Forms.Panel();
            this.pictureBoxForSetting = new System.Windows.Forms.PictureBox();
            this.btnManualControl = new System.Windows.Forms.Button();
            this.btnDiagnosticSystem = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnRehabilitation = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitlePage = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblForPrintName = new System.Windows.Forms.Label();
            this.panelPrintForm = new System.Windows.Forms.Panel();
            this.lblPonos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBtnHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForHelp)).BeginInit();
            this.panelBtnSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForSetting)).BeginInit();
            this.panelTitlePage.SuspendLayout();
            this.panelPrintForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblPrintNameProduct);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // lblPrintNameProduct
            // 
            this.lblPrintNameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrintNameProduct.AutoSize = true;
            this.lblPrintNameProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrintNameProduct.ForeColor = System.Drawing.Color.LightGray;
            this.lblPrintNameProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrintNameProduct.Location = new System.Drawing.Point(22, 30);
            this.lblPrintNameProduct.Name = "lblPrintNameProduct";
            this.lblPrintNameProduct.Size = new System.Drawing.Size(198, 29);
            this.lblPrintNameProduct.TabIndex = 0;
            this.lblPrintNameProduct.Text = "Панель управления";
            this.lblPrintNameProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrintNameProduct.UseCompatibleTextRendering = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelBtnHelp);
            this.panelMenu.Controls.Add(this.panelBtnSetting);
            this.panelMenu.Controls.Add(this.btnRehabilitation);
            this.panelMenu.Controls.Add(this.btnPatients);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 1000);
            this.panelMenu.TabIndex = 1;
            // 
            // panelBtnHelp
            // 
            this.panelBtnHelp.Controls.Add(this.pictureBoxForHelp);
            this.panelBtnHelp.Controls.Add(this.btnAboutDevelopers);
            this.panelBtnHelp.Controls.Add(this.btnReference);
            this.panelBtnHelp.Controls.Add(this.btnHelp);
            this.panelBtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnHelp.Location = new System.Drawing.Point(0, 805);
            this.panelBtnHelp.MaximumSize = new System.Drawing.Size(250, 330);
            this.panelBtnHelp.MinimumSize = new System.Drawing.Size(250, 130);
            this.panelBtnHelp.Name = "panelBtnHelp";
            this.panelBtnHelp.Size = new System.Drawing.Size(250, 130);
            this.panelBtnHelp.TabIndex = 8;
            // 
            // pictureBoxForHelp
            // 
            this.pictureBoxForHelp.Image = global::TestOblojca.Properties.Resources.down_arrow_icon_icons_com_64915;
            this.pictureBoxForHelp.Location = new System.Drawing.Point(175, 51);
            this.pictureBoxForHelp.Name = "pictureBoxForHelp";
            this.pictureBoxForHelp.Size = new System.Drawing.Size(33, 29);
            this.pictureBoxForHelp.TabIndex = 8;
            this.pictureBoxForHelp.TabStop = false;
            // 
            // btnAboutDevelopers
            // 
            this.btnAboutDevelopers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutDevelopers.FlatAppearance.BorderSize = 0;
            this.btnAboutDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutDevelopers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutDevelopers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAboutDevelopers.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutDevelopers.Image")));
            this.btnAboutDevelopers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutDevelopers.Location = new System.Drawing.Point(0, 230);
            this.btnAboutDevelopers.Name = "btnAboutDevelopers";
            this.btnAboutDevelopers.Size = new System.Drawing.Size(250, 100);
            this.btnAboutDevelopers.TabIndex = 5;
            this.btnAboutDevelopers.Text = "О разработчиках";
            this.btnAboutDevelopers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutDevelopers.UseVisualStyleBackColor = true;
            this.btnAboutDevelopers.Click += new System.EventHandler(this.btnAboutDevelopers_Click);
            // 
            // btnReference
            // 
            this.btnReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReference.FlatAppearance.BorderSize = 0;
            this.btnReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReference.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReference.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReference.Image = global::TestOblojca.Properties.Resources.text_document_information_icon_icons_com_71553;
            this.btnReference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReference.Location = new System.Drawing.Point(0, 130);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(250, 100);
            this.btnReference.TabIndex = 4;
            this.btnReference.Text = " Справка";
            this.btnReference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(250, 130);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelBtnSetting
            // 
            this.panelBtnSetting.Controls.Add(this.pictureBoxForSetting);
            this.panelBtnSetting.Controls.Add(this.btnManualControl);
            this.panelBtnSetting.Controls.Add(this.btnDiagnosticSystem);
            this.panelBtnSetting.Controls.Add(this.btnSetting);
            this.panelBtnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnSetting.Location = new System.Drawing.Point(0, 475);
            this.panelBtnSetting.MaximumSize = new System.Drawing.Size(250, 330);
            this.panelBtnSetting.MinimumSize = new System.Drawing.Size(250, 130);
            this.panelBtnSetting.Name = "panelBtnSetting";
            this.panelBtnSetting.Size = new System.Drawing.Size(250, 130);
            this.panelBtnSetting.TabIndex = 7;
            // 
            // pictureBoxForSetting
            // 
            this.pictureBoxForSetting.Image = global::TestOblojca.Properties.Resources.down_arrow_icon_icons_com_64915;
            this.pictureBoxForSetting.Location = new System.Drawing.Point(175, 51);
            this.pictureBoxForSetting.Name = "pictureBoxForSetting";
            this.pictureBoxForSetting.Size = new System.Drawing.Size(33, 29);
            this.pictureBoxForSetting.TabIndex = 7;
            this.pictureBoxForSetting.TabStop = false;
            // 
            // btnManualControl
            // 
            this.btnManualControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManualControl.FlatAppearance.BorderSize = 0;
            this.btnManualControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualControl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualControl.Image = global::TestOblojca.Properties.Resources.remote_control_icon_icons_com_49852;
            this.btnManualControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualControl.Location = new System.Drawing.Point(0, 230);
            this.btnManualControl.Name = "btnManualControl";
            this.btnManualControl.Size = new System.Drawing.Size(250, 100);
            this.btnManualControl.TabIndex = 6;
            this.btnManualControl.Text = "Ручной режим управления";
            this.btnManualControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManualControl.UseVisualStyleBackColor = true;
            this.btnManualControl.Click += new System.EventHandler(this.btnManualControl_Click);
            // 
            // btnDiagnosticSystem
            // 
            this.btnDiagnosticSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnosticSystem.FlatAppearance.BorderSize = 0;
            this.btnDiagnosticSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosticSystem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosticSystem.Image = global::TestOblojca.Properties.Resources.systemtask_task_thesystem_4653;
            this.btnDiagnosticSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticSystem.Location = new System.Drawing.Point(0, 130);
            this.btnDiagnosticSystem.Name = "btnDiagnosticSystem";
            this.btnDiagnosticSystem.Size = new System.Drawing.Size(250, 100);
            this.btnDiagnosticSystem.TabIndex = 5;
            this.btnDiagnosticSystem.Text = "Диагностика системы";
            this.btnDiagnosticSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiagnosticSystem.UseVisualStyleBackColor = true;
            this.btnDiagnosticSystem.Click += new System.EventHandler(this.btnDiagnosticSystem_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(250, 130);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Настройки";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRehabilitation
            // 
            this.btnRehabilitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRehabilitation.FlatAppearance.BorderSize = 0;
            this.btnRehabilitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRehabilitation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRehabilitation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRehabilitation.Image = ((System.Drawing.Image)(resources.GetObject("btnRehabilitation.Image")));
            this.btnRehabilitation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRehabilitation.Location = new System.Drawing.Point(0, 345);
            this.btnRehabilitation.Name = "btnRehabilitation";
            this.btnRehabilitation.Size = new System.Drawing.Size(250, 130);
            this.btnRehabilitation.TabIndex = 5;
            this.btnRehabilitation.Text = "Реабилитация";
            this.btnRehabilitation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRehabilitation.UseVisualStyleBackColor = true;
            this.btnRehabilitation.Click += new System.EventHandler(this.btnRehabilitation_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatients.Location = new System.Drawing.Point(0, 215);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(250, 130);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "Архив пациентов";
            this.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 85);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 130);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Домой";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitlePage
            // 
            this.panelTitlePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitlePage.Controls.Add(this.btnMinimize);
            this.panelTitlePage.Controls.Add(this.btnMaximize);
            this.panelTitlePage.Controls.Add(this.btnClose);
            this.panelTitlePage.Controls.Add(this.lblForPrintName);
            this.panelTitlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlePage.Location = new System.Drawing.Point(250, 0);
            this.panelTitlePage.Name = "panelTitlePage";
            this.panelTitlePage.Size = new System.Drawing.Size(1027, 85);
            this.panelTitlePage.TabIndex = 2;
            this.panelTitlePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlePage_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(937, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(967, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(997, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblForPrintName
            // 
            this.lblForPrintName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForPrintName.AutoSize = true;
            this.lblForPrintName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForPrintName.Location = new System.Drawing.Point(413, 30);
            this.lblForPrintName.Name = "lblForPrintName";
            this.lblForPrintName.Size = new System.Drawing.Size(230, 24);
            this.lblForPrintName.TabIndex = 0;
            this.lblForPrintName.Text = "Начальная страница";
            this.lblForPrintName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPrintForm
            // 
            this.panelPrintForm.Controls.Add(this.lblPonos);
            this.panelPrintForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrintForm.Location = new System.Drawing.Point(250, 85);
            this.panelPrintForm.Name = "panelPrintForm";
            this.panelPrintForm.Size = new System.Drawing.Size(1027, 915);
            this.panelPrintForm.TabIndex = 3;
            // 
            // lblPonos
            // 
            this.lblPonos.AutoSize = true;
            this.lblPonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPonos.ForeColor = System.Drawing.Color.Black;
            this.lblPonos.Location = new System.Drawing.Point(26, 243);
            this.lblPonos.Name = "lblPonos";
            this.lblPonos.Size = new System.Drawing.Size(994, 37);
            this.lblPonos.TabIndex = 0;
            this.lblPonos.Text = "Название, краткое описание, версия, разработчики, рендер модели";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 1000);
            this.Controls.Add(this.panelPrintForm);
            this.Controls.Add(this.panelTitlePage);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ReHab v.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelBtnHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForHelp)).EndInit();
            this.panelBtnSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForSetting)).EndInit();
            this.panelTitlePage.ResumeLayout(false);
            this.panelTitlePage.PerformLayout();
            this.panelPrintForm.ResumeLayout(false);
            this.panelPrintForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnRehabilitation;
        private System.Windows.Forms.Panel panelTitlePage;
        private System.Windows.Forms.Label lblForPrintName;
        private System.Windows.Forms.Label lblPrintNameProduct;
        private System.Windows.Forms.Panel panelPrintForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblPonos;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelBtnSetting;
        private System.Windows.Forms.Button btnDiagnosticSystem;
        private System.Windows.Forms.Button btnManualControl;
        private System.Windows.Forms.PictureBox pictureBoxForSetting;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBtnHelp;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.PictureBox pictureBoxForHelp;
        private System.Windows.Forms.Button btnAboutDevelopers;
        private System.Windows.Forms.Timer timer2;
    }
}

