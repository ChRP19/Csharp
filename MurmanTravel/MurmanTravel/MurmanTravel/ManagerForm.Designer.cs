namespace MurmanTravel
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.managerGridView = new System.Windows.Forms.DataGridView();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.procBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.ComboBox();
            this.userNewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // managerGridView
            // 
            this.managerGridView.AllowUserToAddRows = false;
            this.managerGridView.AllowUserToDeleteRows = false;
            this.managerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.managerGridView.Location = new System.Drawing.Point(0, 156);
            this.managerGridView.Name = "managerGridView";
            this.managerGridView.ReadOnly = true;
            this.managerGridView.Size = new System.Drawing.Size(708, 165);
            this.managerGridView.TabIndex = 0;
            this.managerGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.managerGridView_RowHeaderMouseClick);
            this.managerGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.managerGridView_RowHeaderMouseDoubleClick);
            // 
            // fioBox
            // 
            this.fioBox.Location = new System.Drawing.Point(121, 28);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(100, 20);
            this.fioBox.TabIndex = 2;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(121, 71);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(100, 20);
            this.telBox.TabIndex = 4;
            // 
            // procBox
            // 
            this.procBox.Location = new System.Drawing.Point(121, 113);
            this.procBox.Name = "procBox";
            this.procBox.Size = new System.Drawing.Size(100, 20);
            this.procBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "% от сделки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(352, 101);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 32);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(463, 101);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 32);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(574, 101);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginBox.FormattingEnabled = true;
            this.loginBox.Location = new System.Drawing.Point(447, 27);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(121, 21);
            this.loginBox.TabIndex = 15;
            // 
            // userNewButton
            // 
            this.userNewButton.Location = new System.Drawing.Point(574, 26);
            this.userNewButton.Name = "userNewButton";
            this.userNewButton.Size = new System.Drawing.Size(23, 23);
            this.userNewButton.TabIndex = 16;
            this.userNewButton.Text = "+";
            this.userNewButton.UseVisualStyleBackColor = true;
            this.userNewButton.Click += new System.EventHandler(this.userNewButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пароль";
            // 
            // PassChangeButton
            // 
            this.PassChangeButton.Location = new System.Drawing.Point(447, 68);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(121, 23);
            this.PassChangeButton.TabIndex = 18;
            this.PassChangeButton.Text = "Изменить";
            this.PassChangeButton.UseVisualStyleBackColor = true;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "(для менеджера)";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PassChangeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userNewButton);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.fioBox);
            this.Controls.Add(this.managerGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Менеджеры";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView managerGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox procBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Button userNewButton;
        public System.Windows.Forms.Button InsertButton;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.ComboBox loginBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button PassChangeButton;
    }
}