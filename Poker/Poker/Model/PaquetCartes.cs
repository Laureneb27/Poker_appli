using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker.Model
{
    class PaquetCartes
    {
        private List<Carte> paquet_cartes;

        public List<Carte> Paquet_cartes { get => paquet_cartes; set => paquet_cartes = value; }

        public PaquetCartes()
        {
            paquet_cartes = CreationPaquet();
            Melanger();
        }

        public List<Carte> CreationPaquet()
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
                    paquetCartes.Add(new Carte(y, couleur));
                }
            }
            return paquetCartes;
        }

        public void Melanger()
        {
            Random random = new Random();
            paquet_cartes.Sort((x, y) => random.Next(-1, 2));
        }

 
        public Carte DistribuerUneCarte()
        {
            Carte carte = paquet_cartes[1];
            paquet_cartes.RemoveAt(1);
            return carte;
        }
    }
}
