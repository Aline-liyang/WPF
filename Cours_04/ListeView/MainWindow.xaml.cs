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
                Adresse = txtAdresse.Text,
                Telephone = txtTelephone.Text,
            };

            ListPersonnes.Add(p);

        }

        private void Supprimer_Personne(object sender, RoutedEventArgs e)
        {
            int ind = lstNoms.SelectedIndex;

            if(ind >=0)
            {
                Personne p = ListPersonnes[ind];
                ListPersonnes.Remove(p);
            }

        }

        private void Modifier_Personne(object sender, RoutedEventArgs e)
        {
            int ind = lstNoms.SelectedIndex;

            if (ind >= 0)
            {
                Personne p = ListPersonnes[ind]; 
                p.Nom = txtNom.Text; // set
                p.Prenom = txtPrenom.Text;  
                p.Adresse = txtAdresse.Text;
                p.Telephone= txtTelephone.Text;
            }
        }

        private void lstNoms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Personne? selectedPerson = lstNoms.SelectedItem as Personne;

            if(selectedPerson != null)
            {
                txtNom.Text =  selectedPerson.Nom;
                txtPrenom.Text = selectedPerson.Prenom;
                txtAdresse.Text = selectedPerson.Adresse;
                txtTelephone.Text = selectedPerson.Telephone;
            }
        }

        private void Effacer_Personne(object sender, RoutedEventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdresse.Text = "";
            txtTelephone.Text = "";
        }
    }
}
