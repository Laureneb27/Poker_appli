using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    class Carte
    {
        private int valeur;
        private string couleur;

        public int Valeur { get => valeur; set => valeur = value; }
        public string Couleur { get => couleur; set => couleur = value; }
    }
}
