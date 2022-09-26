using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.manager
{
    class CommandeManager
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
        public bool addClient(entity.Client client)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO utilisateur (idClient, civilite, nom, prenom, adresse, ville, cp, mail, tel) VALUES (@Nom, @Prenom, @Civilite, @Adresse, @Ville, @Cp, @Mail, @Tel)";

            cmd.Parameters.AddWithValue("@IdClient", client.IdClient);
            cmd.Parameters.AddWithValue("@Civilite", client.Civilite);
            cmd.Parameters.AddWithValue("@Nom", client.Nom);
            cmd.Parameters.AddWithValue("@Prenom", client.Prenom);
            cmd.Parameters.AddWithValue("@Ville", client.Ville);
            cmd.Parameters.AddWithValue("@Cp", client.Cp);
            cmd.Parameters.AddWithValue("@Mail", client.Mail);
            cmd.Parameters.AddWithValue("@Tel", client.Tel);

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
        public bool deleteClient(entity.Client client)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM client WHERE idClient = @IdClient;";
            cmd.Parameters.AddWithValue("@IdClient", client.IdClient);

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
        public bool updateClient(entity.Client client, entity.Client clients)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "UPDATE client SET civilite = @Civilite, nom = @Nom, prenom = @Prenom, adresse = @Adresse, ville = @Ville, cp = @Cp, mail = @Mail, tel = @Tel WHERE idClient = @IdClient;";

            cmd.Parameters.AddWithValue("@Id", client.IdClient);
            cmd.Parameters.AddWithValue("@Civilite", client.Civilite);
            cmd.Parameters.AddWithValue("@Nom", client.Nom);
            cmd.Parameters.AddWithValue("@Prenom", client.Prenom);
            cmd.Parameters.AddWithValue("@Adresse", client.Adresse);
            cmd.Parameters.AddWithValue("@Ville", client.Ville);
            cmd.Parameters.AddWithValue("@Cp", client.Cp);
            cmd.Parameters.AddWithValue("@Mail", client.Mail);
            cmd.Parameters.AddWithValue("@Tel", client.Tel);

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
        public List<entity.Client> readById()
        {
            List<entity.Client> LiCollecte = new List<entity.Client>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from client WHERE idClient = @IdClient";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Client coll = new entity.Client();

                coll.IdClient = collecte.GetInt32("idClient");


                LiCollecte.Add(coll);
            }
            connect.Close();
            return LiCollecte;
        }

        //readAll
        public List<entity.Client> findAll()
        {
            List<entity.Client> LiCollecte = new List<entity.Client>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from client";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Client coll = new entity.Client();

                coll.IdClient = collecte.GetInt32("idClient");
                coll.Civilite = collecte.GetString("civilite");
                coll.Nom = collecte.GetString("nom");
                coll.Prenom = collecte.GetString("prenom");
                coll.Adresse = collecte.GetString("adresse");
                coll.Ville = collecte.GetString("ville");
                coll.Cp = collecte.GetString("cp");
                coll.Mail = collecte.GetString("mail");
                coll.Tel = collecte.GetString("tel");

                LiCollecte.Add(coll);
            }
            connect.Close();
            return LiCollecte;
        }

    }

}
}
