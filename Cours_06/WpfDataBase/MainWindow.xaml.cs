using Microsoft.Data.SqlClient;
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

namespace WpfDataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string databasePath = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\WpfDatabase.mdf;";
        string databasePath = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=E:\ROSEMONT\2022\38803_420-B05-RO\PRATIQUE\COURS_06\WPFDATABASE\WpfDatabase.mdf;";

        ObservableCollection<Employe> employes = new ObservableCollection<Employe>();

        SqlConnection connection = null;
        public MainWindow()
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            try
            {
                connection = new SqlConnection(databasePath);

                // Appeler la méthode "Open" pour établir la connexion avec la base de données
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAfficher_Click(object sender, RoutedEventArgs e)
        {
            employes = Crud.GetListEmployes(connection); // intéroger la base de données
            listViewDataBase.ItemsSource = employes; // Liaison de données (Binding) avec la liste obtenue de la BD

            // OU

            // listViewDataBase.ItemsSource = employes = Crud.GetListEmployes(connection);
        }




        private void btnEffacer_Click(object sender, RoutedEventArgs e)
        {
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxDateNaissance.Text = "";
            textBoxAdresse.Text = "";
            textBoxTelephone.Text = "";
            textBoxExtension.Text = "";
            textBoxCourriel.Text = "";
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe
            {
                EmployeId = Crud.GetLastEmployeIDRecord(connection) + 1, 
                Nom = textBoxNom.Text,
                Prenom = textBoxPrenom.Text,
                DateNaissance = textBoxDateNaissance.SelectedDate.Value,
                Adresse = textBoxAdresse.Text,
                Telephone = textBoxTelephone.Text,
                Extension = textBoxExtension.Text,
                Courriel = textBoxCourriel.Text
            };

            if(Crud.Ajouter(employe, connection))
            {
                employes.Add(employe);
            }
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {

            int index = listViewDataBase.SelectedIndex;
            if(index >0)
            {
                Employe employe = employes[index];
                if(employe != null)
                {
                    if (Crud.Modifier(employe, connection))
                    {
                        employe.Nom = textBoxNom.Text;
                        employe.Prenom = textBoxPrenom.Text;
                        employe.DateNaissance = textBoxDateNaissance.SelectedDate.Value;
                        employe.Adresse = textBoxAdresse.Text;
                        employe.Telephone = textBoxTelephone.Text;
                        employe.Extension = textBoxExtension.Text;
                        employe.Courriel = textBoxCourriel.Text;
                    }
                }
            }
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Employe? employe = listViewDataBase.SelectedItem as Employe;

            if (employe != null)
            {
                if( Crud.Supprimer(employe.EmployeId, connection) )
                {
                    employes.Remove(employe);
                }
                else
                {
                    MessageBox.Show("L'employé {0} n'a pa été supprimé de la BD", employe.Nom);
                }
            }
        }

        private void listViewDataBase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employe? employe = listViewDataBase.SelectedItem as Employe;

            if(employe != null)
            {
                textBoxNom.Text = employe.Nom; 
                textBoxPrenom.Text = employe.Prenom;
                textBoxDateNaissance.Text = employe.DateNaissance.ToString();
                textBoxAdresse.Text = employe.Adresse;
                textBoxTelephone.Text = employe.Telephone;
                textBoxExtension.Text = employe.Extension;
                textBoxCourriel.Text = employe.Courriel;

            }
        }
    }
}
