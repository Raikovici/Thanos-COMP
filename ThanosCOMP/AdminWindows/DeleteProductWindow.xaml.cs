using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for DeleteProductWindow.xaml
    /// </summary>
    public partial class DeleteProductWindow : Window
    {
        static string categorySelected;
        static string productSelected;
        public DeleteProductWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var categories = from c in context.Categories
                            select c.CategoryName;
                CategoryPicker.DataContext = categories.ToList();
            }
        }

        private void CategoryPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorySelected = CategoryPicker.SelectedItem.ToString();
            using (var context = new OnlineRetailEntities())
            {
                var products = from p in context.Products
                               join c in context.Categories on p.CategoryID equals c.CategoryID
                               where c.CategoryName.Equals(categorySelected)
                               select p.ProductName;
                ProductPicker.DataContext = products.ToList();
            }
        }

        private void ProductPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelected = ProductPicker.SelectedItem.ToString();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var product = (from p in context.Products
                               where p.ProductName.Equals(productSelected)
                               select p).First();
                context.Products.Remove(product);
                context.SaveChanges();
                MessageBox.Show("The product was deleted!");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
