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
    public partial class ClientsForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        int ID = 0;
        public int Dogovor = 0;
        string sqlClients = "SELECT id_klient, fio, spravochnik_grajdanstv.grajdanstvo, telephone, adres, nom_doc FROM klient LEFT JOIN spravochnik_grajdanstv ON klient.id_grajdanstva = spravochnik_grajdanstv.id_grajdanstva";

        public ClientsForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                //Заполнение списка гражданств
                adapter = new MySqlDataAdapter("SELECT * FROM spravochnik_grajdanstv", defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                grajdanstvoBox.DataSource = ds.Tables[0];
                grajdanstvoBox.DisplayMember = "grajdanstvo";
                grajdanstvoBox.ValueMember = "id_grajdanstva";
                grajdanstvoBox.SelectedIndex = -1;
            }
        }
        //Отображение данных в DataGridView
        private void DisplayData()
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                adapter = new MySqlDataAdapter(sqlClients, defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                clientsGridView.DataSource = ds.Tables[0];
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
            ID = 0;

            fioBoxSearch.Text = "";
            telBoxSearch.Text = "";
        }

        private void clientsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InsertButton.Enabled = false; //Блокировка кнопки Добавить, для избежания повторения записей
            ID = Convert.ToInt32(clientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            fioBox.Text = clientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            grajdanstvoBox.Text = clientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            telBox.Text = clientsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            addresBox.Text = clientsGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            dokBox.Text = clientsGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //Добавление клиента
        private void InsertButton_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(clientsGridView.Rows.Count);

            if (fioBox.Text != "" && grajdanstvoBox.Text != "" && telBox.Text != "" && addresBox.Text != "" && dokBox.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO klient(id_klient, fio, id_grajdanstva, telephone, adres, nom_doc) values(@idKlient, @fio, @idGrajdanstva, @telephone, @adres, @nom_doc)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idKlient", idClient+1);
                cmd.Parameters.AddWithValue("@fio", fioBox.Text);
                cmd.Parameters.AddWithValue("@idGrajdanstva", grajdanstvoBox.SelectedValue);
                cmd.Parameters.AddWithValue("@telephone", telBox.Text);
                cmd.Parameters.AddWithValue("@adres", addresBox.Text);
                cmd.Parameters.AddWithValue("@nom_doc", dokBox.Text);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (fioBox.Text != "" && grajdanstvoBox.Text != "" && telBox.Text != "" && addresBox.Text != "" && dokBox.Text != "")
            {
                cmd = new MySqlCommand("UPDATE klient SET fio=@fio, id_grajdanstva=@idGrajdanstva, telephone=@telephone, adres=@adres, nom_doc=@nom_doc WHERE id_klient=@idKlient", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idKlient", ID);
                cmd.Parameters.AddWithValue("@fio", fioBox.Text);
                cmd.Parameters.AddWithValue("@idGrajdanstva", grajdanstvoBox.SelectedValue);
                cmd.Parameters.AddWithValue("@telephone", telBox.Text);
                cmd.Parameters.AddWithValue("@adres", addresBox.Text);
                cmd.Parameters.AddWithValue("@nom_doc", dokBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись отредактирована!");
                defaultConnect.Close();
                DisplayData();
                ClearData();

                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new MySqlCommand("DELETE FROM klient WHERE id_klient=@idKlient", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idKlient", ID);
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
        //Отмена поиска
        private void CancelButton_Click(object sender, EventArgs e)
        {
            sqlClients = "SELECT id_klient, fio, spravochnik_grajdanstv.grajdanstvo, telephone, adres, nom_doc FROM klient LEFT JOIN spravochnik_grajdanstv ON klient.id_grajdanstva = spravochnik_grajdanstv.id_grajdanstva";
            DisplayData();
            ClearData();
        }
        //Поиск по ФИО
        private void fioBoxSearch_TextChanged(object sender, EventArgs e)
        {
            sqlClients = $"SELECT id_klient, fio, spravochnik_grajdanstv.grajdanstvo, telephone, adres, nom_doc FROM klient LEFT JOIN spravochnik_grajdanstv ON klient.id_grajdanstva = spravochnik_grajdanstv.id_grajdanstva WHERE fio LIKE '%" + fioBoxSearch.Text + "%'";
            DisplayData();
        }
        //Поиск по номеру телефона
        private void telBoxSearch_TextChanged(object sender, EventArgs e)
        {
            sqlClients = $"SELECT id_klient, fio, spravochnik_grajdanstv.grajdanstvo, telephone, adres, nom_doc FROM klient LEFT JOIN spravochnik_grajdanstv ON klient.id_grajdanstva = spravochnik_grajdanstv.id_grajdanstva WHERE telephone LIKE '%" + telBoxSearch.Text + "%'";
            DisplayData();
        }

        private void clientsGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Dogovor == 1)
            {
                ((DogovorForm)this.Tag).IDClient = Convert.ToInt32(clientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ((DogovorForm)this.Tag).fioBox.Text = clientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ((DogovorForm)this.Tag).grajdanstvoBox.Text = clientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                ((DogovorForm)this.Tag).telBox.Text = clientsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ((DogovorForm)this.Tag).addresBox.Text = clientsGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                ((DogovorForm)this.Tag).dokBox.Text = clientsGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.Close();
            }
        }
    }
}
