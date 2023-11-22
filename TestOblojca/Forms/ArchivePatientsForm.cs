﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestOblojca.Forms
{
    public partial class ArchivePatientsForm : Form
    {
        private Random random;
        private int tempIndex;
        private System.Windows.Forms.Button currentButton;
        private string patientsFilePath = "c:\\Patients\\patients.xlsx";
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private List<Patient> patientList;
        private readonly DataGridView dataGridView;
        public Patient SelectedPatient { get; private set; }
        public string SelectedPatientFullName;

        public ArchivePatientsForm()
        {
            InitializeComponent();
            random = new Random();
            LoadPatients();
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged; 
        }
        private void ArchivePatientsForm_Load(object sender, EventArgs e)
        {
            //LoadTheme();
            label1.ForeColor = ThemeColor.SecondaryColor;
            panelMenuArchivePatients.BackColor = ThemeColor.PrimaryColor;
        }
        
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
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
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    ThemeColor.PrimaryColor = ThemeColor.PrimaryColor;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuArchivePatients.Controls)
            {
                if (previousBtn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    previousBtn.BackColor = ThemeColor.PrimaryColor;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void LoadPatients()
        {
            excelApp = new Excel.Application();
            patientList = new List<Patient>();

            workbook = excelApp.Workbooks.Open(patientsFilePath);
            worksheet = workbook.ActiveSheet;

            int rowCount = worksheet.UsedRange.Rows.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                var firstName = worksheet.Cells[i, 1].Value;
                var lastName = worksheet.Cells[i, 2].Value;
                var middleName = worksheet.Cells[i, 3].Value;
                var thighLength = worksheet.Cells[i, 4].Value;
                var calfLength = worksheet.Cells[i, 5].Value;
                var footLength = worksheet.Cells[i, 6].Value;

                if (firstName != null)
                {
                    Patient patient = new Patient()
                    {
                        FirstName = firstName.ToString(),
                        LastName = lastName != null ? lastName.ToString() : "",
                        MiddleName = middleName != null ? middleName.ToString() : "",
                        ThighLength = thighLength != null ? double.Parse(thighLength.ToString()) : 0,
                        CalfLength = calfLength != null ? double.Parse(calfLength.ToString()) : 0,
                        FootLength = footLength != null ? double.Parse(footLength.ToString()) : 0
                    };
                    patientList.Add(patient);
                }
            }
            workbook.Close();
            excelApp.Quit();
            SortPatients();
            UpdatePatientsList();
        }

        private void SavePatients()
        {
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Open(patientsFilePath);
            worksheet = workbook.ActiveSheet;

            int rowCount = worksheet.UsedRange.Rows.Count;

            for (int i = rowCount; i >= 1; i--)
            {
                worksheet.Rows[i].Delete();
            }

            for (int i = 0; i < patientList.Count; i++)
            {
                Patient patient = patientList[i];
                worksheet.Cells[i + 1, 1] = patient.FirstName;
                worksheet.Cells[i + 1, 2] = patient.LastName;
                worksheet.Cells[i + 1, 3] = patient.MiddleName;
                worksheet.Cells[i + 1, 4] = patient.ThighLength;
                worksheet.Cells[i + 1, 5] = patient.CalfLength;
                worksheet.Cells[i + 1, 6] = patient.FootLength;
            }
            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddPatientForm addPatientForm = new AddPatientForm(patientList);
            if (addPatientForm.ShowDialog() == DialogResult.OK)
            {
                SavePatients();
                UpdatePatientsList();
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;

                if (dataGridViewPatients.Rows[selectedIndex].Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewPatients.Rows[selectedIndex].Cells[0].Value.ToString()))
                {
                    Patient selectedPatient = patientList[selectedIndex];
                    EditPatientForm editPatientForm = new EditPatientForm(patientList, selectedPatient, dataGridView);
                    if (editPatientForm.ShowDialog() == DialogResult.OK)
                    {
                        SavePatients();
                        UpdatePatientsList();
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;

                if (dataGridViewPatients.Rows[selectedIndex].Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewPatients.Rows[selectedIndex].Cells[0].Value.ToString()))
                {
                    DialogResult dialogResult = MessageBox.Show("Вы желаете удалить выбранного пациента?", "Предупреждение",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) {
                        patientList.RemoveAt(selectedIndex);
                        SavePatients();
                        UpdatePatientsList();
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePatientsList()
        {
            dataGridViewPatients.Rows.Clear();
            SortPatients();

            foreach (Patient patient in patientList)
            {
                dataGridViewPatients.Rows.Add(patient.LastName, patient.FirstName, patient.MiddleName, patient.ThighLength, patient.CalfLength, patient.FootLength);
            }
        }

        private void DataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewPatients.SelectionChanged -= DataGridViewPatients_SelectionChanged;

            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;
                dataGridViewPatients.ClearSelection();
                dataGridViewPatients.Rows[selectedIndex].Selected = true;
            }
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dataGridViewPatients.SelectionChanged -= DataGridViewPatients_SelectionChanged;

            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;

                if (dataGridViewPatients.Rows[selectedIndex].Cells[0].Value != null &&
                    !string.IsNullOrEmpty(dataGridViewPatients.Rows[selectedIndex].Cells[0].Value.ToString()))
                {
                    DataGridViewRow selectedRow = dataGridViewPatients.Rows[selectedIndex];
                    string selectedLastName = selectedRow.Cells[0].Value.ToString();
                    string selectedFirstName = selectedRow.Cells[1].Value.ToString();
                    string selectedMiddleName = selectedRow.Cells[2].Value.ToString();

                    SelectedPatient = patientList.FirstOrDefault(p =>
                        p.LastName == selectedLastName &&
                        p.FirstName == selectedFirstName &&
                        p.MiddleName == selectedMiddleName);

                    if (SelectedPatient != null)
                    {
                        SelectedPatientFullName = $"{SelectedPatient.LastName} {SelectedPatient.FirstName} {SelectedPatient.MiddleName}";
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Выбранный пациент не найден в списке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;
        }

        private void SearchPatient(string searchText)
        {
            dataGridViewPatients.Rows.Clear();
            string[] searchWords = searchText.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (Patient patient in patientList)
            {
                bool matchFound = true;
                foreach (string word in searchWords)
                {
                    if (!(patient.FirstName.ToLower().Contains(word) ||
                          patient.LastName.ToLower().Contains(word) ||
                          patient.MiddleName.ToLower().Contains(word)))
                    {
                        matchFound = false;
                        break;
                    }
                }

                if (matchFound)
                {
                    dataGridViewPatients.Rows.Add(patient.LastName, patient.FirstName, patient.MiddleName, patient.ThighLength, patient.CalfLength, patient.FootLength);
                }
            }
            dataGridViewPatients.Refresh();
            SortPatients();
        }
        private void SortPatients()
        {
            patientList = patientList.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ThenBy(p => p.MiddleName).ToList();
        }

        private void TextBoxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearchPatient.Text;
            SearchPatient(searchText);
        }
    }
}
