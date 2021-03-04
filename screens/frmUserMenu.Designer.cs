
namespace MedIS.screens
{
    partial class frmUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.dataGridViewPat = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bttnChngPatient = new System.Windows.Forms.Button();
            this.bttnAddPatient = new System.Windows.Forms.Button();
            this.bttnDeletePatient = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelTxtFN = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelTxtDateBirth = new System.Windows.Forms.Label();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.labelTxtAdress = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelTxtPhone = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelTxtPassport = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelTxtPolis = new System.Windows.Forms.Label();
            this.labelPolis = new System.Windows.Forms.Label();
            this.bttnCloseRight = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCloseRight)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1212, 25);
            this.panelTop.TabIndex = 0;
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(1180, 2);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(20, 20);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bttnClose.TabIndex = 20;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(492, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(188, 23);
            this.labelMenu.TabIndex = 19;
            this.labelMenu.Text = "Панель-меню врача";
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.AllowDrop = true;
            this.dataGridViewPat.AllowUserToAddRows = false;
            this.dataGridViewPat.AllowUserToDeleteRows = false;
            this.dataGridViewPat.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPat.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewPat.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPat.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewPat.Name = "dataGridViewPat";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPat.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPat.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewPat.Size = new System.Drawing.Size(835, 619);
            this.dataGridViewPat.TabIndex = 2;
            this.dataGridViewPat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPat_CellClick);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Salmon;
            this.panelBottom.ForeColor = System.Drawing.Color.Salmon;
            this.panelBottom.Location = new System.Drawing.Point(0, 656);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(863, 2);
            this.panelBottom.TabIndex = 3;
            // 
            // bttnChngPatient
            // 
            this.bttnChngPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnChngPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnChngPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnChngPatient.FlatAppearance.BorderSize = 0;
            this.bttnChngPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChngPatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnChngPatient.ForeColor = System.Drawing.Color.Black;
            this.bttnChngPatient.Location = new System.Drawing.Point(197, 664);
            this.bttnChngPatient.Name = "bttnChngPatient";
            this.bttnChngPatient.Size = new System.Drawing.Size(278, 30);
            this.bttnChngPatient.TabIndex = 16;
            this.bttnChngPatient.Text = "Изменить информацию о пациенте";
            this.bttnChngPatient.UseVisualStyleBackColor = false;
            this.bttnChngPatient.Click += new System.EventHandler(this.bttnChngPatient_Click);
            // 
            // bttnAddPatient
            // 
            this.bttnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAddPatient.FlatAppearance.BorderSize = 0;
            this.bttnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddPatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.bttnAddPatient.Location = new System.Drawing.Point(12, 664);
            this.bttnAddPatient.Name = "bttnAddPatient";
            this.bttnAddPatient.Size = new System.Drawing.Size(179, 30);
            this.bttnAddPatient.TabIndex = 15;
            this.bttnAddPatient.Text = "Добавить пациента";
            this.bttnAddPatient.UseVisualStyleBackColor = false;
            this.bttnAddPatient.Click += new System.EventHandler(this.bttnAddPatient_Click);
            // 
            // bttnDeletePatient
            // 
            this.bttnDeletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnDeletePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDeletePatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnDeletePatient.FlatAppearance.BorderSize = 0;
            this.bttnDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDeletePatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnDeletePatient.ForeColor = System.Drawing.Color.Black;
            this.bttnDeletePatient.Location = new System.Drawing.Point(481, 664);
            this.bttnDeletePatient.Name = "bttnDeletePatient";
            this.bttnDeletePatient.Size = new System.Drawing.Size(179, 30);
            this.bttnDeletePatient.TabIndex = 17;
            this.bttnDeletePatient.Text = "Удалить пацента";
            this.bttnDeletePatient.UseVisualStyleBackColor = false;
            this.bttnDeletePatient.Click += new System.EventHandler(this.bttnDeletePatient_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Salmon;
            this.panelRight.ForeColor = System.Drawing.Color.Salmon;
            this.panelRight.Location = new System.Drawing.Point(861, 25);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2, 682);
            this.panelRight.TabIndex = 18;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbSearch.Location = new System.Drawing.Point(719, 669);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(128, 21);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelSearch.ForeColor = System.Drawing.Color.Black;
            this.labelSearch.Location = new System.Drawing.Point(663, 670);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(54, 19);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Поиск";
            // 
            // labelTxtFN
            // 
            this.labelTxtFN.AutoSize = true;
            this.labelTxtFN.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtFN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtFN.Location = new System.Drawing.Point(880, 115);
            this.labelTxtFN.Name = "labelTxtFN";
            this.labelTxtFN.Size = new System.Drawing.Size(37, 19);
            this.labelTxtFN.TabIndex = 22;
            this.labelTxtFN.Text = "null";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelFN.ForeColor = System.Drawing.Color.Black;
            this.labelFN.Location = new System.Drawing.Point(880, 96);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(122, 19);
            this.labelFN.TabIndex = 21;
            this.labelFN.Text = "ФИО пациента:";
            // 
            // labelTxtDateBirth
            // 
            this.labelTxtDateBirth.AutoSize = true;
            this.labelTxtDateBirth.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtDateBirth.Location = new System.Drawing.Point(880, 153);
            this.labelTxtDateBirth.Name = "labelTxtDateBirth";
            this.labelTxtDateBirth.Size = new System.Drawing.Size(37, 19);
            this.labelTxtDateBirth.TabIndex = 24;
            this.labelTxtDateBirth.Text = "null";
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDateBirth.ForeColor = System.Drawing.Color.Black;
            this.labelDateBirth.Location = new System.Drawing.Point(880, 134);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(129, 19);
            this.labelDateBirth.TabIndex = 23;
            this.labelDateBirth.Text = "Дата рождения:";
            // 
            // labelTxtAdress
            // 
            this.labelTxtAdress.AutoSize = true;
            this.labelTxtAdress.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtAdress.Location = new System.Drawing.Point(880, 191);
            this.labelTxtAdress.Name = "labelTxtAdress";
            this.labelTxtAdress.Size = new System.Drawing.Size(37, 19);
            this.labelTxtAdress.TabIndex = 26;
            this.labelTxtAdress.Text = "null";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelAdress.ForeColor = System.Drawing.Color.Black;
            this.labelAdress.Location = new System.Drawing.Point(880, 172);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(59, 19);
            this.labelAdress.TabIndex = 25;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelTxtPhone
            // 
            this.labelTxtPhone.AutoSize = true;
            this.labelTxtPhone.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtPhone.Location = new System.Drawing.Point(880, 229);
            this.labelTxtPhone.Name = "labelTxtPhone";
            this.labelTxtPhone.Size = new System.Drawing.Size(37, 19);
            this.labelTxtPhone.TabIndex = 28;
            this.labelTxtPhone.Text = "null";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(880, 210);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(76, 19);
            this.labelPhone.TabIndex = 27;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelTxtPassport
            // 
            this.labelTxtPassport.AutoSize = true;
            this.labelTxtPassport.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtPassport.Location = new System.Drawing.Point(880, 267);
            this.labelTxtPassport.MaximumSize = new System.Drawing.Size(325, 0);
            this.labelTxtPassport.Name = "labelTxtPassport";
            this.labelTxtPassport.Size = new System.Drawing.Size(37, 19);
            this.labelTxtPassport.TabIndex = 30;
            this.labelTxtPassport.Text = "null";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPassport.ForeColor = System.Drawing.Color.Black;
            this.labelPassport.Location = new System.Drawing.Point(880, 248);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(165, 19);
            this.labelPassport.TabIndex = 29;
            this.labelPassport.Text = "Паспортные данные:";
            // 
            // labelTxtPolis
            // 
            this.labelTxtPolis.AutoSize = true;
            this.labelTxtPolis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtPolis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtPolis.Location = new System.Drawing.Point(880, 77);
            this.labelTxtPolis.Name = "labelTxtPolis";
            this.labelTxtPolis.Size = new System.Drawing.Size(37, 19);
            this.labelTxtPolis.TabIndex = 32;
            this.labelTxtPolis.Text = "null";
            // 
            // labelPolis
            // 
            this.labelPolis.AutoSize = true;
            this.labelPolis.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelPolis.ForeColor = System.Drawing.Color.Black;
            this.labelPolis.Location = new System.Drawing.Point(880, 58);
            this.labelPolis.Name = "labelPolis";
            this.labelPolis.Size = new System.Drawing.Size(59, 19);
            this.labelPolis.TabIndex = 31;
            this.labelPolis.Text = "Полис:";
            // 
            // bttnCloseRight
            // 
            this.bttnCloseRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCloseRight.Image = ((System.Drawing.Image)(resources.GetObject("bttnCloseRight.Image")));
            this.bttnCloseRight.Location = new System.Drawing.Point(877, 31);
            this.bttnCloseRight.Name = "bttnCloseRight";
            this.bttnCloseRight.Size = new System.Drawing.Size(20, 20);
            this.bttnCloseRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bttnCloseRight.TabIndex = 21;
            this.bttnCloseRight.TabStop = false;
            this.bttnCloseRight.Click += new System.EventHandler(this.bttnCloseRight_Click);
            // 
            // frmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 706);
            this.Controls.Add(this.bttnCloseRight);
            this.Controls.Add(this.labelTxtPolis);
            this.Controls.Add(this.labelPolis);
            this.Controls.Add(this.labelTxtPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelTxtPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelTxtAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelTxtDateBirth);
            this.Controls.Add(this.labelDateBirth);
            this.Controls.Add(this.labelTxtFN);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewPat);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.bttnDeletePatient);
            this.Controls.Add(this.bttnChngPatient);
            this.Controls.Add(this.bttnAddPatient);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmUserMenu_Activated);
            this.Load += new System.EventHandler(this.frmUserMenu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCloseRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.DataGridView dataGridViewPat;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button bttnChngPatient;
        private System.Windows.Forms.Button bttnAddPatient;
        private System.Windows.Forms.Button bttnDeletePatient;
        private System.Windows.Forms.Panel panelRight;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelTxtFN;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelTxtDateBirth;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Label labelTxtAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelTxtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTxtPassport;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelTxtPolis;
        private System.Windows.Forms.Label labelPolis;
        private System.Windows.Forms.PictureBox bttnCloseRight;
    }
}