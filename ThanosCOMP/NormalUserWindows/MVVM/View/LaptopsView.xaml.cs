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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThanosCOMP.NormalUserWindows;
namespace ThanosCOMP.NormalUserWindows.MVVM.View
{
    /// <summary>
    /// Interaction logic for LaptopsView.xaml
    /// </summary>

    
    public partial class LaptopsView : UserControl
    {
        public static int laptopButtonId;
        public LaptopsView()
        {
            InitializeComponent();
            
        }
        
        private void imageButton1_Click(object sender, RoutedEventArgs e)
        {
            laptopButtonId = 1;
            ProductWindow p = new ProductWindow();
            p.Show();

        }

        private void imageButton2_Click(object sender, RoutedEventArgs e)
        {
            laptopButtonId = 2;
            ProductWindow p = new ProductWindow();
            p.Show();
        }

        private void imageButton3_Click(object sender, RoutedEventArgs e)
        {
            laptopButtonId = 3;
            ProductWindow p = new ProductWindow();
            p.Show();
        }
    }
}
