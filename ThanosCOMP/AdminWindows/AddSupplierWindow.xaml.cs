using System;
using System.Windows;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for AddSupplierWindow.xaml
    /// </summary>
    public partial class AddSupplierWindow : Window
    {

        public AddSupplierWindow()
        {
            InitializeComponent();
        }

        private void AddButton_click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                string rating = RatingTextBox.Text;
                var newSupplier = new Supplier
                {
                    SupplierName = NameTextBox.Text,
                    SupplierAddress = AddressTextBox.Text,
                    SupplierTelephone = TelephoneTextBox.Text,
                    SupplierRating = (decimal)Convert.ToDouble(rating),
                    SupplierEmail = EmailTextBox.Text,
                    SupplierHomePage = HomePageTextBox.Text,
                };
                context.Suppliers.Add(newSupplier);
                context.SaveChanges();
            }
            MessageBox.Show("The supplier was added!");

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
