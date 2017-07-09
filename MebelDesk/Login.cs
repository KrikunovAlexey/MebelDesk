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

namespace MebelDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            string serverName = "127.0.0.1"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "Mebel"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = ""; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM users"; // Строка запроса
            MySqlCommand sqlCom = new MySqlCommand(sql, conn);
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            var myData = dt.Select();
            for (int i = 0; i < myData.Length; i++)
            {
                if(login==myData[i].ItemArray[1].ToString()&&pass== myData[i].ItemArray[2].ToString())
                {
                    Console.WriteLine(myData[i].ItemArray[0]);
                }
            }
        }
    }
}
