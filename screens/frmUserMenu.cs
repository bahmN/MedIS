using MedIS.logic;
using MySql.Data.MySqlClient;
using System.Data;
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
            // Закрыть правый блок инф-ии после изменения
            bttnCloseRight_Click(sender, e);
        }

        // Удалить пациента
        private void bttnDeletePatient_Click(object sender, System.EventArgs e)
        {
            string headerText = dataGridViewPat.Columns[0].HeaderText;
            string selectRow = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
            Patient delete = new Patient();
            delete.deletePatient(headerText, selectRow);
            frmUserMenu_Load(sender, e);

            // Очистка label'ов после удаления данных
            labelTxtPolis.Text = null;
            labelTxtFN.Text = null;
            labelTxtDateBirth.Text = null;
            labelTxtAdress.Text = null;
            labelTxtPhone.Text = null;
            labelTxtPassport.Text = null;

            // Закрыть правый блок инф-ии после удаления
            bttnCloseRight_Click(sender, e);
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

                Width = 1212;
                Height = 706;
                labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;

                labelTxtPolis.Text = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString(); // Отобразить Полис в label
                labelTxtFN.Text = dataGridViewPat.SelectedRows[0].Cells[1].Value.ToString(); // Отобразить ФИО в label
                labelTxtDateBirth.Text = dataGridViewPat.SelectedRows[0].Cells[2].Value.ToString(); // Отобразить Дата рождения в label
                labelTxtAdress.Text = dataGridViewPat.SelectedRows[0].Cells[3].Value.ToString(); // Отобразить Адрес в label
                labelTxtPhone.Text = dataGridViewPat.SelectedRows[0].Cells[4].Value.ToString(); // Отобразить Телефон в label
                labelTxtPassport.Text = dataGridViewPat.SelectedRows[0].Cells[5].Value.ToString(); // Отобразить Паспортные данные в label

                string numbPatient = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
                // Отобразить записи к врачу
                Connection con = new Connection();
                MySqlDataAdapter daShow = new MySqlDataAdapter("SELECT * FROM `записи к врачу` WHERE `Номер пациента`= '" + numbPatient + "'", con.connect());
                DataTable dtShow = new DataTable();
                daShow.Fill(dtShow);
                dataGridViewAppointment.DataSource = dtShow;
                dataGridViewAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Column full width
                dataGridViewAppointment.RowHeadersVisible = false; // Hide the display of the left column
                dataGridViewAppointment.AllowUserToAddRows = false; // Hide the display of the bottom column
                dataGridViewAppointment.Columns[0].Visible = false; //Скрыть колонку с номером записи
                dataGridViewAppointment.Columns[1].Visible = false; //Скрыть колонку с номером пациента
                dataGridViewAppointment.Columns[2].Visible = false; //Скрыть колонку с номером врача   
                dataGridViewAppointment.Columns[3].Width = 115;
                labelTxtDoc.Text = null;
                labelTxtNote.Text = null;
            }
            catch { }
        }

        // Выделение строки в записях к врачу
        private void dataGridViewAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                Connection con = new Connection();
                dataGridViewAppointment.Rows[e.RowIndex].Selected = true;
                string docNum = dataGridViewAppointment.SelectedRows[0].Cells[2].Value.ToString();
                MySqlCommand cFullNameUser = new MySqlCommand("SELECT `ФИО врача` FROM персонал WHERE `Номер врача`= '" + docNum + "'", con.connect());
                object docFullNameObj = cFullNameUser.ExecuteScalar();
                string docFullName = docFullNameObj.ToString();
                labelTxtDoc.Text = docFullName;
                labelTxtNote.Text = dataGridViewAppointment.SelectedRows[0].Cells[6].Value.ToString();



                /*
                 * Отображение таблицы "диагнозы" в label
                 */
                string numAppointment = dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString();
                MySqlCommand cDiagnosis = new MySqlCommand("SELECT Название FROM диагнозы WHERE `Номер записи`= '" + numAppointment + "'", con.connect());
                object docDiagnosis = cDiagnosis.ExecuteScalar();
                MySqlCommand cResult = new MySqlCommand("SELECT Результат FROM диагнозы WHERE `Номер записи`= '" + numAppointment + "'", con.connect());
                object docResult = cResult.ExecuteScalar();
                MySqlCommand cNote= new MySqlCommand("SELECT Примечание FROM диагнозы WHERE `Номер записи`= '" + numAppointment + "'", con.connect());
                object docNote = cNote.ExecuteScalar();
                if (docDiagnosis != null && docResult != null && docNote != null) {
                    labelTxtDiagnosis.Text = docDiagnosis.ToString();
                    labelTxtResult.Text = docResult.ToString();
                    labelTxtNote.Text = docNote.ToString();

                }

            }
            catch { }
        }

        // Закрыть правый блок инф-ии о пациенте
        private void bttnCloseRight_Click(object sender, System.EventArgs e)
        {
            Width = 857;
            Height = 706;
            labelMenu.Left = ( ClientSize.Width - labelMenu.Width ) / 2;
        }

        // Добавить запись к врачу
        private void bttnAddAppointment_Click(object sender, System.EventArgs e)
        {
            frmAddAppoinment fAA = new frmAddAppoinment();
            fAA.numbPatient = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
            fAA.ShowDialog();
        }

        // Добавить диагноз
        private void bttnAddResults_Click(object sender, System.EventArgs e)
        {
            frmAddDiagnosis fAD = new frmAddDiagnosis();
            fAD.NumbAppoinment = dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString();
            fAD.addOrChange = true;
            fAD.ShowDialog();
        }

        // Добавить результат диагноза
        private void bttnAddResultDiagnosis_Click(object sender, System.EventArgs e)
        {
            try {
                Connection con = new Connection();
                string numAppointment = dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString();
                MySqlCommand cDiagnosis = new MySqlCommand("SELECT Название FROM диагнозы WHERE `Номер записи`= '" + numAppointment + "'", con.connect());
                object docDiagnosis = cDiagnosis.ExecuteScalar();
                if (docDiagnosis != null) {
                    string diagnosis = docDiagnosis.ToString();
                    frmAddDiagnosis fAD = new frmAddDiagnosis(diagnosis);
                    fAD.NumbAppoinment = dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString();
                    fAD.tbDiagnosis.Text = diagnosis;
                    fAD.addOrChange = false;
                    fAD.ShowDialog();
                }
            }
            catch { }
        }
    }
}
