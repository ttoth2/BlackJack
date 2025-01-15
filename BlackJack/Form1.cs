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
            this.StartPosition = FormStartPosition.CenterScreen;
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

            Form form2 = new Game();
            form2.Show();
            form2.Location = this.Location;
            Hide();
 
        }

        private void blackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
