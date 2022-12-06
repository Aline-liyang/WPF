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
using System.Windows.Shapes;

namespace Li_Projet_803
{
    /// <summary>
    /// Interaction logic for ListeClients.xaml
    /// </summary>
    public partial class ListeClients : Window
    {
        public IEnumerable<Client> listeClients;
        public ListeClients(IEnumerable<Client> listeClients)
        {

            InitializeComponent();
            listViewClients.ItemsSource = listeClients.ToList();
        }

    }
}
