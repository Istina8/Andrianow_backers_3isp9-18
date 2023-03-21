using Andrianow_backers_3isp9_18.DB;
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
using Andrianow_backers_3isp9_18.Windows;
using static Andrianow_backers_3isp9_18.ClassHelper.CartProductClass;
using Andrianow_backers_3isp9_18.ClassHelper;

namespace Andrianow_backers_3isp9_18.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();

            CartProduct.ItemsSource = ClassHelper.CartProductClass.products;
        }


        //private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
