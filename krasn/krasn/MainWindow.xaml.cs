using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace krasn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string  Correctlogin="ККТ",
        private const string Correctlogin="best"
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }


public class RegistrationForm : Form
{
    private Label lblUsername;
    private Label lblPassword;
    private Label lblEmail;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private TextBox txtEmail;
    private Button btnRegister;

    public RegistrationForm()
    {
        // Инициализация элементов управления
        lblUsername = new Label() { Text = "Имя пользователя", Location = new System.Drawing.Point(15, 20) };
        lblPassword = new Label() { Text = "Пароль", Location = new System.Drawing.Point(15, 60) };
        lblEmail = new Label() { Text = "Электронная почта", Location = new System.Drawing.Point(15, 100) };

        txtUsername = new TextBox() { Location = new System.Drawing.Point(150, 20), Width = 200 };
        txtPassword = new TextBox() { Location = new System.Drawing.Point(150, 60), Width = 200, PasswordChar = '*' };
        txtEmail = new TextBox() { Location = new System.Drawing.Point(150, 100), Width = 200 };

        btnRegister = new Button() { Text = "Зарегистрироваться", Location = new System.Drawing.Point(150, 140) };
        btnRegister.Click += new EventHandler(OnRegisterClick);

        // Добавление элементов на форму
        Controls.Add(lblUsername);
        Controls.Add(lblPassword);
        Controls.Add(lblEmail);
        Controls.Add(txtUsername);
        Controls.Add(txtPassword);
        Controls.Add(txtEmail);
        Controls.Add(btnRegister);

        // Настройка формы
        Text = "Форма регистрации";
        Size = new System.Drawing.Size(400, 250);
    }

    private void OnRegisterClick(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string email = txtEmail.Text;

        // Здесь можно добавить валидацию данных и логику регистрации
        MessageBox.Show($"Регистрация пользователя: {username}\nЭлектронная почта: {email}");
    }

    [STAThread]
    public static void Main()
    {
      string login==login Text;
      string Password==Password Text;
            if login==Correct ogin && Password==CorrectPass)
    }
}