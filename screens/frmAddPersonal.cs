using MedIS.logic;
using System;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmAddPersonal : Form
    {

        public frmAddPersonal()
        {
            InitializeComponent();
        }
        public frmAddPersonal(string pk)
        {
            PK = pk;
            InitializeComponent();

        }
        private string PK;

        // Закрыть окно
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool addOrChange;
        // Подтвердить внесение инф-ии
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            string FullName = tbFullName.Text;
            string Position = tbPos.Text;
            string Specialization = tbSpec.Text;
            string Note = tbNote.Text;
            string Login = tbLogin.Text;
            string Password = Hashing.HashPassword(tbPassword.Text);
            if (addOrChange == true) {
                // Выполнение записи данных в БД
                personal.addPersonal(FullName.Trim(), Position.Trim(), Specialization.Trim(), Note.Trim(), Login.Trim(), Password.Trim());

                Close();
            }
            else if (addOrChange == false) {
                personal.changePersonal(PK, FullName.Trim(), Position.Trim(), Specialization.Trim(), Note.Trim());
                Close();
            }
        }
    }
}
