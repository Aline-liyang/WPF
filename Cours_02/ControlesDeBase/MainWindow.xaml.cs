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

namespace ControlesDeBase
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Item item1 = new Item();
            item1.Name = "Montréal";
            item1.Description = "Description de Montréal";
            comboBoxVille.Items.Add(item1.Name);

            Item item2 = new Item();
            item2.Name = "Laval";
            item2.Description = "Description de Laval";
            comboBoxVille.Items.Add(item2.Name);

            Item item3 = new Item();
            item3.Name = "Longueil";
            item3.Description = "Description de Longueil";
            comboBoxVille.Items.Add(item3.Name);

            Item item4 = new Item();
            item4.Name = "Québec";
            item4.Description = "Description de Québec";
            comboBoxVille.Items.Add(item4.Name);
        }
    }
}
