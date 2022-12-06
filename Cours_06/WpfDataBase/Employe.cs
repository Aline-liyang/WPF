using ListeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBase
{
    public class Employe : BindableBase
    {
        public int EmployeId { get; set; }
        //public string Nom { get; set; } = "";

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
        public string Prenom { get; set; } = "";
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; } = ""; 
        public string Telephone { get; set; } = "";
        public string Extension { get; set; } = "";
        public string Courriel { get; set; } = "";
    }
}
