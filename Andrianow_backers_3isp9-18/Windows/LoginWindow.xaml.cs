using Andrianow_backers_3isp9_18.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using static Andrianow_backers_3isp9_18.ClassHelper.EFClass;


namespace Andrianow_backers_3isp9_18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// 12312312312312312
        /// </summary>
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
            if (txtLogin.Text == "Login")
            {
                txtLogin.Text = "";
            }
        }

        private void txtLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Login";
            }
        }

        private void txtPassword_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_LostFocus(object got, RoutedEventArgs a)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = ClassHelper.EFClass.Context.ClientAccount.ToList()
                .Where(i => i.Login == txtLogin.Text &&
                i.Password == txtPassword.Text)
                .FirstOrDefault();

            if (userAuth != null)
            {
                MessageBox.Show("OK");
                ProductListWindow taskWindow = new ProductListWindow();
                taskWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

    }
}

/////