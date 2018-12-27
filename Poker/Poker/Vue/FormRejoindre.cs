using Poker.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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

            client.WriteLineAndGetReply("Coucou je suis là !", TimeSpan.FromSeconds(3));


            Console.WriteLine(textBox_pseudoRejoindre.Text + " c'est connecté .");

            pseudoJoueur = textBox_pseudoRejoindre.Text;
            List<Joueur> joueurs = new List<Joueur>();
            joueurs.Add(new Joueur(pseudoJoueur, "", "bigBlind", 0, 0, 0));

            FormPartie fp = new FormPartie();
            fp.Show();

        }

        private void FormRejoindre_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += DataReceived;
        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;

                var serializer = new XmlSerializer(typeof(Partie));
                Partie unePartie;

                using (TextReader reader = new StringReader(e.MessageString))
                {
                    unePartie = (Partie)serializer.Deserialize(reader);
                }

                

                foreach (var joueur in unePartie.Liste_Joueur)
                {
                    Console.WriteLine(joueur.Pseudo);
                }
                
            });
        }
    }
}
