using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace WpfAppEntityFramework2
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

        private void btnAfficher_Click(object sender, RoutedEventArgs e)
        {
            this.Afficher();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe
            {
                //EmployeId = Crud.GetLastEmployeIDRecord(connection) + 1,
                Nom = textBoxNom.Text,
                Prenom = textBoxPrenom.Text,
                DateNaissance = textBoxDateNaissance.SelectedDate.Value,
                Adresse = textBoxAdresse.Text,
                Telephone = textBoxTelephone.Text,
                Extension = textBoxExtension.Text,
                Courriel = textBoxCourriel.Text
            };

            using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
            {
                if (employe != null)
                {
                    dbEntities.Employe.Add(employe);

                    int resultat = dbEntities.SaveChanges();
                    if (resultat > 0)
                    {
                        this.Afficher();
                    }
                }
            }

        }
        private void Afficher()
        {
            using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
            {
                listViewDataBase.ItemsSource = dbEntities.Employe.ToList();
            }
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            //Employe employeSelected = listViewDataBase.SelectedItem as Employe;
            //if (employeSelected != null)
            //{
            //    using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
            //    {
            //        Employe emplModified = dbEntities.Employe.FirstOrDefault(x => x.EmployeID == employeSelected.EmployeID);
            //        if(emplModified != null)
            //        {
            //            emplModified.Nom = textBoxNom.Text;
            //            emplModified.Prenom = textBoxPrenom.Text;
            //            emplModified.DateNaissance = textBoxDateNaissance.SelectedDate.Value;
            //            emplModified.Adresse = textBoxAdresse.Text;
            //            emplModified.Telephone = textBoxTelephone.Text;
            //            emplModified.Extension = textBoxExtension.Text;
            //            emplModified.Courriel = textBoxCourriel.Text;

            //            int resultat = dbEntities.SaveChanges();
            //            listViewDataBase.ItemsSource = dbEntities.Employe.ToList();
            //        }
            //    }
            //}

            // or
            this.ModifierSolution2();
        }

        private void ModifierSolution2()
        {
            Employe employeSelected = listViewDataBase.SelectedItem as Employe;
            if (employeSelected != null)
            {
                employeSelected.Nom = textBoxNom.Text;
                employeSelected.Prenom = textBoxPrenom.Text;
                employeSelected.DateNaissance = textBoxDateNaissance.SelectedDate.Value;
                employeSelected.Adresse = textBoxAdresse.Text;
                employeSelected.Telephone = textBoxTelephone.Text;
                employeSelected.Extension = textBoxExtension.Text;
                employeSelected.Courriel = textBoxCourriel.Text;

                using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
                {
                    dbEntities.Employe.AddOrUpdate(employeSelected);
                    int resultat = dbEntities.SaveChanges();
                    listViewDataBase.ItemsSource = dbEntities.Employe.ToList();
                }
            }
            else
            {
                Employe employe = new Employe
                {
                    //EmployeId = Crud.GetLastEmployeIDRecord(connection) + 1,
                    Nom = "Naim",
                    Prenom = "Himrane",
                    DateNaissance = null,
                    Adresse = "Laval",
                    Telephone = "514-123-4567",
                    Extension = "222",
                    Courriel = "naim@bell.ca"
                };

                using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
                {
                    dbEntities.Employe.AddOrUpdate(employe);
                    int resultat = dbEntities.SaveChanges();
                    listViewDataBase.ItemsSource = dbEntities.Employe.ToList();
                }

            }
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Employe employeSelected = (Employe)listViewDataBase.SelectedItem;

            if(employeSelected != null)
            {
                using (WpfDatabaseEntities dbEntities = new WpfDatabaseEntities())
                {
                    Employe emplDeleted =  dbEntities.Employe.SingleOrDefault(x => x.EmployeID == employeSelected.EmployeID);

                    if (emplDeleted != null)
                    {
                        dbEntities.Employe.Remove(emplDeleted);
                        int resultat = dbEntities.SaveChanges();
                        if(resultat > 0)
                        {
                            this.Afficher();
                            string affiche = String.Format("L'employé {0} a été supprimer", emplDeleted.Nom);
                            MessageBox.Show(affiche);

                        }
                    }

                }
            }

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

        

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Afficher();
        }

        private void listViewDataBase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employe employe = listViewDataBase.SelectedItem as Employe;

            if (employe != null)
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
