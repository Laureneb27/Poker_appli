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
    public partial class FormRejoindre : Form
    {
        string pseudoJoueur;

        public FormRejoindre()
        {
            InitializeComponent();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_rejoindre_Click(object sender, EventArgs e)
        {
            pseudoJoueur = textBox_pseudoRejoindre.Text;
            List<Joueur> joueurs = new List<Joueur>();
            joueurs.Add(new Joueur(pseudoJoueur, "", "bigBlind", 0, 0, 0));
        }

        private void FormRejoindre_Load(object sender, EventArgs e)
        {

        }
    }
}
