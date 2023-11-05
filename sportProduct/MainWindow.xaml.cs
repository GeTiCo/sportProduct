using sportProduct.Classes;
using sportProduct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sportProduct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Classes.Helper.DB = new DB.DBFedorenko12Entities();
        }
        private void guest_Click(object sender, RoutedEventArgs e)
        {

        }
        //log loginDEppn2018
        //pas 6}i+FD
        private void user_Click(object sender, RoutedEventArgs e)
        {
            String check_login = login.Text;
            String check_password = password.Password;

            StringBuilder sb = new StringBuilder();
            //DB.User user = Helper.DB.User.Where(u => u.UserLogin == check_login && u.UserPassword == check_password).FirstOrDefault();


            if (String.IsNullOrEmpty(check_login) || String.IsNullOrEmpty(check_password))
            {
                sb.AppendLine("Неверный логин или пароль");
            }
            else
            {
                if (user != null)
                {
                    goToCatalog();
                }
                else
                {
                    MessageBox.Show("Нет пользователей");
                }
            }
            //получение всех пользователей
            //List<DB.User> users = new List<DB.User>();
            //users = Helper.DB.User.ToList();
            //MessageBox.Show("Число пользователей: " + users.Count);
        }
        private void goToCatalog()
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
