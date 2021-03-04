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
            labelMenu.Text = "Добавить врача";
        }
        public frmAddPersonal(string pk)
        {
            PK = pk;
            InitializeComponent();
            labelMenu.Text = "Изменить информацию о враче";
            labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;
        }
        private string PK;
        public bool addOrChange;

        // Закрыть окно
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                if(FullName != "") {
                    if (Position != "") {
                        if (Specialization != "") {
                            if (Note != "") {
                                if (Login != "") {
                                    if (Password != "") {
                                        personal.addPersonal(FullName.Trim(), Position.Trim(), Specialization.Trim(), Note.Trim(), Login.Trim(), Password.Trim());

                                        Close();

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (addOrChange == false) {
                if (FullName != "") {
                    if (Position != "") {
                        if (Specialization != "") {
                            if (Note != "") {
                                if (Login != "") {
                                    if (Password != "") {
                                        personal.changePersonal(PK, FullName.Trim(), Position.Trim(), Specialization.Trim(), Note.Trim());
                                        Close();
                                    }
                                }
                            }
                        }
                    }
                }
               
            }
        }
    }
}
