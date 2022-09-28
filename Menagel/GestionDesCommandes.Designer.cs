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
            this.labelNbElement = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelIdClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommande
            // 
            this.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Location = new System.Drawing.Point(12, 108);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.RowHeadersVisible = false;
            this.dgvCommande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCommande.Size = new System.Drawing.Size(214, 377);
            this.dgvCommande.TabIndex = 3;
            this.dgvCommande.Visible = false;
            this.dgvCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommande_CellClick);
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
            this.btnCommandeTout.CheckedChanged += new System.EventHandler(this.checkBox1_Checked);
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
            this.btnCommandeAPayer.CheckedChanged += new System.EventHandler(this.btnCommandeAPayer_Checked);
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
            this.btnCommandeAExpedier.CheckedChanged += new System.EventHandler(this.checkBox3_Checked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des commandes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(261, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(265, 140);
            this.dataGridView2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de références dans la commande : ";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(757, 445);
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
            this.label3.Location = new System.Drawing.Point(313, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gestion des commandes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(642, 97);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(187, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(835, 100);
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
            this.checkBox1.Location = new System.Drawing.Point(835, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnListeColisage
            // 
            this.btnListeColisage.Location = new System.Drawing.Point(642, 222);
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
            this.label4.Location = new System.Drawing.Point(693, 186);
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
            this.label5.Location = new System.Drawing.Point(642, 81);
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
            this.label6.Location = new System.Drawing.Point(642, 127);
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
            this.label7.Location = new System.Drawing.Point(663, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Recherche spécifique";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelNbElement
            // 
            this.labelNbElement.AutoSize = true;
            this.labelNbElement.BackColor = System.Drawing.Color.Transparent;
            this.labelNbElement.ForeColor = System.Drawing.Color.White;
            this.labelNbElement.Location = new System.Drawing.Point(121, 87);
            this.labelNbElement.Name = "labelNbElement";
            this.labelNbElement.Size = new System.Drawing.Size(7, 13);
            this.labelNbElement.TabIndex = 19;
            this.labelNbElement.Text = "\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(261, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 116);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(261, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 86);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(295, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Information de la commande";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(349, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "séléctionnée";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(266, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "client";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(264, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Adresse mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(263, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Téléphone";
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.BackColor = System.Drawing.SystemColors.Control;
            this.labelIdClient.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelIdClient.Location = new System.Drawing.Point(296, 110);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(0, 13);
            this.labelIdClient.TabIndex = 27;
            // 
            // gestionDesCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 497);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNbElement);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label labelNbElement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelIdClient;
    }
}