using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.entity
{
    class Client
    {
        private int idClient;
        private string civilite;
        private string nom;
        private string prenom;
        private string adresse;
        private string ville;
        private string cp;
        private string mail;
        private string tel;

        public int IdClient { get => idClient; set => idClient = value; }
        public string Civilite { get => civilite; set => civilite = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
