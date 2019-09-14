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
    public partial class UslugiForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter, adapter2;
        string sqlUslugi = "SELECT id_yslugi, namimenovanie, spravochik_naselennix_punktov.nas_punkt, spravochnik_vida_yslug.vid_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis FROM yslugi LEFT JOIN spravochik_naselennix_punktov ON yslugi.id_nas_punkta=spravochik_naselennix_punktov.id_nas_punktov LEFT JOIN spravochnik_vida_yslug ON yslugi.id_vida_yslugi=spravochnik_vida_yslug.id_vida_yslugi";
        int ID = 0;
        public int Dogovor = 0;

        public UslugiForm()
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
                adapter = new MySqlDataAdapter(sqlUslugi, defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UslugiGridView.DataSource = ds.Tables[0];
            }
        }
        //Очистка полей от данных
        private void ClearData()
        {
            NameBox.Text = "";
            NPBox.Text = "";
            VidBox.Text = "";
            MaxBox.Text = "";
            StoimostBox.Text = "";
            OpisBox.Text = "";
            ID = 0;

            NameSearchBox.Text = "";
            NPSearchBox.Text = "";
            VidSearchBox.Text = "";
        }

        private void UslugiGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InsertButton.Enabled = false; //Блокировка кнопки Добавить, для избежания повторения записей
            ID = Convert.ToInt32(UslugiGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            NameBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            NPBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            VidBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            MaxBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            StoimostBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            OpisBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int idUsl = Convert.ToInt32(UslugiGridView.Rows.Count);

            if (NameBox.Text != "" && NPBox.Text != "" && VidBox.Text != "" && MaxBox.Text != "" && StoimostBox.Text != "" && OpisBox.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO yslugi(id_yslugi, namimenovanie, id_nas_punkta, id_vida_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis) values(@idYslugi, @namimenovanie, @id_nas_punkta, @id_vida_yslugi, @max_chel_v_gruppe, @stoimost, @kratkoe_opis)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idYslugi", idUsl + 1);
                cmd.Parameters.AddWithValue("@namimenovanie", NameBox.Text);
                cmd.Parameters.AddWithValue("@id_nas_punkta", NPBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_vida_yslugi", VidBox.SelectedValue);
                cmd.Parameters.AddWithValue("@max_chel_v_gruppe", MaxBox.Text);
                cmd.Parameters.AddWithValue("@stoimost", StoimostBox.Text);
                cmd.Parameters.AddWithValue("@kratkoe_opis", OpisBox.Text);
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
            if (NameBox.Text != "" && NPBox.Text != "" && VidBox.Text != "" && MaxBox.Text != "" && StoimostBox.Text != "" && OpisBox.Text != "")
            {
                cmd = new MySqlCommand("UPDATE yslugi SET namimenovanie=@namimenovanie, id_nas_punkta=@id_nas_punkta, id_vida_yslugi=@id_vida_yslugi, max_chel_v_gruppe=@max_chel_v_gruppe, stoimost=@stoimost, kratkoe_opis=@kratkoe_opis WHERE id_yslugi=@idYslugi", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idYslugi", ID);
                cmd.Parameters.AddWithValue("@namimenovanie", NameBox.Text);
                cmd.Parameters.AddWithValue("@id_nas_punkta", NPBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_vida_yslugi", VidBox.SelectedValue);
                cmd.Parameters.AddWithValue("@max_chel_v_gruppe", MaxBox.Text);
                cmd.Parameters.AddWithValue("@stoimost", StoimostBox.Text);
                cmd.Parameters.AddWithValue("@kratkoe_opis", OpisBox.Text);
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
                cmd = new MySqlCommand("DELETE FROM yslugi WHERE id_yslugi=@idYslugi", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idYslugi", ID);
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


        private void NameSearchBox_TextChanged(object sender, EventArgs e)
        {
            sqlUslugi = $"SELECT id_yslugi, namimenovanie, spravochik_naselennix_punktov.nas_punkt, spravochnik_vida_yslug.vid_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis FROM yslugi LEFT JOIN spravochik_naselennix_punktov ON yslugi.id_nas_punkta=spravochik_naselennix_punktov.id_nas_punktov LEFT JOIN spravochnik_vida_yslug ON yslugi.id_vida_yslugi=spravochnik_vida_yslug.id_vida_yslugi WHERE namimenovanie LIKE '%" + NameSearchBox.Text + "%'";
            DisplayData();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            sqlUslugi = "SELECT id_yslugi, namimenovanie, spravochik_naselennix_punktov.nas_punkt, spravochnik_vida_yslug.vid_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis FROM yslugi LEFT JOIN spravochik_naselennix_punktov ON yslugi.id_nas_punkta=spravochik_naselennix_punktov.id_nas_punktov LEFT JOIN spravochnik_vida_yslug ON yslugi.id_vida_yslugi=spravochnik_vida_yslug.id_vida_yslugi";
            DisplayData();
            ClearData();
        }

        private void NPSearchBox_TextChanged(object sender, EventArgs e)
        {
            sqlUslugi = $"SELECT id_yslugi, namimenovanie, spravochik_naselennix_punktov.nas_punkt, spravochnik_vida_yslug.vid_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis FROM yslugi LEFT JOIN spravochik_naselennix_punktov ON yslugi.id_nas_punkta=spravochik_naselennix_punktov.id_nas_punktov LEFT JOIN spravochnik_vida_yslug ON yslugi.id_vida_yslugi=spravochnik_vida_yslug.id_vida_yslugi WHERE spravochik_naselennix_punktov.nas_punkt LIKE '%" + NPSearchBox.Text + "%'";
            DisplayData();
        }

        private void VidSearchBox_TextChanged(object sender, EventArgs e)
        {
            sqlUslugi = $"SELECT id_yslugi, namimenovanie, spravochik_naselennix_punktov.nas_punkt, spravochnik_vida_yslug.vid_yslugi, max_chel_v_gruppe, stoimost, kratkoe_opis FROM yslugi LEFT JOIN spravochik_naselennix_punktov ON yslugi.id_nas_punkta=spravochik_naselennix_punktov.id_nas_punktov LEFT JOIN spravochnik_vida_yslug ON yslugi.id_vida_yslugi=spravochnik_vida_yslug.id_vida_yslugi WHERE spravochnik_vida_yslug.vid_yslugi LIKE '%" + VidSearchBox.Text + "%'";
            DisplayData();
        }

        private void UslugiGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Dogovor == 1)
            {
                ((DogovorForm)this.Tag).IDTur = Convert.ToInt32(UslugiGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ((DogovorForm)this.Tag).NameBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ((DogovorForm)this.Tag).NPBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                ((DogovorForm)this.Tag).VidBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ((DogovorForm)this.Tag).MaxBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                ((DogovorForm)this.Tag).StoimostBox.Text = UslugiGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.Close();
            }
        }

        private void UslugiForm_Load(object sender, EventArgs e)
        {
            using (defaultConnect)
            {
                defaultConnect.Open();
                //Заполнение списка НП
                adapter = new MySqlDataAdapter("SELECT * FROM spravochik_naselennix_punktov", defaultConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                NPBox.DataSource = ds.Tables[0];
                NPBox.DisplayMember = "nas_punkt";
                NPBox.ValueMember = "id_nas_punktov";
                NPBox.SelectedIndex = -1;
                //Заполнение списка вида услуг
                adapter2 = new MySqlDataAdapter("SELECT * FROM spravochnik_vida_yslug", defaultConnect);
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                VidBox.DataSource = ds2.Tables[0];
                VidBox.DisplayMember = "vid_yslugi";
                VidBox.ValueMember = "id_vida_yslugi";
                VidBox.SelectedIndex = -1;
            }
        }
    }
}
