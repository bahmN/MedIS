
namespace MedIS.screens
{
    partial class frmAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuth));
            this.bttnAccept = new System.Windows.Forms.Button();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.cbAdm = new System.Windows.Forms.CheckBox();
            this.panelMenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.SuspendLayout();
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
            this.bttnAccept.Location = new System.Drawing.Point(17, 130);
            this.bttnAccept.Name = "bttnAccept";
            this.bttnAccept.Size = new System.Drawing.Size(291, 30);
            this.bttnAccept.TabIndex = 22;
            this.bttnAccept.Text = "Войти";
            this.bttnAccept.UseVisualStyleBackColor = false;
            this.bttnAccept.Click += new System.EventHandler(this.bttnAccept_Click);
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.Salmon;
            this.panelMenuTop.Controls.Add(this.bttnClose);
            this.panelMenuTop.Controls.Add(this.labelMenu);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(323, 25);
            this.panelMenuTop.TabIndex = 21;
            // 
            // bttnClose
            // 
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(289, 2);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(20, 20);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bttnClose.TabIndex = 19;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(100, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(123, 23);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Авторизация";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbPassword.Location = new System.Drawing.Point(117, 75);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(191, 21);
            this.tbPassword.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(13, 77);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 19);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbLogin.Location = new System.Drawing.Point(117, 45);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(191, 21);
            this.tbLogin.TabIndex = 24;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(13, 47);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(54, 19);
            this.labelLogin.TabIndex = 23;
            this.labelLogin.Text = "Логин";
            // 
            // cbAdm
            // 
            this.cbAdm.AutoSize = true;
            this.cbAdm.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.cbAdm.Location = new System.Drawing.Point(179, 103);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(129, 21);
            this.cbAdm.TabIndex = 27;
            this.cbAdm.Text = "Администратор";
            this.cbAdm.UseVisualStyleBackColor = true;
            // 
            // frmAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 171);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.bttnAccept);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.labelLogin);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuth";
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAccept;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label labelMenu;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.CheckBox cbAdm;
    }
}