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
        // Подтивердить
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            if (addOrChange == true) {
                string name = tbDiagnosis.Text;
                string result = cbResult.Text;
                string note = tbNote.Text;
                Diagnosis add = new Diagnosis();
                add.addDiagnosis(name, NumbAppoinment, result, note, NumPatient);
                Close();
            }
            else if (addOrChange == false){
                string name = tbDiagnosis.Text;
                string result = cbResult.Text;
                string note = tbNote.Text;
                Diagnosis change = new Diagnosis();
                change.changeDiagnosis(name, NumbAppoinment, result, note, PK);
                Close();
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
