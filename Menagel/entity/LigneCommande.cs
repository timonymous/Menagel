using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.entity
{
    class LigneCommande
    {

        private int produit;
        private int commande;
        private int quanity;

        public int Produit { get => produit; set => produit = value; }
        public int Commande { get => commande; set => commande = value; }
        public int Quanity { get => quanity; set => quanity = value; }
    }
}
