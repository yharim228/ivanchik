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
using System.Windows.Shapes;
using WpfApp2.Model;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    { public bool AuthService(string login, string pass)
            {
            var user = _users.FirstOrDefault(u => u.login == login && u.pass == pass);
                if (user != null && user.login == login && user.pass == pass)
            { 
                return true;
            }
                return false;
            }
        private List <UserModel> _users;
        public AuthWindow()
        {
            InitializeComponent();
            _users = new List <UserModel> ()
            { new UserModel
            ("login","pass" ),
            };
        }
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            string login = tbxLogin.Text;
            string pass = tbxPass.Text;
            if (AuthService(login, pass))
            {
                MainWindow Main = new MainWindow();
                Main.Show();
                Close();
            }
            else 
            { 
                MessageBox.Show("пароль или логин неверный"); 
            }

        }
    }
}
