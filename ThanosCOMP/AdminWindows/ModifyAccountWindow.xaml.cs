using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for ModifyAccountWindow.xaml
    /// </summary>
    public partial class ModifyAccountWindow : Window
    {
        static string userNameSelected;
        static string password;
        static string date;
        public ModifyAccountWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var users = from a in context.Accounts
                            select a.Username;
                AccountsList.DataContext = users.ToList();
            }
        }

        private void AccountsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userNameSelected = AccountsList.SelectedItem.ToString();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            password = PasswordBox.Password.ToString();
            date = DatePicker.Text.ToString();
            using (var context = new OnlineRetailEntities())
            {
                var user = (from a in context.Accounts
                            where a.Username.Equals(userNameSelected)
                            select a).First();
                user.Password = password;
                user.Username = userNameSelected;
                user.ExpireDate = date;
                context.SaveChanges();
                MessageBox.Show("The user details were modified!");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
