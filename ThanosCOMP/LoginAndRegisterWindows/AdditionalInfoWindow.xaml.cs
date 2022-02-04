using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ThanosCOMP.LoginAndRegisterWindows
{
    /// <summary>
    /// Interaction logic for AdditionalInfoWindow.xaml
    /// </summary>
    public partial class AdditionalInfoWindow : Window
    {
        public AdditionalInfoWindow()
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

        private void PackIconMaterial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void FirstNameTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (FirstNameTextBox.Text == "First Name")
                FirstNameTextBox.Text = string.Empty;
        }

        private void LastNameTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (LastNameTextBox.Text == "Last Name")
                LastNameTextBox.Text = string.Empty;
        }

        private void EmailTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (EmailTextBox.Text == "Email")
                EmailTextBox.Text = string.Empty;
        }

        private void AddressTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (AddressTextBox.Text == "Address")
                AddressTextBox.Text = string.Empty;
        }

        private void CardDetailsBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (CardDetailsBox.Text == "Card Details")
                CardDetailsBox.Text = string.Empty;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveInfoButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var user = UsrTextBox.Text;
                var account = (from a in context.Accounts
                               where a.Username.Equals(user)
                               select a.AccountID).First();

                var newUser = new User
                {
                    AccountID = account,
                    RoleID = 2,
                    FirstName = FirstNameTextBox.Text.ToString(),
                    LastName = LastNameTextBox.Text.ToString(),
                    Email = EmailTextBox.Text.ToString(),
                    Address = AddressTextBox.Text.ToString(),
                    CardDetails = CardDetailsBox.Text.ToString()
                };
                context.Users.Add(newUser);
                context.SaveChanges();
            }
            MessageBox.Show("Your information were added! Thank you!");
            UsrTextBox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            AddressTextBox.Clear();
            EmailTextBox.Clear();
            CardDetailsBox.Clear();
        }

        private void FirstNameTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (FirstNameTextBox.Text == string.Empty)
                FirstNameTextBox.Text = "First Name";
        }

        private void LastNameTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (LastNameTextBox.Text == string.Empty)
                LastNameTextBox.Text = "Last Name";
        }

        private void EmailTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (EmailTextBox.Text == string.Empty)
                EmailTextBox.Text = "Email";
        }

        private void AddressTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (AddressTextBox.Text == string.Empty)
                AddressTextBox.Text = "Address";
        }

        private void CardDetailsBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (CardDetailsBox.Text == string.Empty)
                CardDetailsBox.Text = "Card Details";
        }

        private void UsrTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (UsrTextBox.Text == "User")
                UsrTextBox.Text = string.Empty;
        }

        private void UsrTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (UsrTextBox.Text == string.Empty)
                UsrTextBox.Text = "User";
        }
    }
}
