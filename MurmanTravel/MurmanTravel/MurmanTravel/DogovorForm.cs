using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MurmanTravel
{
    public partial class DogovorForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        int ID = 0;

        DataTransfer dataTransfer;

        ClientsForm clientsForm;
        UslugiForm uslugiForm;
        ManagerForm managerForm;

        public int IDClient = 0;
        public int IDTur = 0;
        public int IDManager = 0;

        public DogovorForm(DataTransfer _dataTransfer)
        {
            InitializeComponent();
            dataTransfer = _dataTransfer; //Передача параметра полю
            DisplayData();
        }

        //Отображение данных в DataGridView
        private void DisplayData()
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                adapter = new MySqlDataAdapter(dataTransfer.SqlDogovor[0].ToString(), defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dogovorGridView.DataSource = ds.Tables[0];
            }
        }
        //Очистка полей от данных
        private void ClearData()
        {
            fioBox.Text = "";
            grajdanstvoBox.Text = "";
            telBox.Text = "";
            addresBox.Text = "";
            dokBox.Text = "";
            NameBox.Text = "";
            NPBox.Text = "";
            VidBox.Text = "";
            MaxBox.Text = "";
            StoimostBox.Text = "";
            fioManagerBox.Text = "";
            telManagerBox.Text = "";
            procBox.Text = "";
            dateTimePicker.Value = DateTime.Now;

            ID = 0;
            IDClient = 0;
            IDTur = 0;
            IDManager = 0;
    }

        private void DogovorForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            clientsForm = new ClientsForm();
            clientsForm.Tag = this;
            clientsForm.Dogovor = 1;
            clientsForm.ShowDialog();
        }

        private void SearchTurButton_Click(object sender, EventArgs e)
        {
            uslugiForm = new UslugiForm();
            uslugiForm.Tag = this;
            uslugiForm.UpdatePage.Parent = null;
            uslugiForm.Dogovor = 1;
            uslugiForm.ShowDialog();
        }

        private void InsertTurButton_Click(object sender, EventArgs e)
        {
            uslugiForm = new UslugiForm();
            uslugiForm.Tag = this;
            uslugiForm.Dogovor = 1;
            uslugiForm.ShowDialog();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { "SELECT * FROM polsovatel" };
            managerForm = new ManagerForm(dataTransfer);
            managerForm.PassChangeButton.Enabled = false;
            managerForm.Tag = this;
            managerForm.Dogovor = 1;
            managerForm.ShowDialog();
        }

        private void ManagerButtonM_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { $"SELECT * FROM polsovatel WHERE login='{dataTransfer.LoginCheck[0].ToString()}'" };
            managerForm = new ManagerForm(dataTransfer);
            managerForm.userNewButton.Enabled = false;
            managerForm.InsertButton.Enabled = false;
            managerForm.DeleteButton.Enabled = false;
            managerForm.loginBox.Enabled = false;
            managerForm.Tag = this;
            managerForm.Dogovor = 1;
            managerForm.ShowDialog();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int idDogovor = Convert.ToInt32(dogovorGridView.Rows.Count);

            if (fioBox.Text != "" && NameBox.Text != "" && fioManagerBox.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO dogovora(id_dogovora, id_klient, id_tur, id_menedjer, data_zakl, smoimost) values(@id_dogovora, @id_klient, @id_tur, @id_menedjer, @data_zakl, @smoimost)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@id_dogovora", idDogovor + 1);
                cmd.Parameters.AddWithValue("@id_klient", IDClient);
                cmd.Parameters.AddWithValue("@id_tur", IDTur);
                cmd.Parameters.AddWithValue("@id_menedjer", IDManager);
                cmd.Parameters.AddWithValue("@data_zakl", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@smoimost", StoimostBox.Text);
                cmd.ExecuteNonQuery();
                defaultConnect.Close();
                MessageBox.Show("Запись добавлена!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new MySqlCommand("DELETE FROM dogovora WHERE id_dogovora=@id_dogovora", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@id_dogovora", ID);
                cmd.ExecuteNonQuery();
                defaultConnect.Close();
                MessageBox.Show("Запись удалена!");
                DisplayData();
                ClearData();

                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        private void dogovorGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dogovorGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
