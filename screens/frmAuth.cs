using MedIS.logic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnAccept_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            string password = Hashing.HashPassword(tbPassword.Text);
            if (cbAdm.Checked == true ) {
                MySqlCommand cSelect = new MySqlCommand("SELECT Логин, Пароль, Примечание FROM персонал WHERE Логин= '" + tbLogin.Text + "' AND Пароль= '" + password + "' AND Примечание= 'Администратор'", con.connect());
                MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
                DataTable dtSelect = new DataTable();
                daSelect.Fill(dtSelect);
                if (dtSelect.Rows.Count > 0) {
                    frmAdminMenu fAM = new frmAdminMenu();
                    fAM.ShowDialog();
                }
                else {
                    MessageBox.Show("Пожалуйста, проверьте правильность введенных данных", "Неправильный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MySqlCommand cSelect = new MySqlCommand("SELECT Логин, Пароль FROM персонал WHERE Логин= '" + tbLogin.Text + "' AND Пароль= '" + password + "'", con.connect());
                MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
                DataTable dtSelect = new DataTable();
                daSelect.Fill(dtSelect);
                if (dtSelect.Rows.Count > 0) {
                    frmUserMenu fUM = new frmUserMenu();
                    fUM.ShowDialog();
                }
                else {
                    MessageBox.Show("Пожалуйста, проверьте правильность введенных данных", "Неправильный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
