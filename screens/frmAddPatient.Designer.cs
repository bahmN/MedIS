
namespace MedIS.screens
{
    partial class frmAddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPolis = new System.Windows.Forms.Label();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.tbPolis = new System.Windows.Forms.MaskedTextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAccept = new System.Windows.Forms.Button();
            this.tbDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(404, 25);
            this.panelTop.TabIndex = 0;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(110, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(184, 23);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Добавить пациента";
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDateBirth.ForeColor = System.Drawing.Color.Black;
            this.labelDateBirth.Location = new System.Drawing.Point(9, 109);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(125, 19);
            this.labelDateBirth.TabIndex = 29;
            this.labelDateBirth.Text = "Дата рождения";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbFullName.Location = new System.Drawing.Point(201, 77);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(191, 21);
            this.tbFullName.TabIndex = 25;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelFullName.ForeColor = System.Drawing.Color.Black;
            this.labelFullName.Location = new System.Drawing.Point(9, 78);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(184, 19);
            this.labelFullName.TabIndex = 22;
            this.labelFullName.Text = "Фамилия, Имя, Очество";
            // 
            // labelPolis
            // 
            this.labelPolis.AutoSize = true;
            this.labelPolis.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPolis.ForeColor = System.Drawing.Color.Black;
            this.labelPolis.Location = new System.Drawing.Point(8, 47);
            this.labelPolis.Name = "labelPolis";
            this.labelPolis.Size = new System.Drawing.Size(114, 19);
            this.labelPolis.TabIndex = 21;
            this.labelPolis.Text = "Номер полиса";
            // 
            // tbPassport
            // 
            this.tbPassport.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbPassport.Location = new System.Drawing.Point(201, 196);
            this.tbPassport.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(191, 21);
            this.tbPassport.TabIndex = 36;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPassport.ForeColor = System.Drawing.Color.Black;
            this.labelPassport.Location = new System.Drawing.Point(9, 197);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(161, 19);
            this.labelPassport.TabIndex = 35;
            this.labelPassport.Text = "Паспортные данные";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(9, 168);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 19);
            this.labelPhone.TabIndex = 33;
            this.labelPhone.Text = "Телефон";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbAdress.Location = new System.Drawing.Point(201, 138);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(191, 21);
            this.tbAdress.TabIndex = 32;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelAdress.ForeColor = System.Drawing.Color.Black;
            this.labelAdress.Location = new System.Drawing.Point(9, 139);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(55, 19);
            this.labelAdress.TabIndex = 31;
            this.labelAdress.Text = "Адрес";
            // 
            // tbPolis
            // 
            this.tbPolis.Location = new System.Drawing.Point(201, 47);
            this.tbPolis.Mask = "0000000000000000";
            this.tbPolis.Name = "tbPolis";
            this.tbPolis.Size = new System.Drawing.Size(191, 21);
            this.tbPolis.TabIndex = 37;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(201, 167);
            this.tbPhone.Mask = "80000000000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(191, 21);
            this.tbPhone.TabIndex = 38;
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnCancel.FlatAppearance.BorderSize = 0;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnCancel.ForeColor = System.Drawing.Color.Black;
            this.bttnCancel.Location = new System.Drawing.Point(210, 232);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(182, 30);
            this.bttnCancel.TabIndex = 40;
            this.bttnCancel.Text = "Отмена";
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnAccept
            // 
            this.bttnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAccept.FlatAppearance.BorderSize = 0;
            this.bttnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAccept.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAccept.ForeColor = System.Drawing.Color.Black;
            this.bttnAccept.Location = new System.Drawing.Point(13, 232);
            this.bttnAccept.Name = "bttnAccept";
            this.bttnAccept.Size = new System.Drawing.Size(182, 30);
            this.bttnAccept.TabIndex = 39;
            this.bttnAccept.Text = "Подтвердить";
            this.bttnAccept.UseVisualStyleBackColor = false;
            this.bttnAccept.Click += new System.EventHandler(this.bttnAccept_Click);
            // 
            // tbDateBirth
            // 
            this.tbDateBirth.Location = new System.Drawing.Point(201, 108);
            this.tbDateBirth.Mask = "00/00/0000";
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.Size = new System.Drawing.Size(191, 21);
            this.tbDateBirth.TabIndex = 41;
            this.tbDateBirth.ValidatingType = typeof(System.DateTime);
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 275);
            this.Controls.Add(this.tbDateBirth);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAccept);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPolis);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelDateBirth);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelPolis);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelDateBirth;
        public System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelPolis;
        public System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAccept;
        public System.Windows.Forms.MaskedTextBox tbDateBirth;
        public System.Windows.Forms.MaskedTextBox tbPhone;
        public System.Windows.Forms.MaskedTextBox tbPolis;
    }
}