namespace Menagel
{
    partial class gestionDesCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionDesCommandes));
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnCommandeTout = new System.Windows.Forms.CheckBox();
            this.btnCommandeAPayer = new System.Windows.Forms.CheckBox();
            this.btnCommandeAExpedier = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnListeColisage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommande
            // 
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Location = new System.Drawing.Point(12, 108);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.Size = new System.Drawing.Size(200, 330);
            this.dgvCommande.TabIndex = 0;
            this.dgvCommande.UseWaitCursor = true;
            this.dgvCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(12, 87);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(103, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre d\'éléments :";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCommandeTout
            // 
            this.btnCommandeTout.AutoSize = true;
            this.btnCommandeTout.BackColor = System.Drawing.Color.Transparent;
            this.btnCommandeTout.ForeColor = System.Drawing.Color.White;
            this.btnCommandeTout.Location = new System.Drawing.Point(16, 64);
            this.btnCommandeTout.Name = "btnCommandeTout";
            this.btnCommandeTout.Size = new System.Drawing.Size(48, 17);
            this.btnCommandeTout.TabIndex = 2;
            this.btnCommandeTout.Text = "Tout";
            this.btnCommandeTout.UseVisualStyleBackColor = false;
            this.btnCommandeTout.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCommandeAPayer
            // 
            this.btnCommandeAPayer.AutoSize = true;
            this.btnCommandeAPayer.BackColor = System.Drawing.Color.Transparent;
            this.btnCommandeAPayer.ForeColor = System.Drawing.Color.White;
            this.btnCommandeAPayer.Location = new System.Drawing.Point(70, 64);
            this.btnCommandeAPayer.Name = "btnCommandeAPayer";
            this.btnCommandeAPayer.Size = new System.Drawing.Size(62, 17);
            this.btnCommandeAPayer.TabIndex = 3;
            this.btnCommandeAPayer.Text = "A payer";
            this.btnCommandeAPayer.UseVisualStyleBackColor = false;
            // 
            // btnCommandeAExpedier
            // 
            this.btnCommandeAExpedier.AutoSize = true;
            this.btnCommandeAExpedier.BackColor = System.Drawing.Color.Transparent;
            this.btnCommandeAExpedier.ForeColor = System.Drawing.Color.White;
            this.btnCommandeAExpedier.Location = new System.Drawing.Point(136, 64);
            this.btnCommandeAExpedier.Name = "btnCommandeAExpedier";
            this.btnCommandeAExpedier.Size = new System.Drawing.Size(76, 17);
            this.btnCommandeAExpedier.TabIndex = 4;
            this.btnCommandeAExpedier.Text = "A expédier";
            this.btnCommandeAExpedier.UseVisualStyleBackColor = true;
            this.btnCommandeAExpedier.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des commandes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(233, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(265, 140);
            this.dataGridView2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de références dans la commande : ";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(697, 398);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(91, 40);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Retour menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(257, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gestion des commandes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(572, 82);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(187, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(765, 85);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(765, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnListeColisage
            // 
            this.btnListeColisage.Location = new System.Drawing.Point(572, 207);
            this.btnListeColisage.Name = "btnListeColisage";
            this.btnListeColisage.Size = new System.Drawing.Size(186, 28);
            this.btnListeColisage.TabIndex = 14;
            this.btnListeColisage.Text = "Liste de colisage";
            this.btnListeColisage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(623, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Documents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(572, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rechercher un client :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(572, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rechercher une commande :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(593, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Recherche spécifique";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // gestionDesCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListeColisage);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCommandeAExpedier);
            this.Controls.Add(this.btnCommandeAPayer);
            this.Controls.Add(this.btnCommandeTout);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dgvCommande);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionDesCommandes";
            this.Text = "Menagelec - Gestion des commandes";
            this.Load += new System.EventHandler(this.gestionDesCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.CheckBox btnCommandeTout;
        private System.Windows.Forms.CheckBox btnCommandeAPayer;
        private System.Windows.Forms.CheckBox btnCommandeAExpedier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnListeColisage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}