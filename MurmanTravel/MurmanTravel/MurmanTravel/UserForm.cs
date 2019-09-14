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
    public partial class UserForm : Form
    {
        DataTransfer dataTransfer;

        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string login = "";

        public UserForm(DataTransfer _dataTransfer)
        {
            InitializeComponent();
            dataTransfer = _dataTransfer;
            DisplayData();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                //Заполнение списка ролей
                adapter = new MySqlDataAdapter("SELECT * FROM spravochnik_roley", defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                rolBox.DataSource = ds.Tables[0];
                rolBox.DisplayMember = "rol";
                rolBox.ValueMember = "id_roli";
                rolBox.SelectedIndex = -1;
            }
        }
        //Отображение данных в DataGridView
        private void DisplayData()
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                adapter = new MySqlDataAdapter(dataTransfer.SqlManagers[0].ToString(), defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                userGridView.DataSource = ds.Tables[0];
            }
        }
        //Очистка полей от данных
        private void ClearData()
        {
            loginBox.Text = "";
            passBox.Text = "";
            rolBox.Text = "";
            login = "";
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "" && passBox.Text != "" && rolBox.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO avtoriz(login, password, id_roil) values(@login, @password, @id_roil)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@login", loginBox.Text);
                cmd.Parameters.AddWithValue("@password", passBox.Text);
                cmd.Parameters.AddWithValue("@id_roil", rolBox.SelectedValue);
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

        private void userGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loginBox.Enabled = false; //Запрет редактирования логина, так как это Primary Key
            InsertButton.Enabled = false; //Блокировка кнопки Добавить, для избежания повторения записей
            login = userGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            loginBox.Text = userGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            passBox.Text = userGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            rolBox.Text = userGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "" && passBox.Text != "" && rolBox.Text != "")
            {
                cmd = new MySqlCommand("UPDATE avtoriz SET login=@login, password=@password, id_roil=@id_roil WHERE login=@login", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@login", loginBox.Text);
                cmd.Parameters.AddWithValue("@password", passBox.Text);
                cmd.Parameters.AddWithValue("@id_roil", rolBox.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись отредактирована!");
                defaultConnect.Close();
                DisplayData();
                ClearData();
                
                loginBox.Enabled = true;
                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (login != "")
            {
                cmd = new MySqlCommand("DELETE FROM avtoriz WHERE login=@login", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@login", login);
                cmd.ExecuteNonQuery();
                defaultConnect.Close();
                MessageBox.Show("Запись удалена!");
                DisplayData();
                ClearData();

                loginBox.Enabled = true;
                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }
    }
}
