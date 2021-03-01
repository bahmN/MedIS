﻿using MedIS.logic;
using MedIS.screens;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
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
            dataGridViewUsr.AllowUserToAddRows = false;// Hide the display of the bottom column
            dataGridViewUsr.Columns[0].Width = 100;
        }

        // Добавление персонала
        private void bttnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPersonal fAP = new frmAddPersonal();
            fAP.ShowDialog();
        }

        private void frmAdminMenu_Activated(object sender, EventArgs e)
        {
            frmAdminMenu_Load(sender, e);
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
    }
}
