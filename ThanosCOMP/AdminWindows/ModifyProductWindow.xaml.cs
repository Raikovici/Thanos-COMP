using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for ModifyProductWindow.xaml
    /// </summary>

    public partial class ModifyProductWindow : Window
    {
        static string categorySelected;
        static string productSelected;
        static string fieldSelected;
        static int indexSelected;
        public ModifyProductWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var categories = from c in context.Categories
                              select c.CategoryName;

                CategoryPicker.DataContext = categories.ToList();

                var res = context.Database.SqlQuery<string>("SELECT COLUMN_NAME AS C FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Products'");
                var listFields = new List<string>();
                foreach (var i in res)
                {
                    if (i == "ProductName" || i == "SupplierID" || i == "ShippingID"|| i == "ProductPrice")
                    {
                        listFields.Add(i);
                    }
                }
                FieldPicker.DataContext = listFields.ToList();
            }
        }

        private void CategoryPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorySelected = CategoryPicker.SelectedItem.ToString();
            using (var context = new OnlineRetailEntities())
            {
                var products = from c in context.Categories
                               join p in context.Products on c.CategoryID equals p.CategoryID
                               where c.CategoryName.Equals(categorySelected)
                               select p.ProductName;
                ProductPicker.DataContext = products.ToList();
            }
        }

        private void ProductPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelected = ProductPicker.SelectedItem.ToString();
        }

        private void FieldPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fieldSelected = FieldPicker.SelectedItem.ToString();
            indexSelected = FieldPicker.SelectedIndex;
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var product = (from p in context.Products
                               where p.ProductName.Equals(productSelected)
                               select p).First();
                if(fieldSelected == "ProductName")
                {
                    product.ProductName = ValueTextBox.Text.ToString();
                }
                else if(fieldSelected == "ShippingID")
                {
                    product.ShippingID = int.Parse(ValueTextBox.Text.ToString());
                }
                else if(fieldSelected == "SupplierID")
                {
                    product.ShippingID = int.Parse(ValueTextBox.Text.ToString());
                }
                else if (fieldSelected == "ProductPrice")
                {
                    product.ProductPrice = float.Parse(ValueTextBox.Text.ToString());
                }
                else
                {
                    MessageBox.Show("The type is not recognized!");
                }
                context.SaveChanges();
                MessageBox.Show("The product was modified!");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
