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

namespace SliderBinding
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

        private void petit_Click(object sender, RoutedEventArgs e)
        {
            fontSize.Text = "1";
        }

        private void moyen_Click(object sender, RoutedEventArgs e)
        {
            fontSize.Text = "50";
        }

        private void grand_Click(object sender, RoutedEventArgs e)
        {
            fontSize.Text = "100";
        }
    }
}
