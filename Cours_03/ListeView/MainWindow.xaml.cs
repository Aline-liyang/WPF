using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Personne> ListPersonnes; 

        public MainWindow()
        {
            InitializeComponent();

            ListPersonnes = new ObservableCollection<Personne>()
            {
                new Personne()
                {
                    Nom = "Himrane", Prenom="Naim", Adresse = "Laval"
                },

                new Personne()
                {
                    Nom = "Smith", Prenom="John", Adresse = "Montreal"
                },

                new Personne()
                {
                    Nom = "Taminko", Prenom="Ohmala", Adresse = "Saint Jérôme"
                },
            };

            // La liason de données (Binding) se passe ici
            lstNoms.ItemsSource = ListPersonnes;
        }

        private void Ajouter_Personne(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne()
            {
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Adresse = txtAdresse.Text
            };

            ListPersonnes.Add(p);

        }
    }
}
