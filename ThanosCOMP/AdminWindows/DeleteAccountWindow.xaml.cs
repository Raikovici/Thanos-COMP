using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for DeleteAccountWindow.xaml
    /// </summary>
    public partial class DeleteAccountWindow : Window
    {
        static string userNameSelected;
        public DeleteAccountWindow()
        {
            InitializeComponent();
            using (var context = new OnlineRetailEntities())
            {
                var users = from a in context.Accounts
                            select a.Username;
                UserList.DataContext = users.ToList();
            }
        }
        
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var user = (from a in context.Accounts
                            where a.Username.Equals(userNameSelected)
                            select a).First();
                context.Accounts.Remove(user);
                context.SaveChanges();
                MessageBox.Show("The user was deleted!");
            }
            
        }

        private void UserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userNameSelected = UserList.SelectedItem.ToString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
