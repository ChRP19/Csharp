using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurmanTravel
{
    public partial class MainForm : Form
    {
        DataTransfer dataTransfer;

        public MainForm(DataTransfer _dataTransfer)
        {
            InitializeComponent();
            dataTransfer = _dataTransfer;
        }

        private void ManagerButtonM_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { $"SELECT * FROM polsovatel WHERE login='{dataTransfer.LoginCheck[0].ToString()}'" };
            ManagerForm managerForm = new ManagerForm(dataTransfer);
            managerForm.userNewButton.Enabled = false;
            managerForm.InsertButton.Enabled = false;
            managerForm.DeleteButton.Enabled = false;
            managerForm.loginBox.Enabled = false;
            managerForm.ShowDialog();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            dataTransfer = new DataTransfer { SqlManagers = new object[] { "SELECT * FROM polsovatel" } };
            ManagerForm managerForm = new ManagerForm(dataTransfer);
            managerForm.PassChangeButton.Enabled = false;
            managerForm.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { "SELECT login, password, spravochnik_roley.rol FROM avtoriz LEFT JOIN spravochnik_roley ON avtoriz.id_roil = spravochnik_roley.id_roli" };
            UserForm userForm = new UserForm(dataTransfer);
            userForm.ShowDialog();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void UslugiButton_Click(object sender, EventArgs e)
        {
            UslugiForm uslugiForm = new UslugiForm();
            uslugiForm.ShowDialog();
        }

        private void RaspisanieButton_Click(object sender, EventArgs e)
        {
            RaspisanieForm raspisanieForm = new RaspisanieForm();
            raspisanieForm.ShowDialog();
        }

        private void DogovorButton_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlDogovor = new object[] { "SELECT id_dogovora, klient.fio, yslugi.namimenovanie, polsovatel.login, data_zakl, stoimost FROM dogovora LEFT JOIN klient ON dogovora.id_klient=klient.id_klient LEFT JOIN yslugi ON dogovora.id_tur=yslugi.id_yslugi LEFT JOIN polsovatel ON dogovora.id_menedjer=polsovatel.id_menedjer" };

            DogovorForm dogovorForm = new DogovorForm(dataTransfer);
            dogovorForm.SearchTurButton.Hide();
            dogovorForm.ManagerButtonM.Hide();
            dogovorForm.ShowDialog();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вернуться к авторизации?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void UslugiButtonM_Click(object sender, EventArgs e)
        {
            UslugiForm uslugiForm = new UslugiForm();
            uslugiForm.UpdatePage.Parent = null;
            uslugiForm.ShowDialog();

        }

        private void RaspisanieButtonM_Click(object sender, EventArgs e)
        {
            RaspisanieForm raspisanieForm = new RaspisanieForm();
            raspisanieForm.UpdatePage.Parent = null;
            raspisanieForm.ShowDialog();
        }

        private void DogovorButtonM_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlDogovor = new object[] { $"SELECT id_dogovora, klient.fio, yslugi.namimenovanie, polsovatel.login, data_zakl, stoimost FROM dogovora LEFT JOIN klient ON dogovora.id_klient=klient.id_klient LEFT JOIN yslugi ON dogovora.id_tur=yslugi.id_yslugi LEFT JOIN polsovatel ON dogovora.id_menedjer=polsovatel.id_menedjer WHERE polsovatel.login='{dataTransfer.LoginCheck[0].ToString()}'" };
            DogovorForm dogovorForm = new DogovorForm(dataTransfer);
            dogovorForm.InsertTurButton.Hide();
            dogovorForm.ManagerButton.Hide();
            dogovorForm.ShowDialog();
        }
    }
}
