using System;
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
        }

        private void blackjack_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            
           new Game().Show();
           Hide();
 
        }
    }
}
