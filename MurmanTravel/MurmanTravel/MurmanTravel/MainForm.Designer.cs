namespace MurmanTravel
{
    partial class MainForm
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
            this.ManagerPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutButtonM = new System.Windows.Forms.Button();
            this.ManagerButtonM = new System.Windows.Forms.Button();
            this.DogovorButtonM = new System.Windows.Forms.Button();
            this.UslugiButtonM = new System.Windows.Forms.Button();
            this.RaspisanieButtonM = new System.Windows.Forms.Button();
            this.ClientsButtonM = new System.Windows.Forms.Button();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.DogovorButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.RaspisanieButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.UslugiButton = new System.Windows.Forms.Button();
            this.RolControl = new System.Windows.Forms.TabControl();
            this.ManagerPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.RolControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerPage
            // 
            this.ManagerPage.Controls.Add(this.groupBox1);
            this.ManagerPage.Location = new System.Drawing.Point(4, 29);
            this.ManagerPage.Name = "ManagerPage";
            this.ManagerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagerPage.Size = new System.Drawing.Size(511, 389);
            this.ManagerPage.TabIndex = 1;
            this.ManagerPage.Text = "Менеджер";
            this.ManagerPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutButtonM);
            this.groupBox1.Controls.Add(this.ManagerButtonM);
            this.groupBox1.Controls.Add(this.DogovorButtonM);
            this.groupBox1.Controls.Add(this.UslugiButtonM);
            this.groupBox1.Controls.Add(this.RaspisanieButtonM);
            this.groupBox1.Controls.Add(this.ClientsButtonM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 383);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // logoutButtonM
            // 
            this.logoutButtonM.Location = new System.Drawing.Point(141, 336);
            this.logoutButtonM.Name = "logoutButtonM";
            this.logoutButtonM.Size = new System.Drawing.Size(228, 41);
            this.logoutButtonM.TabIndex = 16;
            this.logoutButtonM.Text = "Сменить пользователя";
            this.logoutButtonM.UseVisualStyleBackColor = true;
            this.logoutButtonM.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ManagerButtonM
            // 
            this.ManagerButtonM.Location = new System.Drawing.Point(141, 19);
            this.ManagerButtonM.Name = "ManagerButtonM";
            this.ManagerButtonM.Size = new System.Drawing.Size(228, 41);
            this.ManagerButtonM.TabIndex = 2;
            this.ManagerButtonM.Text = "Менеджеры";
            this.ManagerButtonM.UseVisualStyleBackColor = true;
            this.ManagerButtonM.Click += new System.EventHandler(this.ManagerButtonM_Click);
            // 
            // DogovorButtonM
            // 
            this.DogovorButtonM.Location = new System.Drawing.Point(141, 207);
            this.DogovorButtonM.Name = "DogovorButtonM";
            this.DogovorButtonM.Size = new System.Drawing.Size(228, 41);
            this.DogovorButtonM.TabIndex = 6;
            this.DogovorButtonM.Text = "Договоры";
            this.DogovorButtonM.UseVisualStyleBackColor = true;
            this.DogovorButtonM.Click += new System.EventHandler(this.DogovorButtonM_Click);
            // 
            // UslugiButtonM
            // 
            this.UslugiButtonM.Location = new System.Drawing.Point(141, 113);
            this.UslugiButtonM.Name = "UslugiButtonM";
            this.UslugiButtonM.Size = new System.Drawing.Size(228, 41);
            this.UslugiButtonM.TabIndex = 3;
            this.UslugiButtonM.Text = "Услуги";
            this.UslugiButtonM.UseVisualStyleBackColor = true;
            this.UslugiButtonM.Click += new System.EventHandler(this.UslugiButtonM_Click);
            // 
            // RaspisanieButtonM
            // 
            this.RaspisanieButtonM.Location = new System.Drawing.Point(141, 160);
            this.RaspisanieButtonM.Name = "RaspisanieButtonM";
            this.RaspisanieButtonM.Size = new System.Drawing.Size(228, 41);
            this.RaspisanieButtonM.TabIndex = 5;
            this.RaspisanieButtonM.Text = "Расписание";
            this.RaspisanieButtonM.UseVisualStyleBackColor = true;
            this.RaspisanieButtonM.Click += new System.EventHandler(this.RaspisanieButtonM_Click);
            // 
            // ClientsButtonM
            // 
            this.ClientsButtonM.Location = new System.Drawing.Point(141, 66);
            this.ClientsButtonM.Name = "ClientsButtonM";
            this.ClientsButtonM.Size = new System.Drawing.Size(228, 41);
            this.ClientsButtonM.TabIndex = 4;
            this.ClientsButtonM.Text = "Клиенты";
            this.ClientsButtonM.UseVisualStyleBackColor = true;
            this.ClientsButtonM.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.groupBox3);
            this.AdminPage.Location = new System.Drawing.Point(4, 29);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPage.Size = new System.Drawing.Size(511, 389);
            this.AdminPage.TabIndex = 0;
            this.AdminPage.Text = "Администратор";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logoutButton);
            this.groupBox3.Controls.Add(this.UserButton);
            this.groupBox3.Controls.Add(this.DogovorButton);
            this.groupBox3.Controls.Add(this.ManagerButton);
            this.groupBox3.Controls.Add(this.RaspisanieButton);
            this.groupBox3.Controls.Add(this.ClientButton);
            this.groupBox3.Controls.Add(this.UslugiButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 383);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Меню";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(141, 336);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(228, 41);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Сменить пользователя";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(141, 289);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(228, 41);
            this.UserButton.TabIndex = 0;
            this.UserButton.Text = "Пользователи";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // DogovorButton
            // 
            this.DogovorButton.Location = new System.Drawing.Point(141, 207);
            this.DogovorButton.Name = "DogovorButton";
            this.DogovorButton.Size = new System.Drawing.Size(228, 41);
            this.DogovorButton.TabIndex = 9;
            this.DogovorButton.Text = "Договоры";
            this.DogovorButton.UseVisualStyleBackColor = true;
            this.DogovorButton.Click += new System.EventHandler(this.DogovorButton_Click);
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(141, 19);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(228, 41);
            this.ManagerButton.TabIndex = 1;
            this.ManagerButton.Text = "Менеджеры";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // RaspisanieButton
            // 
            this.RaspisanieButton.Location = new System.Drawing.Point(141, 160);
            this.RaspisanieButton.Name = "RaspisanieButton";
            this.RaspisanieButton.Size = new System.Drawing.Size(228, 41);
            this.RaspisanieButton.TabIndex = 8;
            this.RaspisanieButton.Text = "Расписание";
            this.RaspisanieButton.UseVisualStyleBackColor = true;
            this.RaspisanieButton.Click += new System.EventHandler(this.RaspisanieButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(141, 66);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(228, 41);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // UslugiButton
            // 
            this.UslugiButton.Location = new System.Drawing.Point(141, 113);
            this.UslugiButton.Name = "UslugiButton";
            this.UslugiButton.Size = new System.Drawing.Size(228, 41);
            this.UslugiButton.TabIndex = 7;
            this.UslugiButton.Text = "Услуги";
            this.UslugiButton.UseVisualStyleBackColor = true;
            this.UslugiButton.Click += new System.EventHandler(this.UslugiButton_Click);
            // 
            // RolControl
            // 
            this.RolControl.Controls.Add(this.AdminPage);
            this.RolControl.Controls.Add(this.ManagerPage);
            this.RolControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolControl.ItemSize = new System.Drawing.Size(90, 25);
            this.RolControl.Location = new System.Drawing.Point(0, 0);
            this.RolControl.Name = "RolControl";
            this.RolControl.SelectedIndex = 0;
            this.RolControl.Size = new System.Drawing.Size(519, 422);
            this.RolControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.RolControl.TabIndex = 1;
            this.RolControl.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 422);
            this.Controls.Add(this.RolControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МурманТревел - Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ManagerPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.AdminPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.RolControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage ManagerPage;
        private System.Windows.Forms.Button logoutButtonM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ManagerButtonM;
        private System.Windows.Forms.Button DogovorButtonM;
        private System.Windows.Forms.Button UslugiButtonM;
        private System.Windows.Forms.Button RaspisanieButtonM;
        private System.Windows.Forms.Button ClientsButtonM;
        public System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button DogovorButton;
        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button RaspisanieButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button UslugiButton;
        public System.Windows.Forms.TabControl RolControl;
    }
}