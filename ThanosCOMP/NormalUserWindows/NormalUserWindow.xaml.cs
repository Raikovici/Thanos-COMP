using System.Windows;
using System.Windows.Input;
using System.Linq;
using System.Collections.Generic;
using ThanosCOMP.NormalUserWindows.MVVM.ViewModel;
using ThanosCOMP.LoginAndRegisterWindows;
namespace ThanosCOMP.NormalUserWindows
{
    /// <summary>
    /// Interaction logic for NormalUserWindow.xaml
    /// </summary>
    public partial class NormalUserWindow : Window
    {
        public NormalUserWindow()
        {
            
            InitializeComponent();
            var username = LoginWindow.usernameConnected;
            helloText.Text = "Hello, " + username;
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void shoppingCartButton_Click(object sender, RoutedEventArgs e)
        {
            Shopping_Cart s = new Shopping_Cart();
            this.Close();
            s.Show();
        }
    }
}
