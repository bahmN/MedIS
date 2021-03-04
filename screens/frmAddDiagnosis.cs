using MedIS.logic;
using System;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmAddDiagnosis : Form
    {
        public frmAddDiagnosis()
        {
            InitializeComponent();
        }
        public frmAddDiagnosis(string pk)
        {
            PK = pk;
            InitializeComponent();
            labelMenu.Text = "Добавить результаты анализов";
            labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;
            tbDiagnosis.ReadOnly = true;
        }
        public string NumbAppoinment;
        private string PK;
        public bool addOrChange;
        public string NumPatient;
        // Подтвердить
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            string name = tbDiagnosis.Text;
            string result = cbResult.Text;
            string note = tbNote.Text;
            if (addOrChange == true) {
                if (name != "") {
                    Diagnosis add = new Diagnosis();
                    add.addDiagnosis(name, NumbAppoinment, result, note, NumPatient);
                    Close();
                }
                else {
                    MessageBox.Show("Поле \"Диагноз\" не может быть пустым", "Ошибка формата введенных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (addOrChange == false) {
                if (note != "") {
                    Diagnosis change = new Diagnosis();
                    change.changeDiagnosis(name, NumbAppoinment, result, note, PK);
                    Close();
                }
                else {
                    MessageBox.Show("Поле \"Результат\" не может быть пустым", "Ошибка формата введенных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
