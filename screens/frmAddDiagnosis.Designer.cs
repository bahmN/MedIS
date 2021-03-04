
namespace MedIS.screens
{
    partial class frmAddDiagnosis
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
            this.labelNote = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAccept = new System.Windows.Forms.Button();
            this.cbResult = new System.Windows.Forms.ComboBox();
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
            this.panelTop.Size = new System.Drawing.Size(410, 25);
            this.panelTop.TabIndex = 57;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(91, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(171, 23);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Добавить диагноз";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelNote.ForeColor = System.Drawing.Color.Black;
            this.labelNote.Location = new System.Drawing.Point(12, 94);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(102, 19);
            this.labelNote.TabIndex = 63;
            this.labelNote.Text = "Примечание";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelResult.ForeColor = System.Drawing.Color.Black;
            this.labelResult.Location = new System.Drawing.Point(12, 66);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(83, 19);
            this.labelResult.TabIndex = 62;
            this.labelResult.Text = "Результат";
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.labelDiagnosis.Location = new System.Drawing.Point(12, 38);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(72, 19);
            this.labelDiagnosis.TabIndex = 61;
            this.labelDiagnosis.Text = "Диагноз";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbNote.Location = new System.Drawing.Point(204, 94);
            this.tbNote.Margin = new System.Windows.Forms.Padding(2);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(191, 21);
            this.tbNote.TabIndex = 66;
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.tbDiagnosis.Location = new System.Drawing.Point(204, 38);
            this.tbDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(191, 21);
            this.tbDiagnosis.TabIndex = 67;
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
            this.bttnCancel.Location = new System.Drawing.Point(213, 128);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(182, 30);
            this.bttnCancel.TabIndex = 70;
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
            this.bttnAccept.Location = new System.Drawing.Point(16, 128);
            this.bttnAccept.Name = "bttnAccept";
            this.bttnAccept.Size = new System.Drawing.Size(182, 30);
            this.bttnAccept.TabIndex = 69;
            this.bttnAccept.Text = "Подтвердить";
            this.bttnAccept.UseVisualStyleBackColor = false;
            this.bttnAccept.Click += new System.EventHandler(this.bttnAccept_Click);
            // 
            // cbResult
            // 
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "Положительный",
            "Отрицательный"});
            this.cbResult.Location = new System.Drawing.Point(204, 65);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(191, 21);
            this.cbResult.TabIndex = 71;
            // 
            // frmAddDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 174);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAccept);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDiagnosis);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddDiagnosis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddDiagnosis";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelDiagnosis;
        public System.Windows.Forms.TextBox tbNote;
        public System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAccept;
        private System.Windows.Forms.ComboBox cbResult;
    }
}