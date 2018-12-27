using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Poker.Model
{
    public class Partie
    {
        [XmlIgnore]
        private String id;
        [XmlIgnore]
        private List<Joueur> liste_Joueur;
        private int argent_depart;
        [XmlIgnore]
        private PaquetCartes paquet_cartes;
        private int pot;
        [XmlIgnore]
        private Carte[] tapis;
        private int petite_blind;
        private int grande_blind;

        public Partie(String id, List<Joueur> liste_Joueur, int argent_depart, PaquetCartes paquet_cartes, int pot, Carte[] tapis, int petite_blind, int grande_blind)
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
        public Partie()
        {
            
        }

        public List<Joueur> Liste_Joueur { get => liste_Joueur; set => liste_Joueur = value; }
        public int Argent_depart { get => argent_depart; set => argent_depart = value; }
        public PaquetCartes Paquet_cartes { get => paquet_cartes; set => paquet_cartes = value; }
        public int Pot { get => pot; set => pot = value; }
        public Carte[] Tapis { get => tapis; set => tapis = value; }
        public int Petite_blind { get => petite_blind; set => petite_blind = value; }
        public int Grande_blind { get => grande_blind; set => grande_blind = value; }
        public String Id { get => id; set => id = value; }


        public void DistribuerJoueur()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Joueur joueur in liste_Joueur)
                {
                    joueur.Main_joueur[i] = paquet_cartes.DistribuerUneCarte();
                }
            }
        }

        public void DistribuerFlop()
        {
            Console.WriteLine("Tapis :");
            for (int i = 0; i < 3; i++)
            {
                Carte carte = paquet_cartes.DistribuerUneCarte();
                tapis[i] = carte;
                Console.WriteLine(tapis[i].Valeur + " " + tapis[i].Couleur);
            }
        }

        public void CreerPartie() { }
        public void RejoindrePartie() { }
        public void SetXML()
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//poker.xml";
            XmlSerializer writer = new XmlSerializer(typeof(Partie));
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }
        public void GetXML() { }
        public void UpdateXML() { }
        public void GetGagnantPartie() { }
        public void DonnerBlinds() { }
        public void APerdu() { }
        public void Suivre(Joueur unJoueur)
        {
 
        }
        public void Miser(Joueur unJoueur, Partie unePartie)
        {
            //récupere la mise du champ input
            //somme des mises
           // mise = +unJoueur.Mise;
            //argent du joueur
            //int argent = unJoueur.Argent - mise;
        }
        public void Checker()
        {

        }
        public void SeCoucher(Joueur unJoueur)
        {
        }
        public void JoueurSuivant(Joueur unJoueur)
        {
            if (unJoueur.Statut == "actif")
            {

            }
        }
        public void FinPartie() { }
        public void AjouterAuPot(Joueur unJoueur, Partie unePartie)
        {
            unePartie.pot = +unJoueur.Mise;
        }
    }
}
