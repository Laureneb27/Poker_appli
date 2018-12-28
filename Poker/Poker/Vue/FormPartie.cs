using Poker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class FormPartie : Form
    {
        public FormPartie()
        {
            InitializeComponent();
        }

        private void button_miser_Click(object sender, EventArgs e)
        {
            //numericUpDown_mise.Value est un decimal, le convertir en int et l'arrondir
            int mise = Convert.ToInt32(Math.Round(numericUpDown_mise.Value, 0));
 
        }

        private void numericUpDown_mise_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button_suivre_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Label label_nom = new Label();
            label_nom.Text = "aaaa";
            label_nom.Top = 50;
            label_nom.Left = 200;
            label_nom.BackColor = Color.Yellow;
            Controls.Add(label_nom);
        }
    }
}
