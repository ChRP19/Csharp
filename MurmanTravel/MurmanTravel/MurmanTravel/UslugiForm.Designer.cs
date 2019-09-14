namespace MurmanTravel
{
    partial class UslugiForm
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
            this.UslugiGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdatePage = new System.Windows.Forms.TabPage();
            this.StoimostBox = new System.Windows.Forms.TextBox();
            this.OpisBox = new System.Windows.Forms.TextBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.VidBox = new System.Windows.Forms.ComboBox();
            this.NPBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.VidSearchBox = new System.Windows.Forms.TextBox();
            this.NPSearchBox = new System.Windows.Forms.TextBox();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.NameSearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UslugiGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.UpdatePage.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // UslugiGridView
            // 
            this.UslugiGridView.AllowUserToAddRows = false;
            this.UslugiGridView.AllowUserToDeleteRows = false;
            this.UslugiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UslugiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UslugiGridView.Location = new System.Drawing.Point(0, 238);
            this.UslugiGridView.Name = "UslugiGridView";
            this.UslugiGridView.ReadOnly = true;
            this.UslugiGridView.Size = new System.Drawing.Size(800, 212);
            this.UslugiGridView.TabIndex = 0;
            this.UslugiGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UslugiGridView_RowHeaderMouseClick);
            this.UslugiGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UslugiGridView_RowHeaderMouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdatePage);
            this.tabControl1.Controls.Add(this.SearchPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 232);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // UpdatePage
            // 
            this.UpdatePage.Controls.Add(this.StoimostBox);
            this.UpdatePage.Controls.Add(this.OpisBox);
            this.UpdatePage.Controls.Add(this.MaxBox);
            this.UpdatePage.Controls.Add(this.VidBox);
            this.UpdatePage.Controls.Add(this.NPBox);
            this.UpdatePage.Controls.Add(this.NameBox);
            this.UpdatePage.Controls.Add(this.label6);
            this.UpdatePage.Controls.Add(this.label5);
            this.UpdatePage.Controls.Add(this.label4);
            this.UpdatePage.Controls.Add(this.label3);
            this.UpdatePage.Controls.Add(this.label2);
            this.UpdatePage.Controls.Add(this.label1);
            this.UpdatePage.Controls.Add(this.DeleteButton);
            this.UpdatePage.Controls.Add(this.UpdateButton);
            this.UpdatePage.Controls.Add(this.InsertButton);
            this.UpdatePage.Location = new System.Drawing.Point(4, 24);
            this.UpdatePage.Name = "UpdatePage";
            this.UpdatePage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePage.Size = new System.Drawing.Size(792, 204);
            this.UpdatePage.TabIndex = 0;
            this.UpdatePage.Text = "Редактирование";
            this.UpdatePage.UseVisualStyleBackColor = true;
            // 
            // StoimostBox
            // 
            this.StoimostBox.Location = new System.Drawing.Point(440, 74);
            this.StoimostBox.Name = "StoimostBox";
            this.StoimostBox.Size = new System.Drawing.Size(121, 20);
            this.StoimostBox.TabIndex = 32;
            // 
            // OpisBox
            // 
            this.OpisBox.Location = new System.Drawing.Point(440, 113);
            this.OpisBox.Multiline = true;
            this.OpisBox.Name = "OpisBox";
            this.OpisBox.Size = new System.Drawing.Size(292, 77);
            this.OpisBox.TabIndex = 31;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(440, 18);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(121, 20);
            this.MaxBox.TabIndex = 30;
            // 
            // VidBox
            // 
            this.VidBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VidBox.FormattingEnabled = true;
            this.VidBox.Location = new System.Drawing.Point(123, 120);
            this.VidBox.Name = "VidBox";
            this.VidBox.Size = new System.Drawing.Size(121, 21);
            this.VidBox.TabIndex = 29;
            // 
            // NPBox
            // 
            this.NPBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NPBox.FormattingEnabled = true;
            this.NPBox.Location = new System.Drawing.Point(123, 73);
            this.NPBox.Name = "NPBox";
            this.NPBox.Size = new System.Drawing.Size(121, 21);
            this.NPBox.TabIndex = 28;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(123, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Макс. человек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Н/П";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Вид услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Наименование";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(259, 166);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(148, 166);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 32);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(37, 166);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 32);
            this.InsertButton.TabIndex = 18;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.VidSearchBox);
            this.SearchPage.Controls.Add(this.NPSearchBox);
            this.SearchPage.Controls.Add(this.CancelSearchButton);
            this.SearchPage.Controls.Add(this.NameSearchBox);
            this.SearchPage.Controls.Add(this.label7);
            this.SearchPage.Controls.Add(this.label8);
            this.SearchPage.Controls.Add(this.label9);
            this.SearchPage.Location = new System.Drawing.Point(4, 24);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchPage.Size = new System.Drawing.Size(792, 204);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Поиск";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // VidSearchBox
            // 
            this.VidSearchBox.Location = new System.Drawing.Point(126, 123);
            this.VidSearchBox.Name = "VidSearchBox";
            this.VidSearchBox.Size = new System.Drawing.Size(121, 20);
            this.VidSearchBox.TabIndex = 38;
            this.VidSearchBox.TextChanged += new System.EventHandler(this.VidSearchBox_TextChanged);
            // 
            // NPSearchBox
            // 
            this.NPSearchBox.Location = new System.Drawing.Point(126, 77);
            this.NPSearchBox.Name = "NPSearchBox";
            this.NPSearchBox.Size = new System.Drawing.Size(121, 20);
            this.NPSearchBox.TabIndex = 37;
            this.NPSearchBox.TextChanged += new System.EventHandler(this.NPSearchBox_TextChanged);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(126, 164);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(121, 23);
            this.CancelSearchButton.TabIndex = 36;
            this.CancelSearchButton.Text = "Отменить";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // NameSearchBox
            // 
            this.NameSearchBox.Location = new System.Drawing.Point(126, 16);
            this.NameSearchBox.Name = "NameSearchBox";
            this.NameSearchBox.Size = new System.Drawing.Size(121, 20);
            this.NameSearchBox.TabIndex = 33;
            this.NameSearchBox.TextChanged += new System.EventHandler(this.NameSearchBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Н/П";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Вид услуги";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Наименование";
            // 
            // UslugiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.UslugiGridView);
            this.Name = "UslugiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Услуги";
            this.Load += new System.EventHandler(this.UslugiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UslugiGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.UpdatePage.ResumeLayout(false);
            this.UpdatePage.PerformLayout();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UslugiGridView;
        private System.Windows.Forms.ComboBox NPBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox StoimostBox;
        private System.Windows.Forms.TextBox OpisBox;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.ComboBox VidBox;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage UpdatePage;
        public System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.TextBox NameSearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.TextBox VidSearchBox;
        private System.Windows.Forms.TextBox NPSearchBox;
    }
}