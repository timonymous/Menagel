using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.manager
{
    class CommandLineManager
    {

        public static MySqlConnection Connexion()
        {
            MySqlConnection connexion = new MySqlConnection("server = localhost;" +
                "database=menageleccsharp;" +
                "port=3306;" +
                "user=toto;" +
                "password=toto;");


            return connexion;
        }

        //readById
        public List<entity.LigneCommande> readById()
        {
            List<entity.LigneCommande> LcCollecte = new List<entity.LigneCommande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from ligneCommande WHERE commande = @Commande";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.LigneCommande coll = new entity.LigneCommande();

                coll.Commande = collecte.GetInt32("commande");


                LcCollecte.Add(coll);
            }
            connect.Close();
            return LcCollecte;
        }

        //readAll
        public List<entity.LigneCommande> findAll()
        {
            List<entity.LigneCommande> LcCollecte = new List<entity.LigneCommande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from ligneCommande";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.LigneCommande coll = new entity.LigneCommande();

                coll.Produit = collecte.GetInt32("produit");
                coll.Commande = collecte.GetInt32("commande");
                coll.Quanity = collecte.GetInt32("quantite");
                

                LcCollecte.Add(coll);
            }
            connect.Close();
            return LcCollecte;
        }

    }
}

