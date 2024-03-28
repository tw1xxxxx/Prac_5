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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PasswordTXT.PasswordChar = '*';

        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)

        {
            if (LoginTXT.Text.StartsWith("1") || LoginTXT.Text.StartsWith("2") || LoginTXT.Text.StartsWith("3") || LoginTXT.Text.StartsWith("4") || LoginTXT.Text.StartsWith("5") || LoginTXT.Text.StartsWith("6") || LoginTXT.Text.StartsWith("7") || LoginTXT.Text.StartsWith("8") || LoginTXT.Text.StartsWith("9") || LoginTXT.Text.StartsWith("0")){
                MessageBox.Show("Login не может начинаться с цифры");
                LoginTXT.Clear();
                }
            else {
                // Логика авторизации (например, проверка в базе данных)
            string login = LoginTXT.Text;
            string password = PasswordTXT.Password;
            string role = "";
                if (login == "admin" & password == "admin") role = "admin";
                else if (login == "customer" & password == "customer") role = "customer";
                else if (login == "personal" & password == "personal") role = "personal";
                else MessageBox.Show("Неверный логин или пароль"); LoginTXT.Clear(); PasswordTXT.Clear();
                switch (role)
                {
                    case "admin":
                        admin adminPanel = new admin();
                        adminPanel.Show();
                        Close();
                        MessageBox.Show("Вы вошли в систему.");
                        break;
                    case "personal":
                        MessageBox.Show("Вы вошли в систему.");
                        break;
                    case "customer":
                        Main main = new Main();
                        Close();
                        main.Show();
                        
                        MessageBox.Show("Вы вошли в систему.");
                        break;

                }
            
                
                
             


            }
        }
       
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            
            // Логика регистрации (например, создание новой записи в базе данных)
            MessageBox.Show("Вы зарегистрировались.");
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
