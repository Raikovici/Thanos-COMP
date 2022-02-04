using System;
using System.Linq;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for AddInStockWindow.xaml
    /// </summary>
    public partial class AddInStockWindow : Window
    {
        static string categorySelected;
        static string productSelected;
        public AddInStockWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var results = from c in context.Categories
                              select c.CategoryName;
                
                CategoryPicker.DataContext = results.ToList();
            }
        }

        private void CategoryPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorySelected = CategoryPicker.SelectedItem.ToString();
            using (var context = new OnlineRetailEntities())
            {
                var results = from p in context.Products 
                              join c in context.Categories on p.CategoryID equals c.CategoryID
                              where c.CategoryName.Equals(categorySelected)
                              select p.ProductName;

                ProductPicker.DataContext = results.ToList();
            }
        }

        private void ProductPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelected = ProductPicker.SelectedItem.ToString();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var result = (from p in context.Products
                              where p.ProductName.Equals(productSelected)
                              select p).First();
                result.ProductName = productSelected;
                result.UnitsInStock = Int32.Parse(UnitsTextBox.Text.ToString());
                context.SaveChanges();
                MessageBox.Show("The number of units was updated!");
                UnitsTextBox.Clear();

            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
