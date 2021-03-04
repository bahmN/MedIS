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
                if(Polis != "") {
                    if(FN != "") {
                        if(DateBirth != "") {
                            if(Adress != "") {
                                if(Phone != "") {
                                    if(Passport != "") {
                                        Patient add = new Patient();
                                        add.addPatient(Polis, FN, DateBirth, Adress, Phone, Passport);
                                        Close();
                                    }
                                }
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Поля не могут быть пустыми", "Ошибка формата введенных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(addOrChange == false){
                if (Polis != "") {
                    if (FN != "") {
                        if (DateBirth != "") {
                            if (Adress != "") {
                                if (Phone != "") {
                                    if (Passport != "") {
                                        Patient chng = new Patient();
                                        chng.changePatient(Polis, FN, DateBirth, Adress, Phone, Passport, PK);
                                        Close();
                                    }
                                }
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Поля не могут быть пустыми", "Ошибка формата введенных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            
        }

        // Закрыть окно
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
