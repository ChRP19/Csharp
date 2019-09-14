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
    public partial class AuthForm : Form
    {
        public string LoginCheck { get; set; }
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            RolBox.SelectedIndex = 0; //Установка роли по умолчанию (0 - менеджер, 1 - администратор)
        }

        private void Login_Click(object sender, EventArgs e)
        {

            DataTransfer dataTransfer = new DataTransfer { LoginCheck = new object[] { LoginBox.Text } };
            LoginCheck = dataTransfer.LoginCheck[0].ToString();
            string passCheck = PassBox.Text;
            string rolCheck = RolBox.Text;

            //Переменная принимает значение строки подключения к бд из конфигурационного файла "App.config" 
            //который находится в директории программы
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //Переменная принимает запрос, проверяющий соответствие логина и пароля в бд
            string checkAuthCmd = $"SELECT * FROM avtoriz, spravochnik_roley WHERE avtoriz.login='{LoginCheck}' and avtoriz.password='{passCheck}' and avtoriz.id_roil=spravochnik_roley.id_roli and spravochnik_roley.rol='{rolCheck}'";

            //Создание подключения и построение SQL-запроса возвращающего данные в табличном виде
            MySqlConnection defaultConnect = new MySqlConnection(connectionString);
            MySqlCommand checkAuth = new MySqlCommand(checkAuthCmd, defaultConnect);
         
            defaultConnect.Open(); //Открытие подключения
            checkAuth.Prepare(); //Подготовка запроса
            checkAuth.ExecuteNonQuery(); //Выполнение запроса и возврат кол-ва подходящих строк

            //Проверка роли пользователя
            //и открытие соответствующей формы
            switch (rolCheck)
            {
                case "Администратор":
                    if (LoginCheck == (string)checkAuth.ExecuteScalar())
                    {
                        MessageBox.Show("Вы авторизировались с правами Администратора!");
                        defaultConnect.Close();
                        MainForm mainForm = new MainForm(dataTransfer); //создание объекта главной формы, для взаимодействия с ней
                        mainForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); }; //Событие происходящее при закрытии Главной формы
                        this.Hide(); //скрытие формы авторизации
                        mainForm.ManagerPage.Parent = null; //Скрытие вкладки меню менеджера
                        mainForm.Show(); //отображение главной формы
                        //Очистка полей ввода
                        LoginBox.Text = "";
                        PassBox.Text = "";
                        RolBox.SelectedIndex = 0;
                    }
                    else MessageBox.Show("Ошибка! Проверьте правильность ввода.");
                    break;
                case "Менеджер":
                    if (LoginCheck == (string)checkAuth.ExecuteScalar())
                    {
                        MessageBox.Show("Вы авторизировались с правами Менеджера!");
                        defaultConnect.Close();
                        MainForm mainForm = new MainForm(dataTransfer); //создание объекта главной формы, для взаимодействия с ней
                        mainForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); }; //Событие происходящее при закрытии Главной формы
                        this.Hide(); //скрытие формы авторизации
                        mainForm.AdminPage.Parent = null; //Скрытие вкладки меню администратора
                        mainForm.Show(); //отображение главной формы
                        //Очистка полей ввода
                        LoginBox.Text = "";
                        PassBox.Text = "";
                        RolBox.SelectedIndex = 0;
                    }
                    else MessageBox.Show("Ошибка! Проверьте правильность ввода.");
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Переменная принимает значение строки подключения к бд из конфигурационного файла "App.config" 
            //который находится в директории программы
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection defaultConnect = new MySqlConnection(connectionString);
            defaultConnect.Open(); //Открытие подключения
            string con = defaultConnect.State.ToString();
            MessageBox.Show(con);
        }
        
        //Активация кнопки авторизации
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = LoginBox.Text.Length > 0 && PassBox.Text.Length > 0; 
        }

        //Запрет на ввод в поле логин
        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar <= 63 || e.KeyChar >= 91) && (e.KeyChar <= 96 || e.KeyChar >= 123) && e.KeyChar != 46 && e.KeyChar != 95)
            {
                e.Handled = true;
            }
        }

        //запрет на ввод в поле пароль
        private void PassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                (e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 96 || e.KeyChar >= 123))
            {
                e.Handled = true;
            }
        }

        //Диалоговое окно при закрытии программы
        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", "Сообщение", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
