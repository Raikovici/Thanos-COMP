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
using ThanosCOMP.LoginAndRegisterWindows;

namespace ThanosCOMP.NormalUserWindows
{
    /// <summary>
    /// Interaction logic for AddPaymentWindow.xaml
    /// </summary>
    public partial class AddPaymentWindow : Window
    {
        public AddPaymentWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            PaymentWindow pw = new PaymentWindow();
            pw.Show();
            this.Close();
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            //save text box in card details of user
            //to do

            //check if he typed smth or not
            if (cardinfosTB.Text.Length !=0) 
            {
                var context = new OnlineRetailEntities();
                //get our user
                var User = (from c in context.Users
                            where c.AccountID == LoginAndRegisterWindows.LoginWindow.userID
                            select c).First();
                //modify  the card details & save
                User.CardDetails = cardinfosTB.Text;
                context.SaveChanges();

                if (User.CardDetails.Length != 0)
                    MessageBox.Show("Your card details have been succesfully updated!");
                else 
                    MessageBox.Show("Your card details have been succesfully added!");
                //new payment window with the updated infos
                PaymentWindow pw = new PaymentWindow();
                pw.Show();
                this.Close();
            }
            else MessageBox.Show("Add your card details!");

        }
    }
}
