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
        public bool addCommande(entity.Commande commande)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO commande (id, date, estPayee, estExpediee, client) VALUES (@Id, @Date, @EstPayee, @EstExpediee, @Client)";

            cmd.Parameters.AddWithValue("@Id", commande.Id);
            cmd.Parameters.AddWithValue("@Date", commande.Date);
            cmd.Parameters.AddWithValue("@EstPayee", commande.EstPayee);
            cmd.Parameters.AddWithValue("@EstExpediee", commande.EstExpediee);
            cmd.Parameters.AddWithValue("@Client", commande.Client);
      

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
        public bool deleteCommande(entity.Commande commande)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM commande WHERE id = @Id;";
            cmd.Parameters.AddWithValue("@Id", commande.Id);

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
        public bool updateCommande(entity.Commande commande, entity.Commande commandes)
        {
            MySqlConnection connect = new MySqlConnection();
            connect = Connexion();
            connect.Close();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "UPDATE commande SET date = @Date, estPayee = @EstPayee, estExpediee = @EstExpediee, client = @Client WHERE id = @Id;";

            cmd.Parameters.AddWithValue("@Id", commande.Id);
            cmd.Parameters.AddWithValue("@Date", commande.Date);
            cmd.Parameters.AddWithValue("@EstPayee", commande.EstPayee);
            cmd.Parameters.AddWithValue("@EstExpediee", commande.EstExpediee);
            cmd.Parameters.AddWithValue("@Client", commande.Client);

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
        public List<entity.Commande> readById()
        {
            List<entity.Commande> CoCollecte = new List<entity.Commande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from commande WHERE id = @Id";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Commande coll = new entity.Commande();

                coll.Id = collecte.GetInt32("id");


                CoCollecte.Add(coll);
            }
            connect.Close();
            return CoCollecte;
        }

        //readAll
        public List<entity.Commande> ListCommandes()
        {
            List<entity.Commande> CoCollecte = new List<entity.Commande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select id, date, client from commande";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Commande coll = new entity.Commande();

                coll.Id = collecte.GetInt32("id");
                coll.Date = collecte.GetDateTime("date");
                coll.Client = collecte.GetInt32("client");
             

                CoCollecte.Add(coll);
            }
            connect.Close();
            return CoCollecte;
        }

        //commande A payer
        public List<entity.Commande> APayer()
        {
            List<entity.Commande> CoCollecte = new List<entity.Commande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from commande WHERE estPayee = 0";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Commande coll = new entity.Commande();

                coll.Id = collecte.GetInt32("id");
                coll.Date = collecte.GetDateTime("date");
                coll.Client = collecte.GetInt32("client");


                CoCollecte.Add(coll);
            }
            connect.Close();
            return CoCollecte;
        }

        //commande A expedier
        public List<entity.Commande> AExpedier()
        {
            List<entity.Commande> CoCollecte = new List<entity.Commande>();
            MySqlConnection connect = new MySqlConnection();
            connect.Close();
            connect = Connexion();
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "select * from commande WHERE estExpediee = 0";

            MySqlDataReader collecte = cmd.ExecuteReader();
            while (collecte.Read())
            {
                entity.Commande coll = new entity.Commande();

                coll.Id = collecte.GetInt32("id");
                coll.Date = collecte.GetDateTime("date");
                coll.Client = collecte.GetInt32("client");


                CoCollecte.Add(coll);
            }
            connect.Close();
            return CoCollecte;
        }

    }

}

