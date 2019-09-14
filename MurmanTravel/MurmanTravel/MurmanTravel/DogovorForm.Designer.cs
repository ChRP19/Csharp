namespace MurmanTravel
{
    partial class DogovorForm
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
            this.dogovorGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.grajdanstvoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dokBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addresBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchTurButton = new System.Windows.Forms.Button();
            this.InsertTurButton = new System.Windows.Forms.Button();
            this.VidBox = new System.Windows.Forms.TextBox();
            this.NPBox = new System.Windows.Forms.TextBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StoimostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManagerButtonM = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fioManagerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.procBox = new System.Windows.Forms.TextBox();
            this.telManagerBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dogovorGridView
            // 
            this.dogovorGridView.AllowUserToAddRows = false;
            this.dogovorGridView.AllowUserToDeleteRows = false;
            this.dogovorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogovorGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dogovorGridView.Location = new System.Drawing.Point(0, 459);
            this.dogovorGridView.Name = "dogovorGridView";
            this.dogovorGridView.Size = new System.Drawing.Size(603, 158);
            this.dogovorGridView.TabIndex = 0;
            this.dogovorGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dogovorGridView_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата заключения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientsButton);
            this.groupBox1.Controls.Add(this.grajdanstvoBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dokBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addresBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.telBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.fioBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Клиент ";
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(374, 86);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(121, 32);
            this.ClientsButton.TabIndex = 22;
            this.ClientsButton.Text = "Добавить";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // grajdanstvoBox
            // 
            this.grajdanstvoBox.Location = new System.Drawing.Point(101, 57);
            this.grajdanstvoBox.Name = "grajdanstvoBox";
            this.grajdanstvoBox.ReadOnly = true;
            this.grajdanstvoBox.Size = new System.Drawing.Size(121, 20);
            this.grajdanstvoBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Гражданство";
            // 
            // dokBox
            // 
            this.dokBox.Location = new System.Drawing.Point(374, 53);
            this.dokBox.Name = "dokBox";
            this.dokBox.ReadOnly = true;
            this.dokBox.Size = new System.Drawing.Size(121, 20);
            this.dokBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Телефон";
            // 
            // addresBox
            // 
            this.addresBox.Location = new System.Drawing.Point(374, 27);
            this.addresBox.Name = "addresBox";
            this.addresBox.ReadOnly = true;
            this.addresBox.Size = new System.Drawing.Size(121, 20);
            this.addresBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Адрес";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(101, 83);
            this.telBox.Name = "telBox";
            this.telBox.ReadOnly = true;
            this.telBox.Size = new System.Drawing.Size(121, 20);
            this.telBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "№ документа";
            // 
            // fioBox
            // 
            this.fioBox.Location = new System.Drawing.Point(101, 31);
            this.fioBox.Name = "fioBox";
            this.fioBox.ReadOnly = true;
            this.fioBox.Size = new System.Drawing.Size(180, 20);
            this.fioBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchTurButton);
            this.groupBox2.Controls.Add(this.InsertTurButton);
            this.groupBox2.Controls.Add(this.VidBox);
            this.groupBox2.Controls.Add(this.NPBox);
            this.groupBox2.Controls.Add(this.MaxBox);
            this.groupBox2.Controls.Add(this.NameBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 111);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Тур ";
            // 
            // SearchTurButton
            // 
            this.SearchTurButton.Location = new System.Drawing.Point(374, 62);
            this.SearchTurButton.Name = "SearchTurButton";
            this.SearchTurButton.Size = new System.Drawing.Size(121, 32);
            this.SearchTurButton.TabIndex = 44;
            this.SearchTurButton.Text = "Поиск";
            this.SearchTurButton.UseVisualStyleBackColor = true;
            this.SearchTurButton.Click += new System.EventHandler(this.SearchTurButton_Click);
            // 
            // InsertTurButton
            // 
            this.InsertTurButton.Location = new System.Drawing.Point(374, 62);
            this.InsertTurButton.Name = "InsertTurButton";
            this.InsertTurButton.Size = new System.Drawing.Size(121, 32);
            this.InsertTurButton.TabIndex = 43;
            this.InsertTurButton.Text = "Добавить";
            this.InsertTurButton.UseVisualStyleBackColor = true;
            this.InsertTurButton.Click += new System.EventHandler(this.InsertTurButton_Click);
            // 
            // VidBox
            // 
            this.VidBox.Location = new System.Drawing.Point(101, 69);
            this.VidBox.Name = "VidBox";
            this.VidBox.ReadOnly = true;
            this.VidBox.Size = new System.Drawing.Size(121, 20);
            this.VidBox.TabIndex = 42;
            // 
            // NPBox
            // 
            this.NPBox.Location = new System.Drawing.Point(101, 43);
            this.NPBox.Name = "NPBox";
            this.NPBox.ReadOnly = true;
            this.NPBox.Size = new System.Drawing.Size(121, 20);
            this.NPBox.TabIndex = 41;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(374, 17);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.ReadOnly = true;
            this.MaxBox.Size = new System.Drawing.Size(121, 20);
            this.MaxBox.TabIndex = 39;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(101, 17);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Макс. человек";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Насел. пункт";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Вид услуги";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Наименование";
            // 
            // StoimostBox
            // 
            this.StoimostBox.Location = new System.Drawing.Point(386, 375);
            this.StoimostBox.Name = "StoimostBox";
            this.StoimostBox.ReadOnly = true;
            this.StoimostBox.Size = new System.Drawing.Size(121, 20);
            this.StoimostBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Стоимость";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManagerButtonM);
            this.groupBox3.Controls.Add(this.ManagerButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.fioManagerBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.procBox);
            this.groupBox3.Controls.Add(this.telManagerBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 88);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Менеджер";
            // 
            // ManagerButtonM
            // 
            this.ManagerButtonM.Location = new System.Drawing.Point(374, 50);
            this.ManagerButtonM.Name = "ManagerButtonM";
            this.ManagerButtonM.Size = new System.Drawing.Size(121, 32);
            this.ManagerButtonM.TabIndex = 24;
            this.ManagerButtonM.Text = "Добавить";
            this.ManagerButtonM.UseVisualStyleBackColor = true;
            this.ManagerButtonM.Click += new System.EventHandler(this.ManagerButtonM_Click);
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(374, 50);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(121, 32);
            this.ManagerButton.TabIndex = 23;
            this.ManagerButton.Text = "Добавить";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "% от сделки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ФИО";
            // 
            // fioManagerBox
            // 
            this.fioManagerBox.Location = new System.Drawing.Point(101, 19);
            this.fioManagerBox.Name = "fioManagerBox";
            this.fioManagerBox.ReadOnly = true;
            this.fioManagerBox.Size = new System.Drawing.Size(180, 20);
            this.fioManagerBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Телефон";
            // 
            // procBox
            // 
            this.procBox.Location = new System.Drawing.Point(374, 19);
            this.procBox.Name = "procBox";
            this.procBox.ReadOnly = true;
            this.procBox.Size = new System.Drawing.Size(121, 20);
            this.procBox.TabIndex = 12;
            // 
            // telManagerBox
            // 
            this.telManagerBox.Location = new System.Drawing.Point(101, 45);
            this.telManagerBox.Name = "telManagerBox";
            this.telManagerBox.ReadOnly = true;
            this.telManagerBox.Size = new System.Drawing.Size(121, 20);
            this.telManagerBox.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(140, 376);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker.TabIndex = 44;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(402, 417);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 46;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(291, 417);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 32);
            this.InsertButton.TabIndex = 45;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 617);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StoimostBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dogovorGridView);
            this.Name = "DogovorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Договора";
            this.Load += new System.EventHandler(this.DogovorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogovorGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dogovorGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClientsButton;
        public System.Windows.Forms.TextBox grajdanstvoBox;
        public System.Windows.Forms.TextBox dokBox;
        public System.Windows.Forms.TextBox addresBox;
        public System.Windows.Forms.TextBox telBox;
        public System.Windows.Forms.TextBox fioBox;
        public System.Windows.Forms.TextBox VidBox;
        public System.Windows.Forms.TextBox NPBox;
        public System.Windows.Forms.TextBox MaxBox;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox StoimostBox;
        public System.Windows.Forms.Button SearchTurButton;
        public System.Windows.Forms.Button InsertTurButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox fioManagerBox;
        public System.Windows.Forms.TextBox procBox;
        public System.Windows.Forms.TextBox telManagerBox;
        public System.Windows.Forms.Button ManagerButton;
        public System.Windows.Forms.Button ManagerButtonM;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
    }
}