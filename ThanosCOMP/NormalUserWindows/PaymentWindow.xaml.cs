using System.Windows;
using System.Windows.Input;
using ThanosCOMP.NormalUserWindows.MVVM.View;
using ThanosCOMP.NormalUserWindows.MVVM.ViewModel;
using ThanosCOMP.LoginAndRegisterWindows;
using System.Linq;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ThanosCOMP.NormalUserWindows
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public static int       userID = LoginAndRegisterWindows.LoginWindow.userID;
        public static int       shoppingcartID;
        public static List<int> shippersID;
        public static float     sumof_ShippingTaxes;
        public static float     sumof_TotalProducts;
        public static int       amountof_Products;
        public static DateTime  orderDate;
        public static DateTime  deliveryDate;
        public static string    cardDetails_plain;
        public static string    cardDetails_hashed;
        public static int       orderID;
        public PaymentWindow()
        {
            InitializeComponent();

            shippersID = new List<int>();
            sumof_ShippingTaxes = 0;
            sumof_TotalProducts = 0;
            amountof_Products = 0;
            //get Today's date
            orderDate = DateTime.Now;
            //add 3 days for delivery date
            deliveryDate = orderDate.AddDays(3);
            
            using (var context = new OnlineRetailEntities())
            {
                //take the shopingcartID using the userID
                shoppingcartID = (from c in context.ShoppingCarts
                              where c.UserID == userID
                              select c.ShoppingCartID).First();
                //obtain quantity and prodID
                var results = from c in context.ShoppingCartDetails
                              where c.ShoppingCartID == shoppingcartID
                             select new
                             {
                                 c.ProductID,
                                 c.Quantity
                             };
                foreach (var item in results)
                {
                    // add the amoutof_Products
                    amountof_Products += item.Quantity;
                    //acquire a list of shippers and product price for each product in the shopping cart
                    var res = (from c in context.Products
                               where c.ProductID == item.ProductID
                               select new 
                               { 
                                   c.ProductPrice,
                                   c.ShippingID //for shippers list
                               }
                               
                               ).First();

                    //TODO: sumof_TotalProducts
                    sumof_TotalProducts += item.Quantity * Convert.ToSingle(res.ProductPrice);
                    shippersID.Add(res.ShippingID); 
                }
                //distinct shippers & doing sumof_ShippingTaxes
               var dist_shipperID = shippersID.Distinct<int>();
               foreach (var shipperID in dist_shipperID)
                {
                    var res = (from c in context.Shippings
                               where c.ShippingID == shipperID
                               select c.ShippingTax).First();
                    sumof_ShippingTaxes += Convert.ToSingle(res);
                }

               //get card_infos
                string card_infos = (from c in context.Users
                                     where c.UserID == userID
                                     select c.CardDetails).First();
                
                //basic hash method
                if (!card_infos.Length.Equals(0))
                {
                    cardDetails_plain = card_infos;
                    cardDetails_hashed = "######";
                    cardDetails_hashed += card_infos.Substring(card_infos.Length / 5, card_infos.Length / 2);
                    cardDetails_hashed += "######";
                }
                else
                {
                    cardDetails_hashed = "-Invalid card details-";
                    mop_tb.Foreground = new SolidColorBrush(Colors.Red);
                }
                 //populate all of the TextBoxes
                 if(sumof_TotalProducts !=0)
                    total_tb.Text = sumof_TotalProducts.ToString() + " lei";
                if (sumof_ShippingTaxes != 0)
                    shipping_tb.Text = sumof_ShippingTaxes.ToString() + " lei";
                if(amountof_Products != 0)
                    amount_tb.Text = amountof_Products.ToString() + " buc.";
                orderdate_tb.Text = orderDate.Date.ToString("MMMM dd, yyyy");
                deliverydate_tb.Text = deliveryDate.Date.ToString("MMMM dd, yyyy");
                mop_tb.Text = cardDetails_hashed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = new OnlineRetailEntities();
            //get last orderID and increment
            var ids = from c in context.Orders
                      select c.OrderID;
            if(ids.Count() == 0)
            {
                orderID = 1;
            }
            else
            {
                orderID = ids.Max();
            }
            orderID++;

            var newOrder = new Order
            {
                //lock payment options on Card only
                OrderID = orderID,
                PaymentID = 1,
                ShoppingCartID = shoppingcartID,
                TotalSum = (double)sumof_TotalProducts,
                ShippingTaxTotal = (double)sumof_ShippingTaxes,
                OrderDate = orderDate
            };

            context.Orders.Add(newOrder);
            context.SaveChanges();
            MessageBox.Show("Great News: Your order has been approved!\nCheck your email for future informations about the state of your command!");
            
            //do some cleaning:
            //1.Erase items from shopping cart
            var last_command_details =(from c in context.ShoppingCartDetails
                                       where c.ShoppingCartID == shoppingcartID
                                       select c);
            foreach (var lcd in last_command_details)
                context.ShoppingCartDetails.Remove(lcd);
            context.SaveChanges();
            //2. Redirect to main user meniu 
            NormalUserWindow NUW = new NormalUserWindow();
            Thread.Sleep(2000); //sleep for 2 sec than redirect 
            NUW.Show();
            this.Close();
        }

        private void CANCEL_BUTTON(object sender, RoutedEventArgs e)
        {
            Shopping_Cart SC = new Shopping_Cart();
            SC.Show();
            this.Close();
        }

        private void Add_Method_Payment(object sender, RoutedEventArgs e)
        {
            AddPaymentWindow AP = new AddPaymentWindow();
            AP.Show();
            this.Close();
        }

        private void Window_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }
}
