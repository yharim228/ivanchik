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

namespace DO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
        }

        public void ButtunClickToAdd(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void ButtunClickToUpdate(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void ButtunClickToDel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            private const string CorrectLogin = "ККТ";
            private const string CorrectPass = "best";
            string login = "tbxlogin";
            string pass = "tbxpass";
         
        }
    }
}
