using System.Windows;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for ShowAccountsWindow.xaml
    /// </summary>
    public partial class ShowAccountsWindow : Window
    {
        public ShowAccountsWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
