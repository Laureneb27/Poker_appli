using Poker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker.Vue
{
    public partial class FormCreation : Form
    {
        string pseudoJoueur;
        int argentPartie;
        
        public FormCreation()
        {
            InitializeComponent();
        }

        private void FormCreation_Load(object sender, EventArgs e)
        {

        }

        private void button_creer_Click(object sender, EventArgs e)
        {
            pseudoJoueur = textBox_pseudo.Text;
            argentPartie = (int)numericUpDown_argent.Value;
            List<Joueur> joueurs = new List<Joueur>();
            joueurs.Add(new Joueur(pseudoJoueur, "","smallBlind",argentPartie,0,0));

            PaquetCartes paquetCartes = new PaquetCartes();
            Carte[] tapis = new Carte[5];

            Partie partie = new Partie("1", joueurs, argentPartie, paquetCartes, 0, tapis, 5, 10);
            Console.WriteLine("pseudoJoueur est " + pseudoJoueur);
            Console.WriteLine("numeriupdown est " + argentPartie);
            this.Hide();
            FormPartie fp = new FormPartie();
            fp.Show();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
