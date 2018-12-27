using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    public class Carte : IComparable
    {
        private int valeur;
        private string couleur;


        public Carte(int valeur,string couleur)
        {
            this.valeur = valeur;
            this.couleur = couleur;
        }

        public Carte()
        {
        }

        public int Valeur { get => valeur; set => valeur = value; }
        public string Couleur { get => couleur; set => couleur = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Carte otherCard = obj as Carte;
            if (otherCard != null)
                return this.valeur.CompareTo(otherCard.valeur);
            else
                throw new ArgumentException("L'objet n'est pas une carte");
        }
    }
}
