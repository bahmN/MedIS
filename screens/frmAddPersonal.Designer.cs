
namespace MedIS.screens
{
    partial class frmAddPersonal
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
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAccept = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.Salmon;
            this.panelMenuTop.Controls.Add(this.labelMenu);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(402, 25);
            this.panelMenuTop.TabIndex = 0;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(126, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(151, 23);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Добавить врача";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelFullName.ForeColor = System.Drawing.Color.Black;
            this.labelFullName.Location = new System.Drawing.Point(8, 47);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(181, 19);
            this.labelFullName.TabIndex = 7;
            this.labelFullName.Text = "Фамилия, имя, очество";
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPos.ForeColor = System.Drawing.Color.Black;
            this.labelPos.Location = new System.Drawing.Point(8, 77);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(91, 19);
            this.labelPos.TabIndex = 8;
            this.labelPos.Text = "Должность";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelSpec.ForeColor = System.Drawing.Color.Black;
            this.labelSpec.Location = new System.Drawing.Point(8, 107);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(128, 19);
            this.labelSpec.TabIndex = 9;
            this.labelSpec.Text = "Специализация";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbFullName.Location = new System.Drawing.Point(200, 46);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(191, 21);
            this.tbFullName.TabIndex = 10;
            // 
            // tbPos
            // 
            this.tbPos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbPos.Location = new System.Drawing.Point(200, 76);
            this.tbPos.Margin = new System.Windows.Forms.Padding(2);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(191, 21);
            this.tbPos.TabIndex = 11;
            // 
            // tbSpec
            // 
            this.tbSpec.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbSpec.Location = new System.Drawing.Point(200, 106);
            this.tbSpec.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(191, 21);
            this.tbSpec.TabIndex = 12;
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
            this.bttnCancel.Location = new System.Drawing.Point(212, 233);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(179, 30);
            this.bttnCancel.TabIndex = 14;
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
            this.bttnAccept.Location = new System.Drawing.Point(10, 233);
            this.bttnAccept.Name = "bttnAccept";
            this.bttnAccept.Size = new System.Drawing.Size(179, 30);
            this.bttnAccept.TabIndex = 13;
            this.bttnAccept.Text = "Подтвердить";
            this.bttnAccept.UseVisualStyleBackColor = false;
            this.bttnAccept.Click += new System.EventHandler(this.bttnAccept_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelNote.Location = new System.Drawing.Point(8, 197);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(102, 19);
            this.labelNote.TabIndex = 15;
            this.labelNote.Text = "Примечание";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbNote.Location = new System.Drawing.Point(200, 196);
            this.tbNote.Margin = new System.Windows.Forms.Padding(2);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(191, 21);
            this.tbNote.TabIndex = 16;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbLogin.Location = new System.Drawing.Point(200, 136);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(191, 21);
            this.tbLogin.TabIndex = 18;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(8, 137);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(54, 19);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbPassword.Location = new System.Drawing.Point(200, 166);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 21);
            this.tbPassword.TabIndex = 20;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(8, 167);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 19);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Пароль";
            // 
            // frmAddPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 278);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAccept);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbPos);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.panelMenuTop);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPersonal";
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAccept;
        private System.Windows.Forms.Label labelNote;
        public System.Windows.Forms.TextBox tbFullName;
        public System.Windows.Forms.TextBox tbPos;
        public System.Windows.Forms.TextBox tbSpec;
        public System.Windows.Forms.TextBox tbNote;
        public System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}