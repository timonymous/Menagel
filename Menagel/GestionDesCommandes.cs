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
    public partial class gestionDesCommandes : Form
    {
        public gestionDesCommandes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            menu m = new menu();
            m.Show();
        }
    }
}
