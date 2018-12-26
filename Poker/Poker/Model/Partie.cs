using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    class Partie
    {
        private int id;
        private List<Joueur> liste_Joueur;
        private int argent_depart;
        private PaquetCartes paquet_cartes;
        private int pot;
        private Carte[] tapis;
        private int petite_blind;
        private int grande_blind;

        public Partie(int id, List<Joueur> liste_Joueur, int argent_depart, PaquetCartes paquet_cartes, int pot, Carte[] tapis, int petite_blind, int grande_blind)
        {
            this.id = id;
            this.liste_Joueur = liste_Joueur;
            this.argent_depart = argent_depart;
            this.paquet_cartes = paquet_cartes;
            this.pot = pot;
            this.tapis = tapis;
            this.petite_blind = petite_blind;
            this.grande_blind = grande_blind;
        }

        public List<Joueur> Liste_Joueur { get => liste_Joueur; set => liste_Joueur = value; }
        public int Argent_depart { get => argent_depart; set => argent_depart = value; }
        public PaquetCartes Paquet_cartes { get => paquet_cartes; set => paquet_cartes = value; }
        public int Pot { get => pot; set => pot = value; }
        public Carte[] Tapis { get => tapis; set => tapis = value; }
        public int Petite_blind { get => petite_blind; set => petite_blind = value; }
        public int Grande_blind { get => grande_blind; set => grande_blind = value; }
        public int Id1 { get => id; set => id = value; }


        public void DistribuerJoueur()
        {
            for (int i = 0; i < 2; i++)
            {
                //Paquet_cartes.Melanger();
                foreach (Joueur joueur in liste_Joueur)
                {
                    joueur.Main_joueur[i] = paquet_cartes.DistribuerUneCarte();
                }
            }  
        }

        public void CreerPartie() { }
        public void RejoindrePartie() { }
        public void SetXML() { }
        public void GetXML() { }
        public void UpdateXML() { }
        public void GetGagnantPartie() { }
        public void DonnerBlinds() { }
        public void APerdu() { }
        public void Suivre() { }
        public void Miser() { }
        public void Checker() { }
        public void SeCoucher() { }
        public void JoueurSuivant() { }
        public void FinPartie() { }
        public void AjouterAuPot() { }

    }
}
