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

namespace Andrianow_backers_3isp9_18.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            NameClient.Text = ClassHelper.UserdataClass.user.Name.ToString();
        }

        private void btProdList_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow taskWindow = new MenuWindow();
            Close();
        }
    }
}
