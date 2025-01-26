using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txb_alap.Text = "Max 30 000 lehet az alap tét";
            txb_playercount.Text = "Max 5 játékos lehet";
            txb_alap.ForeColor = System.Drawing.Color.Gray; 
            txb_alap.Enter += TextBox_Enter; 
            txb_alap.Leave += TextBox_Leave;  
            Controls.Add(txb_alap);
            txb_playercount.ForeColor = System.Drawing.Color.Gray;
            txb_playercount.Enter += TextBox_Entere;
            txb_playercount.Leave += TextBox_Leavee;
            Controls.Add(txb_playercount);
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (txb_alap.Text == "Max 30 000 lehet az alap tét" && txb_alap.ForeColor == System.Drawing.Color.Gray)
            {
                txb_alap.Text = ""; 
                txb_alap.ForeColor = System.Drawing.Color.Black;  
            }
        }
        private void TextBox_Entere(object sender, EventArgs e)
        {
            if (txb_playercount.Text == "Max 5 játékos lehet" && txb_playercount.ForeColor == System.Drawing.Color.Gray)
            {
                txb_playercount.Text = "";
                txb_playercount.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void TextBox_Leavee(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_playercount.Text))
            {
                txb_playercount.Text = "Max 5 játékos lehet";
                txb_playercount.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_alap.Text))
            {
                txb_alap.Text = "Max 30 000 lehet az alap tét";  
                txb_alap.ForeColor = System.Drawing.Color.Gray;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int jatekossz= 0;
        public int alap= 0;
        private void Playbtn_Click(object sender, EventArgs e)
        {
            try
            {
                jatekossz = int.Parse(txb_playercount.Text);
                alap = int.Parse(txb_alap.Text);
            }
            catch { }
            if (alap <= 30000 && alap >= 1000 && jatekossz > 0 && jatekossz < 6)
            {
                System.Drawing.Point Loc = this.Location;
                Form form2 = new Game(alap, jatekossz,Loc );
                form2.Show();
                
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
