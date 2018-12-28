using Newtonsoft.Json;
using Poker.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace Poker.Vue
{
    public partial class FormRejoindre : Form
    {
        string pseudoJoueur;
        SimpleTcpClient client;
        public FormRejoindre()
        {
            InitializeComponent();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_rejoindre_Click(object sender, EventArgs e)
        {
            client.Connect(txtIp.Text, Convert.ToInt32("8910"));
            button_rejoindre.Enabled = false;

            client.WriteLineAndGetReply("Coucou je suis la", TimeSpan.FromSeconds(3));
            Program.formPartie.Show();

        }

        private void FormRejoindre_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += DataReceived;
        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            Partie partie = new Partie();
            //txtStatus.Invoke((MethodInvoker)delegate ()
            //{
                partie = JsonConvert.DeserializeObject<Partie>(e.MessageString);
                var findPseudo = partie.Liste_Joueur.Find(x => x.Pseudo == pseudoJoueur);

                if (findPseudo==null)
                {
                    pseudoJoueur = textBox_pseudoRejoindre.Text;
                    Joueur joueur = new Joueur();
                    partie = joueur.AjouteJoueur(partie, pseudoJoueur);
                    SendData(partie);
                }
                else
                {
                    partie.Refresh_view(partie);
                }
            //});

            foreach (var joueur in partie.Liste_Joueur)
            {
                Console.WriteLine(joueur.Pseudo);
            }
        }
        

        public void SendData(Partie unePartie)//To the server
        {
            var partieDataString = JsonConvert.SerializeObject(unePartie);
            client.Write(partieDataString);
            Console.WriteLine(partieDataString);
        }
    }
}
