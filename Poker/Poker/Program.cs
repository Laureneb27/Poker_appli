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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vue.FormCreation());
        }        
    }
}
