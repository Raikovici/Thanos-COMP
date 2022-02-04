using System.Windows;
using System.Windows.Input;
namespace ThanosCOMP.LoginAndRegisterWindows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
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
        private void close(object sender, MouseButtonEventArgs e)
        {
            MainWindow W = new MainWindow();
            this.Close();
            W.Show();

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var user = new Account
                {
                    Username = UserTextBox.Text.ToString(),
                    Password = PwdTextBox.Password.ToString()
                };
                context.Accounts.Add(user);
                context.SaveChanges();
                MessageBox.Show("Your account was registered. Please press Add button for enter more information");
                UserTextBox.Clear();
                PwdTextBox.Clear();
            }
        }

        private void AdditionalInfoButton_Click(object sender, RoutedEventArgs e)
        {
            AdditionalInfoWindow A = new AdditionalInfoWindow();
            A.Show();
        }

        private void PwdTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (PwdTextBox.Password == "Password")
                PwdTextBox.Password = string.Empty;
        }

        private void UserTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (UserTextBox.Text == "Username")
                UserTextBox.Text = string.Empty;
        }

        private void PwdTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (PwdTextBox.Password == "")
                PwdTextBox.Password = "Password";
        }

        private void UserTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (UserTextBox.Text == "")
                UserTextBox.Text = "Username";
        }
    }


}
