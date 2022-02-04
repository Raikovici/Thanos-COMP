using System;
using System.Windows;
namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for AddShipperWindow.xaml
    /// </summary>
    public partial class AddShipperWindow : Window
    {
        public AddShipperWindow()
        {
            InitializeComponent();
        }

        private void AddShipperButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                string tax = TaxTextBox.Text;
                var newShipper = new Shipping
                {
                    ShippingName = NameTextBox.Text,
                    ShippingTelephone = PhoneTextBox.Text,
                    ShippingHomePage = HomePageTextBox.Text,
                    ShippingTax = Convert.ToDouble(tax)
                };
                context.Shippings.Add(newShipper);
                context.SaveChanges();
            }

            MessageBox.Show("The shipper entity was added!");

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
