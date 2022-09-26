using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menagel
{
    class Sql
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
    }
}
