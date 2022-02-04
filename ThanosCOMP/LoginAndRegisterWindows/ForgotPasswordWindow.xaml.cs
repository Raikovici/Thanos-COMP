using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ThanosCOMP.LoginAndRegisterWindows
{
    /// <summary>
    /// Interaction logic for ForgotPasswordWindow.xaml
    /// </summary>
    public partial class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }
        private void ConfirmPwdBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ConfirmPwdBox.Password == "Password")
                ConfirmPwdBox.Password = string.Empty;
        }

        private void ConfirmPwdBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ConfirmPwdBox.Password == string.Empty)
                ConfirmPwdBox.Password = "Password";
        }

        private void PwdTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (PwdTextBox.Password == "Password")
                PwdTextBox.Password = string.Empty;
        }

        private void PwdTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (PwdTextBox.Password == string.Empty)
                PwdTextBox.Password = "Password";
        }

        private void UserTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (UserTextBox.Text == "Username")
                UserTextBox.Text = string.Empty;
        }

        private void UserTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (UserTextBox.Text == string.Empty)
                UserTextBox.Text = "Username";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(PwdTextBox.Password != ConfirmPwdBox.Password)
            {
                MessageBox.Show("The passwords are not the same!");
            }
            using (var context = new OnlineRetailEntities())
            {
                var user = UserTextBox.Text;
                var account = (from a in context.Accounts
                              where a.Username.Equals(user)
                              select a).First();
                account.Password = PwdTextBox.Password.ToString();
                context.SaveChanges();
                MessageBox.Show("Your password was reset!");
                UserTextBox.Clear();
                PwdTextBox.Clear();
                ConfirmPasswordTextBox.Clear();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PackIconMaterial_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
