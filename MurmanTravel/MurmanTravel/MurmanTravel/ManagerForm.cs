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
    public partial class ManagerForm : Form
    {
        //Создание переменной типа класса передачи данных (см. Program.cs)
        DataTransfer dataTransfer;
        //Создание переменной хранящей строку подключения к БД
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        MySqlConnection defaultConnect = new MySqlConnection(connectionString); //Создание подключения
        MySqlCommand cmd; //Переменная для хранения sql-запроса
        MySqlDataAdapter adapter; //Переменная для управления источниками данных
        int ID = 0; //Переменная для хранения id выбранной записи
        public int Dogovor = 0;

        //Конструктор принимает значение параметра для передачи данных через класс datatransfer
        public ManagerForm(DataTransfer _dataTransfer)
        {
            InitializeComponent();
            dataTransfer = _dataTransfer; //Передача параметра полю
            DisplayData();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Заполнение списка логинов
            adapter = new MySqlDataAdapter("SELECT login FROM avtoriz", defaultConnect);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            loginBox.DataSource = ds.Tables[0];
            loginBox.DisplayMember = "login";
            loginBox.ValueMember = "login";
            loginBox.SelectedIndex = -1;
        }

        //Добавление записи
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //Переменная хранит кол-во строк
            //для добавления id в запись
            int idMan = Convert.ToInt32(managerGridView.Rows.Count); 

            if (fioBox.Text != "" && telBox.Text != "" && procBox.Text != "" && loginBox.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO polsovatel(id_menedjer, login, fio, telephone, dolya_ot_sdelki) values(@idManager, @login, @fio, @telephone, @dolya)", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idManager", idMan+1); //Кол-во строк +1 = новый id
                cmd.Parameters.AddWithValue("@login",loginBox.Text);
                cmd.Parameters.AddWithValue("@fio", fioBox.Text);
                cmd.Parameters.AddWithValue("@telephone", telBox.Text);
                cmd.Parameters.AddWithValue("@dolya", procBox.Text);
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
        //Отображение данных в DataGridView
        private void DisplayData()
        {
            //конструкция using сама закрывает подключение
            using (defaultConnect)
            {
                //Открытие подключения
                defaultConnect.Open();
                //инициализация объекта для получения данных из БД по запросу
                //запрос находится в свойстве SqlManagers[0]
                adapter = new MySqlDataAdapter(dataTransfer.SqlManagers[0].ToString(), defaultConnect);
                DataSet ds = new DataSet(); //инициализируем объект набора данных
                adapter.Fill(ds); //заполнение набора данных
                managerGridView.DataSource = ds.Tables[0]; //Заполнение таблицы менеджеров
            }
        }
        //Очистка полей от данных
        private void ClearData()
        {
            fioBox.Text = "";
            telBox.Text = "";
            procBox.Text = "";
            loginBox.Text = "";
            ID = 0;
        }
        //Событие при котором происходит передача данных из ячеек таблицы в поля ввода
        private void managerGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InsertButton.Enabled = false; //Блокировка кнопки Добавить, для избежания повторения записей
            ID = Convert.ToInt32(managerGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            loginBox.Text = managerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            fioBox.Text = managerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            telBox.Text = managerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            procBox.Text = managerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //Редактирование записи
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (fioBox.Text != "" && telBox.Text != "" && procBox.Text != "" && loginBox.Text != "")
            {
                cmd = new MySqlCommand("UPDATE polsovatel SET login=@login, fio=@fio, telephone=@telephone, dolya_ot_sdelki=@dolya WHERE id_menedjer=@idManager", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idManager", ID);
                //передача в запрос данных из полей
                cmd.Parameters.AddWithValue("@login", loginBox.Text); 
                cmd.Parameters.AddWithValue("@fio", fioBox.Text);
                cmd.Parameters.AddWithValue("@telephone", telBox.Text);
                cmd.Parameters.AddWithValue("@dolya", procBox.Text);
                cmd.ExecuteNonQuery(); //Отправка запроса на обновление
                MessageBox.Show("Запись отредактирована!");
                defaultConnect.Close(); //Закрытие подключения
                DisplayData(); //Обновление таблицы
                ClearData(); //очистка полей ввода
                //Разблокирование кнопки Добавить
                InsertButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }
        //Удаление записи
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new MySqlCommand("DELETE FROM polsovatel WHERE id_menedjer=@idManager", defaultConnect);
                defaultConnect.Open();
                cmd.Parameters.AddWithValue("@idManager", ID);
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
        //Открытие формы Пользователи
        private void userNewButton_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { "SELECT login, password, spravochnik_roley.rol FROM avtoriz LEFT JOIN spravochnik_roley ON avtoriz.id_roil = spravochnik_roley.id_roli" };
            UserForm userForm = new UserForm(dataTransfer);
            userForm.ShowDialog();
        }
        //Открытие формы пользователи для изменения пароля (только для Менеджеров)
        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            dataTransfer.SqlManagers = new object[] { $"SELECT login, password, spravochnik_roley.rol FROM avtoriz LEFT JOIN spravochnik_roley ON avtoriz.id_roil = spravochnik_roley.id_roli WHERE login = '{dataTransfer.LoginCheck[0].ToString()}'" };
            UserForm userForm = new UserForm(dataTransfer);
            //Блокировка полей и кнопок
            userForm.loginBox.Enabled = false;
            userForm.rolBox.Enabled = false;
            userForm.InsertButton.Enabled = false;
            userForm.DeleteButton.Enabled = false;
            //Отображение формы в модальном
            userForm.ShowDialog();
        }

        private void managerGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Dogovor == 1)
            {
                ((DogovorForm)this.Tag).IDManager = Convert.ToInt32(managerGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ((DogovorForm)this.Tag).fioManagerBox.Text = managerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                ((DogovorForm)this.Tag).telManagerBox.Text = managerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ((DogovorForm)this.Tag).procBox.Text = managerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Close();
            }
        }
    }
}
