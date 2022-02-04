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

namespace ThanosCOMP.NormalUserWindows
{
    /// <summary>
    /// Interaction logic for Shopping_Cart.xaml
    /// </summary>
    public partial class Shopping_Cart : Window
    {
        public Shopping_Cart()
        {
            InitializeComponent(); //afisam ce exista in shopping cart-ul utilizatorului
            Refresh();
            

        }

        private void Refresh()
        {
            ShoppingCartTable.ItemsSource = null;

            foreach (var i in ShoppingCartTable.Items)
            {
                ShoppingCartTable.Items.Remove(i);
            }
            using (var context = new OnlineRetailEntities())
            {
                var prod = from c in context.Products
                           join scd in context.ShoppingCartDetails on c.ProductID equals scd.ProductID
                           join sc in context.ShoppingCarts on scd.ShoppingCartID equals sc.ShoppingCartID
                           where sc.UserID.Equals(UserDetails.Current_User)
                           select new
                           {
                               c.ProductName,
                               c.ProductPrice,
                               scd.Quantity,
                           };
                ShoppingCartTable.ItemsSource = prod.ToList();
                var prod2 = from c in context.Products
                       join scd in context.ShoppingCartDetails on c.ProductID equals scd.ProductID
                       join sc in context.ShoppingCarts on scd.ShoppingCartID equals sc.ShoppingCartID
                       where sc.UserID.Equals(UserDetails.Current_User)
                       select new
                       {
                           c.ProductID,
                       };
            
            }
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            NormalUserWindow NW = new NormalUserWindow();
            NW.Show();
            this.Close();
        }

        private void BUY_BUTTON(object sender, RoutedEventArgs e)
        {

            PaymentWindow P = new PaymentWindow();
            P.Show();
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        { 
            var context = new OnlineRetailEntities();
            string Prod = ShoppingCartTable.SelectedItem.ToString();
            Prod=(Prod.Split(',')[0].Split('=')[1].Remove(0,1));

            var To_be_removed = (from scd in context.ShoppingCartDetails
                                 join p in context.Products on scd.ProductID equals p.ProductID
                                 join sc in context.ShoppingCarts on scd.ShoppingCartID equals sc.ShoppingCartID
                                 where sc.UserID.Equals(UserDetails.Current_User) && p.ProductName.Equals(Prod)
                                 select scd).First();

            context.ShoppingCartDetails.Remove(To_be_removed);
            context.SaveChanges();
            Refresh();
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            int qant = int.Parse(QuantityBox.Text);
            qant++;
            QuantityBox.Text = qant.ToString();
        }

        private void Minus_Button_Click(object sender, RoutedEventArgs e)
        {
            int qant = int.Parse(QuantityBox.Text);
            if (qant > 1)
                qant--;
            QuantityBox.Text = qant.ToString();
        }

        private void Edit_Quantity(object sender, RoutedEventArgs e)
        {
            var context = new OnlineRetailEntities();
            string Prod = ShoppingCartTable.SelectedItem.ToString();
            Prod = (Prod.Split(',')[0].Split('=')[1].Remove(0, 1));

            var To_be_changed = (from scd in context.ShoppingCartDetails
                                 join p in context.Products on scd.ProductID equals p.ProductID
                                 join sc in context.ShoppingCarts on scd.ShoppingCartID equals sc.ShoppingCartID
                                 where sc.UserID.Equals(UserDetails.Current_User) && p.ProductName.Equals(Prod)
                                 select scd).First();

            To_be_changed.Quantity=int.Parse(QuantityBox.Text);
            context.SaveChanges();
            Refresh();
        }
    }
}
