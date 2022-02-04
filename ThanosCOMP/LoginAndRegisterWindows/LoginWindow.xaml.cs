using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ThanosCOMP.AdminWindows;
using ThanosCOMP.NormalUserWindows;


namespace ThanosCOMP.LoginAndRegisterWindows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public static string usernameConnected;
        public static int userID;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
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
        private void UserTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if(UserTextBox.Text == "Username")
                UserTextBox.Text = string.Empty;
        }

        private void PasswordBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (PasswordBox.Password == "Password")
                PasswordBox.Password = string.Empty;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var usr = UserTextBox.Text.ToString();
                var pass = PasswordBox.Password.ToString();
                IEnumerable<Account> users = from c in context.Accounts
                                             where c.Username.Equals(usr) && c.Password.Equals(pass)
                                             select c;
                var newUser = new Account();
                if (users.Count() != 0)
                {
                    newUser = users.First();
                    //we need userID in payment window
                    userID = newUser.AccountID;

                    if (newUser != null)
                    {
                        if (newUser.Password == pass)
                        {
                            MessageBox.Show("Login Correct!");

                            var roleName = (from r in context.Roles
                                            join u in context.Users on r.RoleID equals u.RoleID
                                            join a in context.Accounts on u.AccountID equals a.AccountID
                                            where a.Username.Equals(usr)
                                            select r).First();

                            var userid = (from u in context.Users join a in context.Accounts on u.AccountID equals a.AccountID where a.Username.Equals(usr) select u).First();
                            UserDetails.Current_User = userid.UserID; //Global variable for USER ID

                            if (roleName.RoleName == "Admin")
                            {
                                AdminWindow A = new AdminWindow();
                                A.Show();
                                this.Close();
                            }
                            else if (roleName.RoleName == "Normal User")
                            {
                                usernameConnected = newUser.Username;
                                NormalUserWindow N = new NormalUserWindow();
                                N.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Incorrect!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no user with that username!");
                    }
                }
            }
        }

        private void UserTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (UserTextBox.Text == string.Empty)
                UserTextBox.Text = "Username";
        }

        private void PasswordBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (PasswordBox.Password == string.Empty)
                PasswordBox.Password = "Password";
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow W = new ForgotPasswordWindow();
            W.Show();
        }

        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(this, e);
            }
        }
    }
}
