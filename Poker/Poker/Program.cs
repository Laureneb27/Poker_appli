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
            partie.DistribuerRiver();
            partie.DistribuerTapis();

            Console.WriteLine("Tapis");
            
            for (int i = 0; i < partie.Tapis.Length; i++)
            {
                Console.WriteLine(partie.Tapis[i].Valeur + " " + partie.Tapis[i].Couleur);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Joueur unGagnant = partie.RecupererGagnantPartie(partie);
            Console.WriteLine(unGagnant.Pseudo);
            Combinaison combiGagnant = Combinaison.Recuperer(partie, unGagnant);
            Console.WriteLine(combiGagnant.Nom);
            Console.WriteLine("De valeur : "+combiGagnant.ValeurMain);


            //partie.SetXML();


            Carte[] cartes = new Carte[7];

            String nom= " ";
            int valeur = 0;
            int valeurMain = 0;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPartie());
        }        
    }
}
