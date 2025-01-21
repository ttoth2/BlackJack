﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class blackjack : Form
    {

        public blackjack()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
      
        }

        private void blackjack_Load(object sender, EventArgs e)
        {
            txb_alap.Text = "1000";
            txb_playercount.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int jatekos= 0;
        public int alap= 0;
        private void Playbtn_Click(object sender, EventArgs e)
        {
            try
            {
                jatekos = int.Parse(txb_playercount.Text);
                alap = int.Parse(txb_alap.Text);
            }
            catch { }
            if (alap <= 30000 && alap >= 1000 && jatekos > 0 && jatekos < 6)
            {
                Form form2 = new Game(alap,jatekos);
                form2.Show();
                form2.Location = this.Location;
                Hide();
            }
            else MessageBox.Show("nem megfelelő adatok");
            
    
        }

        private void blackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txb_playercount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
