using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.manager
{
    class ProductManager
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


        //Create
        public bool addProduct(entity.Produit produit)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO produit ( designation, description, dateAjout, qte, prix, fichierImage, pk_fournisseur) VALUES (@Designation, @Description, @DateAjout, @Qte, @Prix, @FichierImage, @Pk_fournisseur)";

      
            cmd.Parameters.AddWithValue("@Designation", produit.Designation);
            cmd.Parameters.AddWithValue("@Description", produit.Description);
            cmd.Parameters.AddWithValue("@dateAjout", produit.DateAjout);
            cmd.Parameters.AddWithValue("@Qte", produit.Qte);
            cmd.Parameters.AddWithValue("@Prix", produit.Prix);
            cmd.Parameters.AddWithValue("@FichierImage", produit.FichierImage);
            cmd.Parameters.AddWithValue("@Pk_fournisseur", produit.Pk_fournisseur);

            try
            {
                cmd.ExecuteNonQuery();

                connect.Close();

                return true;
            }
            catch (Exception e)
            {
                connect.Close();

                return false;

            }
        }



        //delete
        public bool deleteProduit(entity.Produit produit)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM produit WHERE idProduit = @Idproduit;";
            cmd.Parameters.AddWithValue("@Idproduit", produit.IdProduit);

            try
            {
                cmd.ExecuteNonQuery();

                connect.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                connect.Close();

                return false;

            }
        }

        //update
        public bool updateProduit(entity.Produit produit, entity.Produit produits)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "UPDATE produit SET designation = @Desingation, description = @Description, dateAjout = @DateAjout, qte = @Qte, prix = @Prix, fichierImage = @FichierImage, pk_fournisseur = @Pk_fournisseur WHERE idProduit = @IdProduit;";

            cmd.Parameters.AddWithValue("@IdProduit", produit.IdProduit);
            cmd.Parameters.AddWithValue("@Designation", produit.Designation);
            cmd.Parameters.AddWithValue("@Description", produit.Description);
            cmd.Parameters.AddWithValue("@DateAjout", produit.DateAjout);
            cmd.Parameters.AddWithValue("@Qte", produit.Qte);
            cmd.Parameters.AddWithValue("@Prix", produit.Prix);
            cmd.Parameters.AddWithValue("@FichierImage", produit.FichierImage);
            cmd.Parameters.AddWithValue("@Pk_fournisseur", produit.Pk_fournisseur);

            try
            {
                cmd.ExecuteNonQuery();

                connect.Close();

                return true;
            }
            catch (Exception e)
            {
                connect.Close();

                return false;

            }


        }

        //readById
        public List<entity.Produit> readById()
        {
            List<entity.Produit> ProduitCollecte = new List<entity.Produit>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from produit WHERE idProduit = @IdProduit";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Produit coll = new entity.Produit();

                coll.IdProduit = collecte.GetInt32("idProduit");


                ProduitCollecte.Add(coll);
            }
            connect.Close();
            return ProduitCollecte;
        }

        //readAll
        public List<entity.Produit> findAll()
        {
            List<entity.Produit> ProduitCollecte = new List<entity.Produit>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from produit";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Produit coll = new entity.Produit();

                coll.IdProduit = collecte.GetInt32("idProduit");
                coll.Designation = collecte.GetString("designation");
                coll.Description = collecte.GetString("description");
                coll.DateAjout = collecte.GetDateTime("dateAjout");
                coll.Qte = collecte.GetInt32("qte");
                coll.Prix = collecte.GetInt32("prix");
                coll.FichierImage = collecte.GetString("fichierImage");
                coll.Pk_fournisseur = collecte.GetInt32("pk_fournisseur");

                ProduitCollecte.Add(coll);
            }
            connect.Close();
            return ProduitCollecte;
        }

    

    }
}
