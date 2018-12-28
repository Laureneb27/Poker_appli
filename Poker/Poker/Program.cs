using Poker.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Joueur> listeJoueur = new List<Joueur>
            {
                new Joueur("Laurene", "","",500,0,0),
                new Joueur("Sergio", "","",500,0,0),
                new Joueur("Willy", "","",500,0,0)
            };
            PaquetCartes paquetCartes = new PaquetCartes();
            Carte[] tapis = new Carte[5];

            Partie partie = new Partie("1", listeJoueur, 500, paquetCartes, 0, tapis, 5, 10);
            partie.DistribuerJoueur();
            

            foreach (Joueur joueur in partie.Liste_Joueur)
            {
                Console.WriteLine(joueur.Pseudo);
                Console.WriteLine(joueur.Main_joueur[0].Valeur + " " + joueur.Main_joueur[0].Couleur);
                Console.WriteLine(joueur.Main_joueur[1].Valeur + " " + joueur.Main_joueur[1].Couleur);
            }
            
            partie.DistribuerFlop();

            //partie.SetXML();


            Carte[] cartes = new Carte[7];

            String nom= " ";
            int valeur = 0;
            int valeurMain = 0;
            
            
            //Combinaison combi = Combinaison.Recuperer(partie, listeJoueur[0]);
            //Console.WriteLine("joueur : "+listeJoueur[0].Pseudo+" | nom : " + combi.Nom + " | valeur : " + combi.Valeur + " | valeur Main : " + combi.ValeurMain);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vue.Menu());
        }        
    }
}
