using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereAppWPF
{
    public class GenerateurReponses
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

        public GenerateurReponses()
        {
        }

        public string RetournerReponseAleatoire ()
        {
            Random choix = new Random();
            string reponse = reponses[choix.Next(0, reponses.Length)];

            return reponse;
        }

        public string RetournerReponseAleatoire(string laQuestion)
        {
            
            return "";
        }
    }
}
