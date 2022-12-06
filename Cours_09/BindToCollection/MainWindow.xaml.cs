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

namespace BindToCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ICollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmdGetProducts_Click(object sender, RoutedEventArgs e)
        {
            products = App.StoreDb.GetProducts();
            lstProducts.ItemsSource = products;
        }

        private void cmdDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            products.Remove((Product)lstProducts.SelectedItem);
        }

        private void cmdAddProduct_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product("00000", "?", 0, "?"));
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
