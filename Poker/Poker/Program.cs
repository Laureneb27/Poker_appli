using Poker.Model;
using Poker.Vue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker
{
    static class Program
    {

        public static FormPartie formPartie;
        public static FormCreation formCreation;
        public static FormRejoindre formRejoindre;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vue.Menu());
            
            Partie partie = formCreation.UnePartie;

            Console.WriteLine(partie.Argent_depart);

            if (partie.Liste_Joueur.Count>=2)
            {
                partie.DistribuerJoueur();
                partie.Refresh_view(partie);
                partie.DistribuerFlop();
            }
            

            //foreach (Joueur joueur in partie.Liste_Joueur)
            //{
            //    Console.WriteLine(joueur.Pseudo);
            //    Console.WriteLine(joueur.Main_joueur[0].Valeur + " " + joueur.Main_joueur[0].Couleur);
            //    Console.WriteLine(joueur.Main_joueur[1].Valeur + " " + joueur.Main_joueur[1].Couleur);
            //}

           

            //partie.SetXML();


            Carte[] cartes = new Carte[7];

            String nom = " ";
            int valeur = 0;
            int valeurMain = 0;


            //Combinaison combi = Combinaison.Recuperer(partie, listeJoueur[0]);
            //Console.WriteLine("joueur : "+listeJoueur[0].Pseudo+" | nom : " + combi.Nom + " | valeur : " + combi.Valeur + " | valeur Main : " + combi.ValeurMain);

            
        }
    }
}
