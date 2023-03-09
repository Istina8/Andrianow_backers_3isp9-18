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
using Microsoft.Win32;
using System.IO;

namespace Andrianow_backers_3isp9_18.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditProductWindow.xaml
    /// </summary>
    public partial class AddEdditProductWindow : Window
    {

        private string pathPhoto = null;

        private bool isEdit = false;

        private Product editProduct;



        public AddEdditProductWindow()
        {
            InitializeComponent();

            TbProdType.ItemsSource = ClassHelper.EFClass.Context.ProductType.ToList();
            TbProdType.SelectedIndex = 0;
            TbProdType.DisplayMemberPath = "TypeName";
        }

        public AddEdditProductWindow(Product product)
        {
            InitializeComponent();

            TbProdType.ItemsSource = ClassHelper.EFClass.Context.ProductType.ToList();
            TbProdType.SelectedIndex = 0;
            TbProdType.DisplayMemberPath = "TypeName";

            TbNameProduct.Text = product.Title.ToString();
            TbDisc.Text = product.Description.ToString();
            TbProdType.SelectedItem = ClassHelper.EFClass.Context.ProductType.Where(i => i.id == product.IdProdType).FirstOrDefault();

            if (product.Image != null)
            {
                using (MemoryStream stream = new MemoryStream(product.Image))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    bitmapImage.StreamSource = stream;
                    bitmapImage.EndInit();
                    ImgProduct.Source = bitmapImage;

                }
            }


            isEdit = true;

            editProduct = product;

        }

        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            // валидация


            if (isEdit)
            {
                //изменение товара

                editProduct.Title = TbNameProduct.Text;
                editProduct.Description = TbDisc.Text;
                editProduct.IdProdType = (TbProdType.SelectedItem as ProductType).id;
                if (pathPhoto != null)
                {
                    editProduct.Image = File.ReadAllBytes(pathPhoto);
                }
                Context.SaveChanges();
                MessageBox.Show("OK");
            }
            else
            {
                //добавление товара
                Product product = new Product();
                product.Title = TbNameProduct.Text;
                product.Description = TbDisc.Text;
                product.IdProdType = (TbProdType.SelectedItem as ProductType).id;
                if (pathPhoto != null)
                {
                    product.Image = File.ReadAllBytes(pathPhoto);
                }

                Context.Product.Add(product);

                Context.SaveChanges();
                MessageBox.Show("OK");
            }

            this.Close();

        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
        }
    }
}