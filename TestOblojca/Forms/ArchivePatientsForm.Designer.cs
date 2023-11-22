namespace TestOblojca.Forms
{
    partial class ArchivePatientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.panelMenuArchivePatients = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuArchivePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearchPatient
            // 
            this.TextBoxSearchPatient.BackColor = System.Drawing.Color.White;
            this.TextBoxSearchPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearchPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxSearchPatient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearchPatient.ForeColor = System.Drawing.Color.White;
            this.TextBoxSearchPatient.Location = new System.Drawing.Point(155, 0);
            this.TextBoxSearchPatient.Name = "TextBoxSearchPatient";
            this.TextBoxSearchPatient.Size = new System.Drawing.Size(1331, 22);
            this.TextBoxSearchPatient.TabIndex = 13;
            this.TextBoxSearchPatient.TextChanged += new System.EventHandler(this.TextBoxSearchPatient_TextChanged);
            // 
            // panelMenuArchivePatients
            // 
            this.panelMenuArchivePatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenuArchivePatients.Controls.Add(this.btnAccept);
            this.panelMenuArchivePatients.Controls.Add(this.btnDeletePatient);
            this.panelMenuArchivePatients.Controls.Add(this.btnEditPatient);
            this.panelMenuArchivePatients.Controls.Add(this.btnAddPatient);
            this.panelMenuArchivePatients.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuArchivePatients.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuArchivePatients.Location = new System.Drawing.Point(0, 0);
            this.panelMenuArchivePatients.Name = "panelMenuArchivePatients";
            this.panelMenuArchivePatients.Size = new System.Drawing.Size(200, 864);
            this.panelMenuArchivePatients.TabIndex = 15;
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccept.Image = global::TestOblojca.Properties.Resources.checkmark_checked_done_accept_icon_142940;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(0, 321);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(200, 107);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Принять";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeletePatient.FlatAppearance.BorderSize = 0;
            this.btnDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePatient.Image = global::TestOblojca.Properties.Resources.delete_icon_icons_com_64453;
            this.btnDeletePatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePatient.Location = new System.Drawing.Point(0, 214);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(200, 107);
            this.btnDeletePatient.TabIndex = 10;
            this.btnDeletePatient.Text = "Удалить";
            this.btnDeletePatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditPatient.FlatAppearance.BorderSize = 0;
            this.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditPatient.Image = global::TestOblojca.Properties.Resources.clipboard_edit_black_interface_symbol_icon_icons_com_54569;
            this.btnEditPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPatient.Location = new System.Drawing.Point(0, 107);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(200, 107);
            this.btnEditPatient.TabIndex = 9;
            this.btnEditPatient.Text = "Изменить";
            this.btnEditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPatient.Image = global::TestOblojca.Properties.Resources._4115237_add_plus_114047;
            this.btnAddPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.Location = new System.Drawing.Point(0, 0);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(200, 107);
            this.btnAddPatient.TabIndex = 8;
            this.btnAddPatient.Text = "Добавить";
            this.btnAddPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // dataGridViewPatients
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients.ColumnHeadersHeight = 30;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPatients.GridColor = System.Drawing.Color.Black;
            this.dataGridViewPatients.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPatients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPatients.RowTemplate.Height = 25;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1486, 835);
            this.dataGridViewPatients.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.Width = 153;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Длина бедра (см)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 211;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Длина голени (см)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 212;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "Высота стопы (см)";
            this.Column6.Name = "Column6";
            this.Column6.Width = 211;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPatients);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 864);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextBoxSearchPatient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1486, 29);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поиск по ФИО:";
            // 
            // ArchivePatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1686, 864);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuArchivePatients);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ArchivePatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив пациентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ArchivePatientsForm_Load);
            this.panelMenuArchivePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearchPatient;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panelMenuArchivePatients;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}