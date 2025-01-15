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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Form form2 = new blackjack();
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }
    }
}
