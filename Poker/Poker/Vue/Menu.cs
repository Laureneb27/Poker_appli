﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_creer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreation formCreation = new FormCreation();
            formCreation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRejoindre formRejoindre = new FormRejoindre();
            formRejoindre.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Program.formPartie = new FormPartie();
        }
    }
}
