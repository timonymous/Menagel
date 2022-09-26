using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menagel
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

             gestionDesCommandes g = new gestionDesCommandes();
            g.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
