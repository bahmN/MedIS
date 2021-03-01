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

        // Закрыть окно
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Подтвердить внесение инф-ии
        private void bttnAccept_Click(object sender, EventArgs e)
        {
            string FullName = tbFullName.Text;
            string Position = tbPos.Text;
            string Specialization = tbSpec.Text;

            AddPersonal addPersonal = new AddPersonal();
            addPersonal.addPersonal(FullName, Position, Specialization);

            Close();
        }
    }
}
