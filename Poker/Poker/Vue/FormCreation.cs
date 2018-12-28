using Newtonsoft.Json;
using Poker.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Poker.Vue
{
    public partial class FormCreation : Form
    {
        string pseudoJoueur;
        int argentPartie;
        SimpleTcpServer server;
        Partie unePartie;
        public FormCreation()
        {
            InitializeComponent();
        }
        

        private void FormCreation_Load(object sender, EventArgs e)
        {
            try
            {
                Partie xmlPartie = unePartie.GetXML();
                if (xmlPartie != null)
                {
                    numericUpDown_argent.Value = xmlPartie.Argent_depart;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }         


            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceive;
        }

        private void Server_DataReceive(object sender, SimpleTCP.Message e)//Recois du client
        {

            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                Console.WriteLine(e.MessageString);

                try
                {
                    unePartie = JsonConvert.DeserializeObject<Partie>(e.MessageString);
                    foreach (Joueur unJoueur in unePartie.Liste_Joueur)
                    {
                        Console.WriteLine(unJoueur.Pseudo);
                    }
                    unePartie.Refresh_view(unePartie);
                }
                catch (Exception exp)
                {

                    Console.WriteLine(exp.Message);
                }
                finally
                {
                    var partieDataString = JsonConvert.SerializeObject(unePartie);

                    Console.WriteLine("Bien recu");
                    e.Reply(partieDataString); //Envoie la partie a chaque entree de joueur
                    Console.WriteLine(partieDataString);
                }
                txtStatus.Text += "ok";

            });
        }

        private void button_creer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Server starting ..");
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtIp.Text);
            server.Start(ip, Convert.ToInt32("8910"));

            argentPartie = (int)numericUpDown_argent.Value;
            PaquetCartes paquetCartes = new PaquetCartes();
            Carte[] tapis = new Carte[5];
            List<Joueur> joueurs = new List<Joueur>();

            unePartie = new Partie("1", joueurs, argentPartie, paquetCartes, 0, tapis, 5, 10);

            Joueur joueur = new Joueur();
            pseudoJoueur = textBox_pseudo.Text;
            joueur.AjouteJoueur(unePartie, pseudoJoueur);


            Console.WriteLine("pseudoJoueur est " + pseudoJoueur);
            Console.WriteLine("numeriupdown est " + argentPartie);
            //this.Hide();
            //Program.formPartie = new FormPartie();
            Program.formPartie.Show();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown_argent_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
