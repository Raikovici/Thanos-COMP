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

namespace ThanosCOMP.NormalUserWindows.MVVM.View
{
    /// <summary>
    /// Interaction logic for MiceView.xaml
    /// </summary>
    public partial class MiceView : UserControl
    {
        public static int mouseButtonId;
        public MiceView()
        {
            InitializeComponent();
        }

        private void imageButton1_Click(object sender, RoutedEventArgs e)
        {
            mouseButtonId = 1;
            ProductWindow p = new ProductWindow();
            p.Show();
        }

        private void imageButton2_Click(object sender, RoutedEventArgs e)
        {
            mouseButtonId = 2;
            ProductWindow p = new ProductWindow();
            p.Show();
        }

        private void imageButton3_Click(object sender, RoutedEventArgs e)
        {
            mouseButtonId = 3;
            ProductWindow p = new ProductWindow();
            p.Show();
        }
    }
}
