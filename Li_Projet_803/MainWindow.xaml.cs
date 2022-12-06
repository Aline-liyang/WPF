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

namespace Li_Projet_803
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

        private void Afficher()
        {
            try
            {
                using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                {
                    listViewEmployes.ItemsSource = databaseEntities.Employes.ToList();
                    // listViewCommandes.ItemsSource = databaseEntities.Commandes.ToList();
                    cmbProduits.ItemsSource = databaseEntities.Produits.ToList();
                    cmbCatégories.ItemsSource = databaseEntities.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewEmployes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Employe employe = listViewEmployes.SelectedItem as Employe;

                if (employe != null)
                {
                    textBoxNom.Text = employe.Nom;
                    textBoxPrenom.Text = employe.Prenom;
                    textBoxDateNaissance.Text = employe.DateDeNaissance.ToString();
                    textBoxAdresse.Text = employe.Adresse;
                    textBoxTelephone.Text = employe.Telephone;
                    textBoxExtension.Text = employe.Extension;
                    textBoxProvince.Text = employe.Province;
                    textBoxCodepostal.Text = employe.CodePostal;
                    textBoxNotes.Text = employe.Notes;
                    textBoxTitre.Text = employe.Titre;
                    textBoxDateEmbauche.Text = employe.DateEmbauche.ToString();
                    textBoxPays.Text = employe.Pays;
                    cmbProduits.Text = "";
                    cmbCatégories.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            this.Afficher();
        }

        private void btnEffacer_Click(object sender, RoutedEventArgs e)
        {
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxDateNaissance.Text = "";
            textBoxAdresse.Text = "";
            textBoxTelephone.Text = "";
            textBoxExtension.Text = "";
            textBoxProvince.Text = "";
            textBoxCodepostal.Text = "";
            textBoxNotes.Text = "";
            textBoxTitre.Text = "";
            textBoxDateEmbauche.Text = "";
            textBoxPays.Text = "";
            cmbProduits.Text = "";
            cmbCatégories.Text = "";

        }

        private void btnSauvegarder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Empid = getLastEmpId();
                Employe employe = new Employe

                {
                    EmployeID = Empid + 1,
                    Nom = textBoxNom.Text,
                    Prenom = textBoxPrenom.Text,
                    DateDeNaissance = textBoxDateNaissance.SelectedDate.Value,
                    Adresse = textBoxAdresse.Text,
                    Telephone = textBoxTelephone.Text,
                    Extension = textBoxExtension.Text,
                    Titre = textBoxTitre.Text,
                    DateEmbauche = textBoxDateEmbauche.SelectedDate.Value,
                    Province = textBoxProvince.Text,
                    CodePostal = textBoxCodepostal.Text,
                    Pays = textBoxPays.Text,
                    Notes = textBoxNotes.Text

                };

                using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                {
                    if (employe != null)
                    {
                        databaseEntities.Employes.Add(employe);

                        int result = databaseEntities.SaveChanges();
                        if (result > 0)
                        {
                            this.Afficher();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private int getLastEmpId()
        {            
                using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                {
                    return (databaseEntities.Employes.OrderByDescending(x => x.EmployeID)).First().EmployeID;
                }
                  
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employe employeSelectd = (Employe)listViewEmployes.SelectedItem;
                if (employeSelectd != null)
                {
                    using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                    {
                        Employe employeModified = databaseEntities.Employes.SingleOrDefault(x => x.EmployeID == employeSelectd.EmployeID);
                        if (employeModified != null)
                        {
                            employeModified.Nom = textBoxNom.Text;
                            employeModified.Prenom = textBoxPrenom.Text;
                            employeModified.DateDeNaissance = textBoxDateNaissance.SelectedDate.Value;
                            employeModified.Adresse = textBoxAdresse.Text;
                            employeModified.Telephone = textBoxTelephone.Text;
                            employeModified.Extension = textBoxExtension.Text;
                            employeModified.Titre = textBoxTitre.Text;
                            employeModified.DateEmbauche = textBoxDateEmbauche.SelectedDate.Value;
                            employeModified.Province = textBoxProvince.Text;
                            employeModified.CodePostal = textBoxCodepostal.Text;
                            employeModified.Pays = textBoxPays.Text;
                            employeModified.Notes = textBoxNotes.Text;

                            int result = databaseEntities.SaveChanges();
                            if (result > 0)
                            {
                                this.Afficher();
                                string str1 = String.Format("employe {0} est modifie", employeModified.Nom);
                                MessageBox.Show(str1);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employe employeSelectd = (Employe)listViewEmployes.SelectedItem;
                if (employeSelectd != null)
                {
                    using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                    {

                        Employe employeDeleted = databaseEntities.Employes.SingleOrDefault(x => x.EmployeID == employeSelectd.EmployeID);
                        if (employeDeleted != null)
                        {
                            var commandesDeleted = databaseEntities.Commandes.Where(r => r.EmployeID == employeSelectd.EmployeID);

                            foreach (Commande commande in commandesDeleted)
                            {
                                commande.EmployeID = null;
                            }

                            databaseEntities.Employes.Remove(employeDeleted);
                            int result = databaseEntities.SaveChanges();
                            if (result > 0)
                            {
                                this.Afficher();
                                string str1 = String.Format("employe id  {0}, nom  {1} est supprime", employeDeleted.EmployeID, employeDeleted.Nom);
                                MessageBox.Show(str1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /* private void listViewCommandes_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {

         }*/

        private void ListViewEmployes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Employe employeSelectd = (Employe)listViewEmployes.SelectedItem;
                //MessageBox.Show("Name " + employeSelectd.Nom);

                if (employeSelectd != null)
                {
                    using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                    {

                        IEnumerable<Commande> commandes = databaseEntities.Commandes.Where(r => r.EmployeID == employeSelectd.EmployeID);
                        listViewCommandes.ItemsSource = commandes.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewCommandes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Commande commandeSelectd = (Commande)listViewCommandes.SelectedItem;

                // si ListeClients.xmal est une page, pas windows
                //MessageBox.Show("ClientID" + );
                /*if (commandeSelectd != null)
                {
                    using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                    {
                        IEnumerable<Client> clientSeleted = databaseEntities.Clients.Where(x => x.ClientID == commandeSelectd.ClientID);
                        ListeClients listeclient = new ListeClients(clientSeleted);
                        this.Content = listeclient;
                    }
                }*/


                //ListeClients.xmal est une windows
                if (commandeSelectd != null)
                {
                    using (Evaluation2Entities databaseEntities = new Evaluation2Entities())
                    {
                        IEnumerable<Client> clientSeleted = databaseEntities.Clients.Where(x => x.ClientID == commandeSelectd.ClientID);
                        ListeClients listeclient = new ListeClients(clientSeleted);
                        listeclient.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
