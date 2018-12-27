using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    class Combinaison : IComparable
    {
        private Joueur joueur;
        private Carte[] cartes;
        private string nom;
        private int valeur;
        private int valeurMain;

        public Combinaison(Joueur unJoueur, Carte[] cartes, string nom, int valeur, int valeurMain)
        {
            this.joueur = unJoueur;
            this.cartes = cartes;
            this.nom = nom;
            this.valeur = valeur;
            this.valeurMain = valeurMain;
        }

        public Carte[] Cartes { get => cartes; set => cartes = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public int ValeurMain { get => valeurMain; set => valeurMain = value; }
        public Joueur Joueur { get => joueur; set => joueur = value; }

        public Carte[] FusionCartes(Partie unePartie, Joueur unJoueur)
        {
            Carte[] fusionCartes = new Carte[unJoueur.Main_joueur.Length + unePartie.Tapis.Length];
            Array.ConstrainedCopy(unePartie.Tapis, 0, fusionCartes, unJoueur.Main_joueur.Length, unePartie.Tapis.Length);
            Array.ConstrainedCopy(unJoueur.Main_joueur, 0, fusionCartes, 0, unJoueur.Main_joueur.Length);
            return fusionCartes;
        }

        public Carte[] TriCartes(Carte[] fusionCartes)
        {
            Array.Sort(fusionCartes);
            return fusionCartes;
        }

        public static Combinaison Recuperer(Partie unePartie, Joueur unJoueur)
        {
            Carte[] cartes = new Carte[7];
            Combinaison c = new Combinaison(unJoueur, cartes, " ", 0, 0);
            c.Cartes = c.FusionCartes(unePartie, unJoueur);
            c.Cartes = c.TriCartes(c.Cartes);
            if (c.QuinteFlushRoyale(c) != false)
            {
                c.Nom = "Quinte Flush Royale";
                c.Valeur = 10;
                c.ValeurMain = 20;
            }
            else if (c.QuinteFlush(c) != false)
            {
                c.Nom = "Quinte Flush";
                c.Valeur = 9;
                c.ValeurMain = 15;
            }
            else if (c.Carre(c) != 0)
            {
                c.Nom = "Carre";
                c.Valeur = 8;
                c.ValeurMain = c.Carre(c);
            }
            else if (c.Full(c) != 0)
            {
                c.Nom = "Full";
                c.Valeur = 7;
                c.ValeurMain = c.Full(c);
            }
            else if (c.Couleur(c) != 0)
            {
                c.Nom = "Couleur";
                c.Valeur = 6;
                c.ValeurMain = c.Couleur(c);
            }
            else if (c.Quinte(c) != 0)
            {
                c.Nom = "Quinte";
                c.Valeur = 5;
                c.ValeurMain = c.Quinte(c);
            }
            else if (c.Brelan(c) != 0)
            {
                c.Nom = "Brelan";
                c.Valeur = 4;
                c.ValeurMain = c.Brelan(c);
            }
            else if (c.DoublePaire(c) != 0)
            {
                c.Nom = "Double Paires";
                c.Valeur = 3;
                c.ValeurMain = c.DoublePaire(c);
            }
            else if (c.Paire(c) != 0)
            {
                c.Nom = "Paire";
                c.Valeur = 2;
                c.ValeurMain = c.Paire(c);
            }
            else if (c.CarteHaute(c) != 0)
            {
                c.Nom = "RAS";
                c.Valeur = 1;
                c.ValeurMain = c.CarteHaute(c);
            }

            return c;
        }

        public int CarteHaute(Combinaison uneCombinaison)
        {
            int valeur = uneCombinaison.Cartes[6].Valeur;
            return valeur;
        }

        public int Paire(Combinaison uneCombinaison)
        {
            int cpt = 1;
            int temp = uneCombinaison.Cartes[0].Valeur;
            int valeur = 0;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Valeur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Valeur;
                }
                if (cpt == 2)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    return valeur;
                }
            }
            return valeur;
        }

        public int DoublePaire(Combinaison uneCombinaison)
        {
            int cpt = 1;
            int temp = uneCombinaison.Cartes[0].Valeur;
            int valeur = 0;
            int nbPaires = 0;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Valeur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Valeur;
                }
                if (cpt == 2)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    nbPaires++;
                }
                if (nbPaires > 1)
                {
                    return valeur;
                }
            }
            return valeur;
        }

        public int Brelan(Combinaison uneCombinaison)
        {
            int cpt = 1;
            int temp = uneCombinaison.Cartes[0].Valeur;
            int valeur = 0;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Valeur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Valeur;
                }
                if (cpt == 3)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    return valeur;
                }
            }
            return valeur;
        }

        public int Quinte(Combinaison uneCombinaison)
        {
            int valeur = 0;
            int cpt = 1;
            int temp = uneCombinaison.Cartes[0].Valeur;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Valeur + 1)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Valeur;
                }
                if (cpt == 5)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    return valeur;
                }
            }
            return valeur;
        }

        public int Couleur(Combinaison uneCombinaison)
        {
            int cpt = 1;
            String temp = uneCombinaison.Cartes[0].Couleur;
            int valeur = 0;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Couleur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Couleur;
                }
                if (cpt == 5)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    return valeur;
                }
            }
            return valeur;
        }

        public int Full(Combinaison uneCombinaison)
        {
            int cpt = 1;
            List<int> tableTemp = new List<int>();
            int temp = uneCombinaison.Cartes[0].Valeur;
            int valeur = 0;
            bool brelan = false;

            for (int i = 0; i < uneCombinaison.Cartes.Length; i++)
            {
                tableTemp.Add(uneCombinaison.Cartes[i].Valeur);
            }

            for (int i = 1; i < tableTemp.Count(); i++)
            {
                if (temp == tableTemp[i])
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = tableTemp[i];
                }
                if (cpt == 3)
                {
                    valeur = tableTemp[i];
                    tableTemp.RemoveAt(i);
                    tableTemp.RemoveAt(i - 1);
                    tableTemp.RemoveAt(i - 2);
                    brelan = true;
                }
            }

            if (brelan)
            {
                cpt = 1;
                temp = tableTemp[0];

                for (int i = 1; i < tableTemp.Count; i++)
                {
                    if (temp == tableTemp[i])
                    {
                        cpt++;
                    }
                    else
                    {
                        cpt = 1;
                        temp = tableTemp[i];
                    }
                    if (cpt == 2)
                    {
                        return valeur;
                    }
                }
            }
            return valeur;
        }

        public int Carre(Combinaison uneCombinaison)
        {
            int cpt = 1;
            int temp = uneCombinaison.Cartes[0].Valeur;
            int valeur = 0;

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp == uneCombinaison.Cartes[i].Valeur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i].Valeur;
                }
                if (cpt == 4)
                {
                    valeur = uneCombinaison.Cartes[i].Valeur;
                    return valeur;
                }
            }
            return valeur;
        }

        public bool QuinteFlush(Combinaison uneCombinaison)
        {
            int cpt = 1;
            Carte temp = uneCombinaison.Cartes[0];

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp.Valeur == uneCombinaison.Cartes[i].Valeur + 1 && temp.Couleur == uneCombinaison.Cartes[i].Couleur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i];
                }
                if (cpt == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public bool QuinteFlushRoyale(Combinaison uneCombinaison)
        {
            int cpt = 1;
            Carte temp = uneCombinaison.Cartes[0];

            for (int i = 1; i < uneCombinaison.Cartes.Length; i++)
            {
                if (temp.Valeur == uneCombinaison.Cartes[i].Valeur + 1 && temp.Couleur == uneCombinaison.Cartes[i].Couleur)
                {
                    cpt++;
                }
                else
                {
                    cpt = 1;
                    temp = uneCombinaison.Cartes[i];
                }
                if (cpt == 5 && uneCombinaison.Cartes[i].Valeur == 13)
                {
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Carte otherCombinaison = obj as Carte;
            if (otherCombinaison != null)
                return this.valeur.CompareTo(otherCombinaison.Valeur);
            else
                throw new ArgumentException("L'objet n'est pas une Combinaison");
        }
    }
}
