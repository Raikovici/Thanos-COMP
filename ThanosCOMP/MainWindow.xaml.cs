using System.Windows;
using System.Windows.Input;
using ThanosCOMP.LoginAndRegisterWindows;

namespace ThanosCOMP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow L = new LoginWindow();
            L.Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow R = new RegisterWindow();
            R.Show();
            this.Close();
        }

        private void AboutUs_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("OnlineRetailApplication\nDesigned by:\n Raicu Andrei\n Galea Alexandru\n Grigore Denis");
        }
    }
}
