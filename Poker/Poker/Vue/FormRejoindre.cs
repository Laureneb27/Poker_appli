using Poker.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            pseudoJoueur = textBox_pseudoRejoindre.Text;
            List<Joueur> joueurs = new List<Joueur>();
            joueurs.Add(new Joueur(pseudoJoueur, "", "bigBlind", 0, 0, 0));
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

            });
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
