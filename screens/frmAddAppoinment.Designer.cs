
namespace MedIS.screens
{
    partial class frmAddAppoinment
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
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAccept = new System.Windows.Forms.Button();
            this.labelDispancer = new System.Windows.Forms.Label();
            this.labeAmbul = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbAmbul = new System.Windows.Forms.ComboBox();
            this.cbDispancer = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            this.bttnCancel.Location = new System.Drawing.Point(214, 167);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(182, 30);
            this.bttnCancel.TabIndex = 54;
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
            this.bttnAccept.Location = new System.Drawing.Point(17, 167);
            this.bttnAccept.Name = "bttnAccept";
            this.bttnAccept.Size = new System.Drawing.Size(182, 30);
            this.bttnAccept.TabIndex = 53;
            this.bttnAccept.Text = "Подтвердить";
            this.bttnAccept.UseVisualStyleBackColor = false;
            this.bttnAccept.Click += new System.EventHandler(this.bttnAccept_Click);
            // 
            // labelDispancer
            // 
            this.labelDispancer.AutoSize = true;
            this.labelDispancer.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDispancer.ForeColor = System.Drawing.Color.Black;
            this.labelDispancer.Location = new System.Drawing.Point(13, 130);
            this.labelDispancer.Name = "labelDispancer";
            this.labelDispancer.Size = new System.Drawing.Size(91, 19);
            this.labelDispancer.TabIndex = 46;
            this.labelDispancer.Text = "Диспансер";
            // 
            // labeAmbul
            // 
            this.labeAmbul.AutoSize = true;
            this.labeAmbul.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labeAmbul.ForeColor = System.Drawing.Color.Black;
            this.labeAmbul.Location = new System.Drawing.Point(13, 100);
            this.labeAmbul.Name = "labeAmbul";
            this.labeAmbul.Size = new System.Drawing.Size(182, 19);
            this.labeAmbul.TabIndex = 45;
            this.labeAmbul.Text = "Амбулаторное лечение";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(13, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(135, 19);
            this.labelDate.TabIndex = 43;
            this.labelDate.Text = "Дата обращения";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(91, 1);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(230, 23);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Добавить запись к врачу";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(412, 25);
            this.panelTop.TabIndex = 56;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.labelDoctor.ForeColor = System.Drawing.Color.Black;
            this.labelDoctor.Location = new System.Drawing.Point(12, 38);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(46, 19);
            this.labelDoctor.TabIndex = 42;
            this.labelDoctor.Text = "Врач";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(205, 37);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(191, 21);
            this.cbDoctor.TabIndex = 57;
            // 
            // cbAmbul
            // 
            this.cbAmbul.FormattingEnabled = true;
            this.cbAmbul.Items.AddRange(new object[] {
            "Было",
            "Не было"});
            this.cbAmbul.Location = new System.Drawing.Point(205, 99);
            this.cbAmbul.Name = "cbAmbul";
            this.cbAmbul.Size = new System.Drawing.Size(191, 21);
            this.cbAmbul.TabIndex = 58;
            // 
            // cbDispancer
            // 
            this.cbDispancer.FormattingEnabled = true;
            this.cbDispancer.Items.AddRange(new object[] {
            "Было",
            "Не было"});
            this.cbDispancer.Location = new System.Drawing.Point(205, 129);
            this.cbDispancer.Name = "cbDispancer";
            this.cbDispancer.Size = new System.Drawing.Size(191, 21);
            this.cbDispancer.TabIndex = 59;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Salmon;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Salmon;
            this.dateTimePicker.Location = new System.Drawing.Point(205, 68);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker.TabIndex = 61;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:20",
            "9:35",
            "9:50",
            "10:05",
            "10:20",
            "10:35",
            "10:50",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:35",
            "15:50",
            "16:05",
            "16:30",
            "16:45",
            "17:00"});
            this.cbTime.Location = new System.Drawing.Point(327, 68);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(69, 21);
            this.cbTime.TabIndex = 62;
            // 
            // frmAddAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 209);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbDispancer);
            this.Controls.Add(this.cbAmbul);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAccept);
            this.Controls.Add(this.labelDispancer);
            this.Controls.Add(this.labeAmbul);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDoctor);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAppoinment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAppoinment";
            this.Load += new System.EventHandler(this.frmAddAppoinment_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAccept;
        private System.Windows.Forms.Label labelDispancer;
        private System.Windows.Forms.Label labeAmbul;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbAmbul;
        private System.Windows.Forms.ComboBox cbDispancer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbTime;
    }
}