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

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreationPaquetCartes();
        }

        private void CreationPaquetCartes()
        {
            String couleur = "";
            List<Carte> paquetCartes = new List<Carte>();
            for (int i = 0; i < 4; i++)//Pour chaque couleur
            {
                switch (i)
                {
                    case 0:
                        couleur = "Pique";
                        break;
                    case 1:
                        couleur = "Coeur";
                        break;
                    case 2:
                        couleur = "Trefle";
                        break;
                    case 3:
                        couleur = "Carreau";
                        break;

                    default:
                        break;
                }

                for (int y = 1; y < 14; y++)//Pour chaque carte de 1 a 13
                {
                    Carte carte = new Carte(y, couleur);
                    paquetCartes.Add(carte);
                    listBox1.Items.Add(carte);
                }
            }
        }
    }
}
