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

namespace PremiereAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] reponses = new string[]{
                        "Demander à nouveau plus tard",
                        "Impossible de prédire maintenant",
                        "Sans doute",
                        "Est-ce décidément ainsi",
                        "Concentrez-vous et demandez à nouveau",
                        "Mes sources disent non",
                        "Oui, définitivement",
                        "Ne comptez pas dessus",
                        "Les signes indiquent Oui",
                        "Mieux vaut ne pas vous le dire maintenant",
                        "Les perspectives ne sont pas si bonnes",
                        "Très probablement",
                        "Très douteux",
                        "Comme je le vois, oui",
                        "Ma réponse est non",
                        "C'est certain",
                        "Oui", "Vous pouvez vous y fier",
                        "Les perspectives sont bonnes",
                        "Répondez à Hazy Try Again" };
        public MainWindow()
        {
            InitializeComponent();



         
        }

        private void DemandezReponse_Click(object sender, RoutedEventArgs e)
        {
            GenerateurReponses rep = new GenerateurReponses();

            //txtBoxReponse.Text = rep.RetournerReponseAleatoire();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // ce code est exécuté en premier avant l<affichage de votre Window

            Login lg = new Login();
            lg.ShowDialog();

        }

        private void OnClosingWindow(object sender, System.ComponentModel.CancelEventArgs evenement)
        {
            //if (
            //    MessageBox.Show("Vous êtes sûr de quitter?", "fhdlksfhdklfhfhkdlsfhdkl", MessageBoxButton.OKCancel,
            //                    MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.Cancel)
            //{
            //    evenement.Cancel = true; 
            //}
        }
    }
}
