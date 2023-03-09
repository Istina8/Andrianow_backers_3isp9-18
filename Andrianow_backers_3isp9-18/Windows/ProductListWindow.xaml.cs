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

using static Andrianow_backers_3isp9_18.ClassHelper.EFClass;
using Andrianow_backers_3isp9_18.Windows;
using Andrianow_backers_3isp9_18.DB;

namespace Andrianow_backers_3isp9_18.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductListWindow.xaml
    /// </summary>
    public partial class ProductListWindow : Window
    {
        List<string> listSort = new List<string>()
        {
            "По умолчанию",
            "По имени (по возрастанию)",
            "По имени (по убыванию)"
        };
        public ProductListWindow()
        {
            InitializeComponent();

            CmbSort.ItemsSource = listSort;
            CmbSort.SelectedIndex = 0;

            GetListProduct();
        }
        private void GetListProduct()
        {
            List<Product> products = new List<Product>();
            products = Context.Product.ToList();

            // поиск, сортировка, фильтрация

            // поиск
            products = products.Where(i => i.Title.ToLower().Contains(TbSearch.Text.ToLower())).ToList();

            // сортировка
            var selectedIndexCmb = CmbSort.SelectedIndex;

            switch (selectedIndexCmb)
            {
                case 0:
                    products = products.OrderBy(i => i.IdProduct).ToList();
                    break;

                case 1:
                    products = products.OrderBy(i => i.Title.ToLower()).ToList();
                    break;

                case 2:
                    products = products.OrderByDescending(i => i.Title.ToLower()).ToList();
                    break;

                default:
                    break;
            }

            // фильтрация


            // вывод итгового списка
            LvProduct.ItemsSource = products;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddEdditProductWindow addEditProductWindow = new AddEdditProductWindow();
            addEditProductWindow.ShowDialog();
        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var product = button.DataContext as Product;

            AddEdditProductWindow editProductWindow = new AddEdditProductWindow(product);
            editProductWindow.ShowDialog();

            GetListProduct();

        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetListProduct();
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetListProduct();
        }


    }
}
