namespace MurmanTravel
{
    partial class RaspisanieForm
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
            if (disposing && (components != null))
            {
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
            this.RaspisanieGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdatePage = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NameUslugaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RaspisanieGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.UpdatePage.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RaspisanieGridView
            // 
            this.RaspisanieGridView.AllowUserToAddRows = false;
            this.RaspisanieGridView.AllowUserToDeleteRows = false;
            this.RaspisanieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaspisanieGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RaspisanieGridView.Location = new System.Drawing.Point(0, 148);
            this.RaspisanieGridView.Name = "RaspisanieGridView";
            this.RaspisanieGridView.ReadOnly = true;
            this.RaspisanieGridView.Size = new System.Drawing.Size(673, 220);
            this.RaspisanieGridView.TabIndex = 0;
            this.RaspisanieGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RaspisanieGridView_RowHeaderMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdatePage);
            this.tabControl1.Controls.Add(this.SearchPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 146);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // UpdatePage
            // 
            this.UpdatePage.Controls.Add(this.dateTimePicker);
            this.UpdatePage.Controls.Add(this.NameUslugaBox);
            this.UpdatePage.Controls.Add(this.label2);
            this.UpdatePage.Controls.Add(this.label1);
            this.UpdatePage.Controls.Add(this.DeleteButton);
            this.UpdatePage.Controls.Add(this.UpdateButton);
            this.UpdatePage.Controls.Add(this.InsertButton);
            this.UpdatePage.Location = new System.Drawing.Point(4, 22);
            this.UpdatePage.Name = "UpdatePage";
            this.UpdatePage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePage.Size = new System.Drawing.Size(665, 120);
            this.UpdatePage.TabIndex = 0;
            this.UpdatePage.Text = "Редактирование";
            this.UpdatePage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy HH:m";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(117, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // NameUslugaBox
            // 
            this.NameUslugaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameUslugaBox.FormattingEnabled = true;
            this.NameUslugaBox.Location = new System.Drawing.Point(117, 21);
            this.NameUslugaBox.Name = "NameUslugaBox";
            this.NameUslugaBox.Size = new System.Drawing.Size(160, 21);
            this.NameUslugaBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата проведения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Вид услуги:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(523, 51);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(412, 51);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 32);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(301, 51);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 32);
            this.InsertButton.TabIndex = 21;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.dateTimePicker2);
            this.SearchPage.Controls.Add(this.dateTimePicker1);
            this.SearchPage.Controls.Add(this.CancelSearchButton);
            this.SearchPage.Controls.Add(this.label5);
            this.SearchPage.Controls.Add(this.label4);
            this.SearchPage.Controls.Add(this.label3);
            this.SearchPage.Location = new System.Drawing.Point(4, 22);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchPage.Size = new System.Drawing.Size(665, 120);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Отбор";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:m";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(220, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 39;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:m";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(117, 91);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(121, 23);
            this.CancelSearchButton.TabIndex = 37;
            this.CancelSearchButton.Text = "Отменить";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "С";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Дата проведения:";
            // 
            // RaspisanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RaspisanieGridView);
            this.Name = "RaspisanieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Расписание";
            this.Load += new System.EventHandler(this.RaspisanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaspisanieGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.UpdatePage.ResumeLayout(false);
            this.UpdatePage.PerformLayout();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RaspisanieGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ComboBox NameUslugaBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TabPage UpdatePage;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}