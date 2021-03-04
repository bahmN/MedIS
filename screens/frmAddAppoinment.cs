using MedIS.logic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmAddAppoinment : Form
    {
        public frmAddAppoinment()
        {
            InitializeComponent();
        }
        public string numbPatient;
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            var numbDoctor = cbDoctor;
            string date = dateTimePicker.Text;
            string ambul = cbAmbul.Text;
            string dispanser = cbDispancer.Text;
            string note = tbNote.Text;
            DoctorAppointment add = new DoctorAppointment();
            add.addAppoinment(numbPatient, numbDoctor.SelectedValue, date, ambul, dispanser, note);
            Close();
        }

        private void frmAddAppoinment_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            // Заполнение comboBox'a врачами
            MySqlDataAdapter commandABP = new MySqlDataAdapter("SELECT `Номер врача`, `ФИО врача` FROM персонал", con.connect());
            DataTable dtABP = new DataTable();
            commandABP.Fill(dtABP);
            cbDoctor.DataSource = dtABP;
            cbDoctor.DisplayMember = "ФИО врача";
            cbDoctor.ValueMember = "Номер врача";
            cbDoctor.SelectedIndex = -1;

            //Параметры dateTimePicker
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.MaxDate = DateTime.Now;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
