using MedIS.logic;
using System;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }
        public frmAddPatient(string pk)
        {
            PK = pk;
            InitializeComponent();
            labelMenu.Text = "Изменить информацию о пациенте";
            labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;
        }
        private string PK;
        public bool addOrChange;
        
        // Подтвердить внесение информации
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            string Polis = tbPolis.Text;
            string FN = tbFullName.Text;
            string DateBirth = tbDateBirth.Text;
            string Adress = tbAdress.Text;
            string Phone = tbPhone.Text;
            string Passport = tbPassport.Text;
            if (addOrChange == true) {
                Patient add = new Patient();                
                add.addPatient(Polis, FN, DateBirth, Adress, Phone, Passport);
                Close();
            }
            else if(addOrChange == false){
                Patient chng = new Patient();
                chng.changePatient(Polis, FN, DateBirth, Adress, Phone, Passport, PK);
                Close();
            }
            
        }

        // Закрыть окно
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
