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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = userTextBox.Text;
            string password = passwordTextBox.Text;

            if (login == "fournier" && password == "1234"|| login == "hurier" && password == "5678")
            {
                this.Hide();

                menu m = new menu(); 
                m.Show();

            }
            else
            {
                MessageBox.Show("identifiant ou mot de passe incorrect");
            }
        }
    }
}
