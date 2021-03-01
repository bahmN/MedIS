
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.dataGridViewUsr = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.bttnImport = new System.Windows.Forms.Button();
            this.bttnExport = new System.Windows.Forms.Button();
            this.labelNotePos = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelTxtPos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Salmon;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(766, 25);
            this.panelTop.TabIndex = 0;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsr.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUsr.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUsr.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewUsr.Name = "dataGridViewUsr";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsr.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsr.Size = new System.Drawing.Size(742, 579);
            this.dataGridViewUsr.TabIndex = 1;
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
            // bttnAddPerson
            // 
            this.bttnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.bttnAddPerson.FlatAppearance.BorderSize = 0;
            this.bttnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddPerson.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAddPerson.ForeColor = System.Drawing.Color.Black;
            this.bttnAddPerson.Location = new System.Drawing.Point(12, 665);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(179, 30);
            this.bttnAddPerson.TabIndex = 3;
            this.bttnAddPerson.Text = "Добавить работника";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
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
            this.bttnImport.Location = new System.Drawing.Point(197, 665);
            this.bttnImport.Name = "bttnImport";
            this.bttnImport.Size = new System.Drawing.Size(179, 30);
            this.bttnImport.TabIndex = 4;
            this.bttnImport.Text = "Импорт базы данных";
            this.bttnImport.UseVisualStyleBackColor = false;
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
            this.bttnExport.Location = new System.Drawing.Point(382, 666);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(179, 30);
            this.bttnExport.TabIndex = 5;
            this.bttnExport.Text = "Экспорт базы данных";
            this.bttnExport.UseVisualStyleBackColor = false;
            // 
            // labelNotePos
            // 
            this.labelNotePos.AutoSize = true;
            this.labelNotePos.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelNotePos.ForeColor = System.Drawing.Color.Black;
            this.labelNotePos.Location = new System.Drawing.Point(12, 613);
            this.labelNotePos.Name = "labelNotePos";
            this.labelNotePos.Size = new System.Drawing.Size(191, 19);
            this.labelNotePos.TabIndex = 6;
            this.labelNotePos.Text = "Примечание должности:";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelSpec.ForeColor = System.Drawing.Color.Black;
            this.labelSpec.Location = new System.Drawing.Point(12, 632);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(227, 19);
            this.labelSpec.TabIndex = 7;
            this.labelSpec.Text = "Примечание специализации:";
            // 
            // labelTxtPos
            // 
            this.labelTxtPos.AutoSize = true;
            this.labelTxtPos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelTxtPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.labelTxtPos.Location = new System.Drawing.Point(209, 613);
            this.labelTxtPos.Name = "labelTxtPos";
            this.labelTxtPos.Size = new System.Drawing.Size(27, 19);
            this.labelTxtPos.TabIndex = 8;
            this.labelTxtPos.Text = "txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(245, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "txt";
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTxtPos);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelNotePos);
            this.Controls.Add(this.bttnExport);
            this.Controls.Add(this.bttnImport);
            this.Controls.Add(this.bttnAddPerson);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridViewUsr;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.Button bttnImport;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.Label labelNotePos;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelTxtPos;
        private System.Windows.Forms.Label label1;
    }
}

