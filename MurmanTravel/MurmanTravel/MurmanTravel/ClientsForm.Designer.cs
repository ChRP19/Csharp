namespace MurmanTravel
{
    partial class ClientsForm
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
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grajdanstvoBox = new System.Windows.Forms.ComboBox();
            this.addresBox = new System.Windows.Forms.TextBox();
            this.dokBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdatePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telBoxSearch = new System.Windows.Forms.TextBox();
            this.fioBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.UpdatePage.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientsGridView.Location = new System.Drawing.Point(0, 168);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.Size = new System.Drawing.Size(755, 176);
            this.clientsGridView.TabIndex = 0;
            this.clientsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientsGridView_RowHeaderMouseClick);
            this.clientsGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientsGridView_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Гражданство";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "№ документа";
            // 
            // grajdanstvoBox
            // 
            this.grajdanstvoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grajdanstvoBox.FormattingEnabled = true;
            this.grajdanstvoBox.Location = new System.Drawing.Point(106, 53);
            this.grajdanstvoBox.Name = "grajdanstvoBox";
            this.grajdanstvoBox.Size = new System.Drawing.Size(121, 21);
            this.grajdanstvoBox.TabIndex = 6;
            // 
            // addresBox
            // 
            this.addresBox.Location = new System.Drawing.Point(442, 16);
            this.addresBox.Name = "addresBox";
            this.addresBox.Size = new System.Drawing.Size(121, 20);
            this.addresBox.TabIndex = 9;
            // 
            // dokBox
            // 
            this.dokBox.Location = new System.Drawing.Point(442, 58);
            this.dokBox.Name = "dokBox";
            this.dokBox.Size = new System.Drawing.Size(121, 20);
            this.dokBox.TabIndex = 10;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(540, 96);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(429, 96);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 32);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(318, 96);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 32);
            this.InsertButton.TabIndex = 15;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdatePage);
            this.tabControl1.Controls.Add(this.SearchPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 162);
            this.tabControl1.TabIndex = 18;
            // 
            // UpdatePage
            // 
            this.UpdatePage.Controls.Add(this.DeleteButton);
            this.UpdatePage.Controls.Add(this.grajdanstvoBox);
            this.UpdatePage.Controls.Add(this.UpdateButton);
            this.UpdatePage.Controls.Add(this.label1);
            this.UpdatePage.Controls.Add(this.InsertButton);
            this.UpdatePage.Controls.Add(this.label2);
            this.UpdatePage.Controls.Add(this.dokBox);
            this.UpdatePage.Controls.Add(this.label3);
            this.UpdatePage.Controls.Add(this.addresBox);
            this.UpdatePage.Controls.Add(this.label4);
            this.UpdatePage.Controls.Add(this.telBox);
            this.UpdatePage.Controls.Add(this.label5);
            this.UpdatePage.Controls.Add(this.fioBox);
            this.UpdatePage.Location = new System.Drawing.Point(4, 22);
            this.UpdatePage.Name = "UpdatePage";
            this.UpdatePage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePage.Size = new System.Drawing.Size(747, 136);
            this.UpdatePage.TabIndex = 0;
            this.UpdatePage.Text = "Редактирование";
            this.UpdatePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(106, 93);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(121, 20);
            this.telBox.TabIndex = 8;
            // 
            // fioBox
            // 
            this.fioBox.Location = new System.Drawing.Point(106, 16);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(121, 20);
            this.fioBox.TabIndex = 7;
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.CancelSearchButton);
            this.SearchPage.Controls.Add(this.label6);
            this.SearchPage.Controls.Add(this.label7);
            this.SearchPage.Controls.Add(this.telBoxSearch);
            this.SearchPage.Controls.Add(this.fioBoxSearch);
            this.SearchPage.Location = new System.Drawing.Point(4, 22);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchPage.Size = new System.Drawing.Size(747, 136);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Поиск";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(114, 107);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(121, 23);
            this.CancelSearchButton.TabIndex = 15;
            this.CancelSearchButton.Text = "Отменить";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ФИО";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Телефон";
            // 
            // telBoxSearch
            // 
            this.telBoxSearch.Location = new System.Drawing.Point(114, 64);
            this.telBoxSearch.Name = "telBoxSearch";
            this.telBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.telBoxSearch.TabIndex = 12;
            this.telBoxSearch.TextChanged += new System.EventHandler(this.telBoxSearch_TextChanged);
            // 
            // fioBoxSearch
            // 
            this.fioBoxSearch.Location = new System.Drawing.Point(114, 20);
            this.fioBoxSearch.Name = "fioBoxSearch";
            this.fioBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.fioBoxSearch.TabIndex = 11;
            this.fioBoxSearch.TextChanged += new System.EventHandler(this.fioBoxSearch_TextChanged);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 344);
            this.Controls.Add(this.clientsGridView);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.UpdatePage.ResumeLayout(false);
            this.UpdatePage.PerformLayout();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grajdanstvoBox;
        private System.Windows.Forms.TextBox addresBox;
        private System.Windows.Forms.TextBox dokBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UpdatePage;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telBoxSearch;
        private System.Windows.Forms.TextBox fioBoxSearch;
        private System.Windows.Forms.Button CancelSearchButton;
    }
}