using MedIS.logic;
using MedIS.screens;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedIS
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            MySqlDataAdapter daShow = new MySqlDataAdapter("SELECT * FROM персонал", con.connect());
            DataTable dtShow = new DataTable();
            daShow.Fill(dtShow);
            dataGridViewUsr.DataSource = dtShow;
            dataGridViewUsr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Column full width
            dataGridViewUsr.RowHeadersVisible = false; // Hide the display of the left column
            dataGridViewUsr.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataGridViewUsr.Columns[0].Visible = false; //Скрыть колонку с номером врача
            dataGridViewUsr.Columns[4].Visible = false; //Скрыть колонку с Примечанием
            dataGridViewUsr.Columns[6].Visible = false; //Скрыть колонку с паролем
        }

        // Добавление персонала
        private void bttnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPersonal fAP = new frmAddPersonal();
            fAP.addOrChange = true;
            fAP.ShowDialog();
        }

        // Изменить информацию о персонале
        private void bttnChange_Click(object sender, EventArgs e)
        {
            string PrimaryKey = dataGridViewUsr.SelectedRows[0].Cells[0].Value.ToString();
            frmAddPersonal fAP = new frmAddPersonal(PrimaryKey);
            fAP.addOrChange = false;
            fAP.tbFullName.Text = dataGridViewUsr.SelectedRows[0].Cells[1].Value.ToString();
            fAP.tbPos.Text = dataGridViewUsr.SelectedRows[0].Cells[2].Value.ToString();
            fAP.tbNote.Text = dataGridViewUsr.SelectedRows[0].Cells[3].Value.ToString();
            fAP.tbSpec.Text = dataGridViewUsr.SelectedRows[0].Cells[4].Value.ToString();
            fAP.ShowDialog();
        }

        // Импорт базы данных
        private void bttnImport_Click(object sender, EventArgs e)
        {
            Backup import = new Backup();
            import.import(openFile);
        }

        // Экспорт базы данных
        private void bttnExport_Click(object sender, EventArgs e)
        {
            Backup export = new Backup();
            export.export(saveFile);
        }

        // Удалить персонал
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            string headerText = dataGridViewUsr.Columns[0].HeaderText;
            string selectRow = dataGridViewUsr.SelectedRows[0].Cells[0].Value.ToString();
            Personal delete = new Personal();
            delete.deletePersonal(headerText, selectRow);
            frmAdminMenu_Load(sender, e);
        }

        // Поиск
        private void tbNotePos_TextChanged(object sender, EventArgs e)
        {
            Personal search = new Personal();
            search.searchPersonal(tbSearch.Text);
            DataTable dtSearch = new DataTable();
            search.searchPersonal(tbSearch.Text).Fill(dtSearch);
            dataGridViewUsr.DataSource = dtSearch;
        }

        //Функция выделения строки и вывода информации в label
        private void dataGridViewUsr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataGridViewUsr.Rows[e.RowIndex].Selected = true;

                labelTxtNote.Text = dataGridViewUsr.SelectedRows[0].Cells[4].Value.ToString(); // Отобразить примечание в label
            }
            catch { }
        }

        // Закрыть приложение
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmAdminMenu_Activated(object sender, EventArgs e)
        {
            frmAdminMenu_Load(sender, e);
        }        
    }
}
