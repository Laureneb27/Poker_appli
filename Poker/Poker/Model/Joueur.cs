using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    class Joueur
    {
        string pseudo, statut, role;
        int argent, mise,valeur_main;

        private Carte[] main_joueur;

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Statut { get => statut; set => statut = value; }
        public string Role { get => role; set => role = value; }
        public int Argent { get => argent; set => argent = value; }
        public int Mise { get => mise; set => mise = value; }
        public int Valeur_main { get => valeur_main; set => valeur_main = value; }
        internal Carte[] Main_joueur { get => main_joueur; set => main_joueur = value; }

        public Joueur(string pseudo, string statut, string role, int argent, int mise, int valeur_main)
        {
            this.Pseudo = pseudo;
            this.Statut = statut;
            this.Role = role;
            this.Argent = argent;
            this.Mise = mise;
            this.Valeur_main = valeur_main;
            this.Main_joueur = new Carte[2];
        }
    }
}
