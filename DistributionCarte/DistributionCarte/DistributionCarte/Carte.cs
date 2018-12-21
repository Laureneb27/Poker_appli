using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionCarte
{
    class Carte
    {
        int valeur;
        string couleur;

        public Carte (int valeur,string couleur)
        {
            this.valeur = valeur;
            this.couleur = couleur;
        }

        public override string ToString()
        {
            return valeur + "_" + couleur;
        }

        public int Valeur { get => valeur; set => valeur = value; }
        public string Couleur { get => couleur; set => couleur = value; }



    }
}
