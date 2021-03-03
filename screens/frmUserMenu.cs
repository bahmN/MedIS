using MedIS.logic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MedIS.screens
{
    public partial class frmUserMenu : Form
    {
        public frmUserMenu()
        {
            InitializeComponent();
            Width = 857;
            Height = 706;
            panelTop.Width = 857;
            labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;
        }

        private void frmUserMenu_Activated(object sender, System.EventArgs e)
        {
            frmUserMenu_Load(sender, e);
        }

        // Параметры при открытии окна
        private void frmUserMenu_Load(object sender, System.EventArgs e)
        {
            Connection con = new Connection();
            MySqlDataAdapter daShow = new MySqlDataAdapter("SELECT * FROM пациенты", con.connect());
            DataTable dtShow = new DataTable();
            daShow.Fill(dtShow);
            dataGridViewPat.DataSource = dtShow;
            dataGridViewPat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Column full width
            dataGridViewPat.RowHeadersVisible = false; // Hide the display of the left column
            dataGridViewPat.AllowUserToAddRows = false; // Hide the display of the bottom column
        }

        // Закрыть окно
        private void bttnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        // Добавить пациента
        private void bttnAddPatient_Click(object sender, System.EventArgs e)
        {
            frmAddPatient fAP = new frmAddPatient();
            fAP.addOrChange = true;
            fAP.ShowDialog();
        }

        // Изменить информацию о пациенте
        private void bttnChngPatient_Click(object sender, System.EventArgs e)
        {
            string PrimaryKey = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
            frmAddPatient fAP = new frmAddPatient(PrimaryKey);
            fAP.tbPolis.Text = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
            fAP.tbFullName.Text = dataGridViewPat.SelectedRows[0].Cells[1].Value.ToString();
            fAP.tbDateBirth.Text = dataGridViewPat.SelectedRows[0].Cells[2].Value.ToString();
            fAP.tbAdress.Text = dataGridViewPat.SelectedRows[0].Cells[3].Value.ToString();
            fAP.tbPhone.Text = dataGridViewPat.SelectedRows[0].Cells[4].Value.ToString();
            fAP.tbPassport.Text = dataGridViewPat.SelectedRows[0].Cells[5].Value.ToString();
            fAP.addOrChange = false;
            fAP.ShowDialog();
        }

        // Удалить пациента
        private void bttnDeletePatient_Click(object sender, System.EventArgs e)
        {
            string headerText = dataGridViewPat.Columns[0].HeaderText;
            string selectRow = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
            Patient delete = new Patient();
            delete.deletePatient(headerText, selectRow);
            frmUserMenu_Load(sender, e);
        }

        // Поиск
        private void tbSearch_TextChanged(object sender, System.EventArgs e)
        {
            Patient search = new Patient();
            search.searchPatient(tbSearch.Text);
            DataTable dtSearch = new DataTable();
            search.searchPatient(tbSearch.Text).Fill(dtSearch);
            dataGridViewPat.DataSource = dtSearch;
        }

        // Функция выделения строки и вывода информации в label
        private void dataGridViewPat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataGridViewPat.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        
    }
}
