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
    public partial class RaspisanieForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string sqlRaspisanie = "SELECT id_tur, yslugi.namimenovanie, data_proved FROM raspisanie LEFT JOIN yslugi ON raspisanie.id_yslugi=yslugi.id_yslugi";
        int ID = 0;

        public RaspisanieForm()
        {
            InitializeComponent();
            DisplayData();
        }

        //Отображение данных в DataGridView
        private void DisplayData()
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                adapter = new MySqlDataAdapter(sqlRaspisanie, defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                RaspisanieGridView.DataSource = ds.Tables[0];
            }
        }
        //Очистка полей от данных
        private void ClearData()
        {
            NameUslugaBox.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            ID = 0;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void RaspisanieGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InsertButton.Enabled = false; //Блокировка кнопки Добавить, для избежания повторения записей
            ID = Convert.ToInt32(RaspisanieGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            NameUslugaBox.Text = RaspisanieGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker.Text = RaspisanieGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int idRasp = Convert.ToInt32(RaspisanieGridView.Rows.Count);

            if (NameUslugaBox.Text != "" && dateTimePicker.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO raspisanie(id_tur, id_yslugi, data_proved) values(@id_tur, @id_yslugi, @data_proved)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@id_tur", idRasp + 1);
                cmd.Parameters.AddWithValue("@id_yslugi", NameUslugaBox.SelectedValue);
                cmd.Parameters.AddWithValue("@data_proved", dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm"));
                cmd.ExecuteNonQuery();
                defaultConnect.Close();
                MessageBox.Show("Запись добавлена!");
                DisplayData();
                ClearData();

                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameUslugaBox.Text != "" && dateTimePicker.Text != "")
            {
                cmd = new MySqlCommand("UPDATE raspisanie SET id_yslugi=@id_yslugi, data_proved=@data_proved WHERE id_tur=@id_tur", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@id_tur", ID);
                cmd.Parameters.AddWithValue("@id_yslugi", NameUslugaBox.SelectedValue);
                cmd.Parameters.AddWithValue("@data_proved", dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm"));
                cmd.ExecuteNonQuery();
                defaultConnect.Close();
                MessageBox.Show("Запись добавлена!");
                DisplayData();
                ClearData();

                InsertButton.Enabled = true;
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
                cmd = new MySqlCommand("DELETE FROM raspisanie WHERE id_tur=@id_tur", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@id_tur", ID);
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

        private void RaspisanieForm_Load(object sender, EventArgs e)
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                //Заполнение списка услуг
                adapter = new MySqlDataAdapter("SELECT id_yslugi, namimenovanie FROM yslugi", defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                NameUslugaBox.DataSource = ds.Tables[0];
                NameUslugaBox.DisplayMember = "namimenovanie";
                NameUslugaBox.ValueMember = "id_yslugi";
                NameUslugaBox.SelectedIndex = -1;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sqlRaspisanie = $"SELECT id_tur, yslugi.namimenovanie, data_proved FROM raspisanie LEFT JOIN yslugi ON raspisanie.id_yslugi=yslugi.id_yslugi WHERE data_proved >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm")}' AND data_proved < '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm")}'";
            DisplayData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            sqlRaspisanie = $"SELECT id_tur, yslugi.namimenovanie, data_proved FROM raspisanie LEFT JOIN yslugi ON raspisanie.id_yslugi=yslugi.id_yslugi WHERE data_proved >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm")}' AND data_proved < '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm")}'";
            DisplayData();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            ClearData();
            sqlRaspisanie = "SELECT id_tur, yslugi.namimenovanie, data_proved FROM raspisanie LEFT JOIN yslugi ON raspisanie.id_yslugi=yslugi.id_yslugi";
            DisplayData(); 
        }
    }
}
