using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>

    public class ImageClass
    {
        public int id { get; set; }
        public string imagePath { get; set; }
        public byte[] imageToByte { get; set; }

    }
    public partial class AddProductWindow : Window
    {
        static string categorySelected;
        static string shipperSelected;
        static string supplierSelected;
        public AddProductWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var categories = from c in context.Categories
                                 select c.CategoryName;
                CategoryPicker.DataContext = categories.ToList();

                var shippers = from s in context.Shippings
                               select s.ShippingName;
                ShipperPicker.DataContext = shippers.ToList();

                var suppliers = from ss in context.Suppliers
                                select ss.SupplierName;
                SupplierPicker.DataContext = suppliers.ToList();

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorySelected = CategoryPicker.SelectedItem.ToString();
        }
        private void ShipperPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            shipperSelected = ShipperPicker.SelectedItem.ToString();
        }

        private void SupplierPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            supplierSelected = SupplierPicker.SelectedItem.ToString();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var shipperId = (from s in context.Shippings
                                 where s.ShippingName.Equals(shipperSelected)
                                 select s.ShippingID).First();

                var supplierId = (from ss in context.Suppliers
                                  where ss.SupplierName.Equals(supplierSelected)
                                  select ss.SupplierID).First();
                var categoryId = (from c in context.Categories
                                  where c.CategoryName.Equals(categorySelected)
                                  select c.CategoryID).First();
                ImageClass ph = new ImageClass();
                ph.imagePath = ImagePath.Text;
                FileStream fs = new FileStream(ph.imagePath, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                var pr = PriceTextBox.Text;
                var prodDescr = ProductDescription.Text.ToString();
                var newProduct = new Product
                {
                    ProductName = NameTextBox.Text,
                    ProductPrice = Convert.ToDouble(pr),
                    CategoryID = categoryId,
                    SupplierID = supplierId,
                    UnitsInStock = Int32.Parse(UnitsTextBox.Text),
                    ShippingID = shipperId,
                    Photo = data,
                    Description = prodDescr
                };
                context.Products.Add(newProduct);
                context.SaveChanges();
                MessageBox.Show("The product was added!");
                NameTextBox.Clear();
                UnitsTextBox.Clear();
                PriceTextBox.Clear();
                ImagePath.Clear();
                CategoryPicker.SelectedItem = -1;
                ProductImage.Source = null;
                ProductDescription.Clear();
            }
            
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = ".jpeg";
            ImagePath.Text = openFileDialog1.FileName;
            ImageSource imageSource = new BitmapImage(new Uri(ImagePath.Text));
            ProductImage.Source = imageSource;
        }


    }
}
