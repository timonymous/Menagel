using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagel.entity
{
    class Commande
    {

        private int id;
        private DateTime date;
        private int estPayee;
        private int estExpediee;
        private int client;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public int EstPayee { get => estPayee; set => estPayee = value; }
        public int EstExpediee { get => estExpediee; set => estExpediee = value; }
        public int Client { get => client; set => client = value; }
    }
}
