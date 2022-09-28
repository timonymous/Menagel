﻿using System;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Checked(object sender, EventArgs e)
        {


            
            dgvCommande.Columns.Clear();
            btnCommandeTout.Visible = true;
            dgvCommande.AutoSize = true;
            dgvCommande.Visible = true;
            dgvCommande.Name = "dgvCommandeTout";
            dgvCommande.Columns["idCommande"].DisplayIndex = 0;



            List<entity.Commande> CoCollecte = new List<entity.Commande>();
            manager.CommandeManager commandeManager = new manager.CommandeManager();

            // Récuoération de toutes les collectes 
            CoCollecte = commandeManager.ListCommandes();
            dgvCommande.DataSource = CoCollecte;
            dgvCommande.Columns["estPayee"].Visible = false;
            dgvCommande.Columns["estExpediee"].Visible = false;


        }

        private void gestionDesCommandes_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
