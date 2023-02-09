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
using System.Windows.Shapes;

namespace Andrianow_backers_3isp9_18.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void AccountSing(object sender, RoutedEventArgs e)
        {
            LoginWindow taskWindow = new LoginWindow();
            taskWindow.Show();
            Close();
        }
        
        //Работа с текст боксами регестрация

        //ПОЛЕ NAME
        private void txtRegName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegName.Text == "")
            {
                txtRegName.Text = "Name";
            }
            
        }
        private void txtRegName_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtRegName.Text == "Name")
            {
                txtRegName.Text = "";
            }
               
        }

        //ПОЛЕ AGE
        private void txtRegAge_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegAge.Text == "")
            {
                txtRegAge.Text = "Age";
            }
            
        }
        private void txtRegAge_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtRegAge.Text == "Age")
            {
                txtRegAge.Text = "";
            }
            
        }

        //ПОЛЕ LOGIN
        private void txtRegLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegLogin.Text == "")
            {
                txtRegLogin.Text = "Login";
            }
            
        }
        private void txtRegLogin_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtRegLogin.Text == "Login")
            {
                txtRegLogin.Text = "";
            }
          
        }

        //ПОЛЕ PASSWORD
        private void txtRegPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegPassword.Text == "")
            {
                txtRegPassword.Text = "Password";

            }
            
        }
        private void txtRegPassword_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtRegPassword.Text == "Password")
            {
                txtRegPassword.Text = "";
            }
          
        }

        //ПОЛЕ PHONE

        private void txtRegPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRegPhone.Text == "")
            {
                txtRegPhone.Text = "Phone";
            }
           
        }
        private void txtRegPhone_GotFocus(object got, RoutedEventArgs a)
        {
            if (txtRegPhone.Text == "Phone")
            {
                txtRegPhone.Text = "";
            }
            
        }

        

    }
}
