using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeView
{
    public class Personne : BindableBase
    {
        private string nom = "";
        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                if (value != this.nom)
                {
                    this.nom = value;
                    OnPropertyChanged();
                }
            }
        }

        public string prenom = "";
        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                if (value != this.prenom)
                {
                    this.prenom = value;
                    OnPropertyChanged();
                }
            }
        }
        private string adresse = "";

        public string Adresse
        {
            get
            {
                return this.adresse;
            }

            set
            {
                if (value != this.adresse)
                {
                    this.adresse = value;
                    OnPropertyChanged();
                }
            }
        }

        public string telephone = "";
        public string Telephone
        {
            get
            {
                return this.telephone;
            }

            set
            {
                if (value != this.telephone)
                {
                    this.telephone = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
