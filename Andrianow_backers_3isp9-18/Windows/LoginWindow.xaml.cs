using Andrianow_backers_3isp9_18.Windows;
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

namespace Andrianow_backers_3isp9_18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void NoAccountClick(object sender, RoutedEventArgs e)
        {
            
            RegistrationWindow taskWindow = new RegistrationWindow();
            taskWindow.Show();
            Close();
        }

        private void txtLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLogin.Text = "";
        }

        private void txtLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            txtLogin.Text = "Login";
        }

        private void txtPassword_GotFocus(object got, RoutedEventArgs a)
        {
            txtPassword.Text = "";
        }

        private void txtPassword_LostFocus(object got, RoutedEventArgs a)
        {
            txtPassword.Text = "Password";
        }
    }
}
