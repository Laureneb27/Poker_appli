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


            Console.WriteLine(textBox_pseudoRejoindre.Text + " c'est connecte");

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

        public void serialize()
        {
            Partie partie = new Partie();
            File file = new File("temp.dat");
            Stream stream = file.Open(FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, partie);
            stream.Close();
        }

        public void DeSerialize()
        {
            Partie partie = new Partie();
            File file = new File("temp.dat");
            Stream stream = file.Open(FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            partie = (Partie)binary.Deserialize(stream);
            foreach (var joueur in partie.Liste_Joueur)
            {
                Console.WriteLine(joueur.Pseudo);
            }
            stream.Close();
        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                //txtStatus.Text += e.MessageString;
                
                
                DeSerialize();
            });
        }
    }
}
