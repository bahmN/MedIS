
namespace MedIS
{
    partial class frmAdminMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.dataGridViewUsr = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bttnImport = new System.Windows.Forms.Button();
            this.bttnExport = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelTxtNote = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.bttnChange = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Label();
            this.bttnAddPerson = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Salmon;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(766, 25);
            this.panelTop.TabIndex = 0;
            // 
            // bttnClose
            // 
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(735, 1);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(20, 20);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bttnClose.TabIndex = 18;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(243, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(280, 23);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Панель-меню администратора";
            // 
            // dataGridViewUsr
            // 
            this.dataGridViewUsr.AllowDrop = true;
            this.dataGridViewUsr.AllowUserToAddRows = false;
            this.dataGridViewUsr.AllowUserToDeleteRows = false;
            this.dataGridViewUsr.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsr.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUsr.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewUsr.Name = "dataGridViewUsr";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsr.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsr.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsr.Size = new System.Drawing.Size(742, 579);
            this.dataGridViewUsr.TabIndex = 1;
            this.dataGridViewUsr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsr_CellClick);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Salmon;
            this.panelBottom.ForeColor = System.Drawing.Color.Salmon;
            this.panelBottom.Location = new System.Drawing.Point(0, 654);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(766, 2);
            this.panelBottom.TabIndex = 2;
            // 
            // bttnImport
            // 
            this.bttnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnImport.FlatAppearance.BorderSize = 0;
            this.bttnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnImport.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnImport.ForeColor = System.Drawing.Color.Black;
            this.bttnImport.Location = new System.Drawing.Point(575, 672);
            this.bttnImport.Margin = new System.Windows.Forms.Padding(0);
            this.bttnImport.Name = "bttnImport";
            this.bttnImport.Size = new System.Drawing.Size(179, 30);
            this.bttnImport.TabIndex = 4;
            this.bttnImport.Text = "Импорт базы данных";
            this.bttnImport.UseVisualStyleBackColor = false;
            this.bttnImport.Click += new System.EventHandler(this.bttnImport_Click);
            // 
            // bttnExport
            // 
            this.bttnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnExport.FlatAppearance.BorderSize = 0;
            this.bttnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExport.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.bttnExport.ForeColor = System.Drawing.Color.Black;
            this.bttnExport.Location = new System.Drawing.Point(575, 708);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(179, 30);
            this.bttnExport.TabIndex = 5;
            this.bttnExport.Text = "Экспорт базы данных";
            this.bttnExport.UseVisualStyleBackColor = false;
            this.bttnExport.Click += new System.EventHandler(this.bttnExport_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelNote.ForeColor = System.Drawing.Color.Black;
            this.labelNote.Location = new System.Drawing.Point(12, 622);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(106, 19);
            this.labelNote.TabIndex = 6;
            this.labelNote.Text = "Примечание:";
            // 
            // labelTxtNote
            // 
            this.labelTxtNote.AutoSize = true;
            this.labelTxtNote.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtNote.Location = new System.Drawing.Point(124, 622);
            this.labelTxtNote.Name = "labelTxtNote";
            this.labelTxtNote.Size = new System.Drawing.Size(0, 19);
            this.labelTxtNote.TabIndex = 8;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // bttnChange
            // 
            this.bttnChange.AutoSize = true;
            this.bttnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnChange.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.bttnChange.ForeColor = System.Drawing.Color.Black;
            this.bttnChange.Location = new System.Drawing.Point(16, 695);
            this.bttnChange.Name = "bttnChange";
            this.bttnChange.Size = new System.Drawing.Size(210, 17);
            this.bttnChange.TabIndex = 10;
            this.bttnChange.Text = "Изменить данные о работнике";
            this.bttnChange.Click += new System.EventHandler(this.bttnChange_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.AutoSize = true;
            this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDelete.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.bttnDelete.ForeColor = System.Drawing.Color.Black;
            this.bttnDelete.Location = new System.Drawing.Point(16, 725);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(220, 17);
            this.bttnDelete.TabIndex = 11;
            this.bttnDelete.Text = "Удалить работника учреждения";
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.AutoSize = true;
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.bttnAddPerson.ForeColor = System.Drawing.Color.Black;
            this.bttnAddPerson.Location = new System.Drawing.Point(16, 665);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(142, 17);
            this.bttnAddPerson.TabIndex = 12;
            this.bttnAddPerson.Text = "Добавить работника";
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelSearch.ForeColor = System.Drawing.Color.Black;
            this.labelSearch.Location = new System.Drawing.Point(520, 622);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(54, 19);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbSearch.Location = new System.Drawing.Point(576, 621);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 21);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbNotePos_TextChanged);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 752);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnChange);
            this.Controls.Add(this.labelTxtNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.bttnExport);
            this.Controls.Add(this.bttnImport);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dataGridViewUsr);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAdminMenu_Activated);
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridViewUsr;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button bttnImport;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelTxtNote;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label bttnChange;
        private System.Windows.Forms.Label bttnDelete;
        private System.Windows.Forms.Label bttnAddPerson;
        private System.Windows.Forms.Label labelSearch;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox bttnClose;
    }
}

