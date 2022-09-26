using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.entity
{
    class Produit
    {
        private int idProduit;
        private string designation;
        private string description;
        private DateTime dateAjout;
        private int qte;
        private int prix;
        private string fichierImage;
        private int pk_fournisseur;

        public int IdProduit { get => idProduit; set => idProduit = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateAjout { get => dateAjout; set => dateAjout = value; }
        public int Qte { get => qte; set => qte = value; }
        public int Prix { get => prix; set => prix = value; }
        public string FichierImage { get => fichierImage; set => fichierImage = value; }
        public int Pk_fournisseur { get => pk_fournisseur; set => pk_fournisseur = value; }
    }
}
