using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using TestOblojca.Properties;

namespace TestOblojca
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Button currentButton;
        private bool isCollapsedPanelSetting;
        private bool isCollapsedPanelHelp;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (System.Windows.Forms.Button)btnSender;
                    currentButton.BackColor = color;
                    panelTitlePage.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    if (btnSender != btnSetting)
                    {
                        timer1.Stop();
                        panelBtnSetting.BackColor = Color.FromArgb(51, 51, 76);
                        btnSetting.BackColor = Color.FromArgb(51, 51, 76);
                        panelBtnSetting.Size = MinimumSize;
                        pictureBoxForSetting.Image = Resources.down_arrow_icon_icons_com_64915;
                        isCollapsedPanelSetting = true;
                    }

                    if (btnSender != btnHelp)
                    {
                        timer2.Stop();
                        //panelBtnHelp.BackColor = Color.FromArgb(51, 51, 76);
                        //btnHelp.BackColor = Color.FromArgb(51, 51, 76);
                        panelBtnHelp.Size = MinimumSize;
                        pictureBoxForHelp.Image = Resources.down_arrow_icon_icons_com_64915;
                        isCollapsedPanelHelp = true;
                    }
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn  in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPrintForm.Controls.Add(childForm);
            this.panelPrintForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblForPrintName.Text = childForm.Text;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ArchivePatientsForm(), sender);
        }

        private void btnRehabilitation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            timer1.Start();
            panelBtnSetting.BackColor = ThemeColor.PrimaryColor;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            timer2.Start();
            panelBtnHelp.BackColor = ThemeColor.PrimaryColor;
        }

        private void Reset()
        {
            DisableButton();
            lblForPrintName.Text = "Начальная страница";
            panelTitlePage.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        private void panelTitlePage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsedPanelSetting)
            {
                pictureBoxForSetting.Image = Resources.up_arrow_icon_icons_com_65094;
                panelBtnSetting.Height += 5;
                if (panelBtnSetting.Height >= panelBtnSetting.MaximumSize.Height)
                {
                    timer1.Stop();
                    isCollapsedPanelSetting = false;
                }
            }
            else
            {
                pictureBoxForSetting.Image = Resources.down_arrow_icon_icons_com_64915;
                panelBtnSetting.Height -= 5;
                if (panelBtnSetting.Height <= panelBtnSetting.MinimumSize.Height)
                {
                    timer1.Stop();
                    isCollapsedPanelSetting = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedPanelHelp)
            {
                pictureBoxForHelp.Image = Resources.up_arrow_icon_icons_com_65094;
                panelBtnHelp.Height += 5;
                if (panelBtnHelp.Height >= panelBtnHelp.MaximumSize.Height)
                {
                    timer2.Stop();
                    isCollapsedPanelHelp = false;
                }
            }
            else
            {
                pictureBoxForHelp.Image = Resources.down_arrow_icon_icons_com_64915;
                panelBtnHelp.Height -= 5;
                if (panelBtnHelp.Height <= panelBtnHelp.MinimumSize.Height)
                {
                    timer2.Stop();
                    isCollapsedPanelHelp = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (timer1 == null)
            { 
                timer1 = new System.Windows.Forms.Timer();
            }

            timer1.Start();

            if (timer1 == null)
            {
                timer2 = new System.Windows.Forms.Timer();
            }

            timer2.Start();
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAboutDevelopers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDiagnosticSystem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DiagnosticSystem(), sender);
        }

        private void btnManualControl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ManualControl(), sender);
        }
    }
}