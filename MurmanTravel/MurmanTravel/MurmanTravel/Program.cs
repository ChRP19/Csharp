using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurmanTravel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }

    //Класс для передачи данных между формами
    public class DataTransfer
    {
        public object[] SqlManagers { get; set; } //Свойство для передачи запросов
        public object[] LoginCheck { get; set; } //Свойство для передачи логина авторизированного пользователя
        public object[] SqlDogovor { get; set; }
    }
}
