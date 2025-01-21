using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJack
{
    
 
    public partial class Game : Form
    {
        public class Kartya
        {
            public string Rang { get; set; }

            public int Ert { get; set; }
            public int id { get; set; }
            public bool lat { get; set; }

        }
        public class jatekos
        {
            public string szam { get; set; }
            public int össz { get; set; }
            public int tet { get; set; }
            public List<Kartya> lap { get; set; }
        }
        public List<Kartya> Pakli()
        {
            Random rand = new Random();
            List<Kartya> kartyak = new List<Kartya>();
            
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            int szam = 1;
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < ranks.Length; j++)
                    {
                        szam++;
                        kartyak.Add(new Kartya {  Rang = ranks[j], Ert = values[j],id=szam,  lat = false });
                    }
                }
            }
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < kartyak.Count; i++)
                {
                    int r = rand.Next(0, kartyak.Count);
                    Kartya temp = kartyak[i];
                    kartyak[i] = kartyak[r];
                    kartyak[r] = temp;
                }
            }
            return kartyak;
        }
       


        public List<Kartya> pakk= new List<Kartya>();
        public List<jatekos> jatekosok = new List<jatekos>();
        public int jatekosszam = 0;
        public int alap = 0;

        RadioButton[] radio = new RadioButton[5];
        TextBox[] txbp = new TextBox[5];
        public Game(int a,int b )
        {
            InitializeComponent();
            alap = a;
            jatekosszam = b;
        }

        private void Game_Load(object sender, EventArgs e)
        {

            pakk = Pakli();
            for (int i = 0; i < jatekosszam; i++)
            {
                radio[i] = new RadioButton();
                radio[i].Name = i.ToString();
                radio[i].Location = new Point(920, 30 + i * 40);
                radio[i].Text = $"{(i+1).ToString()}.játékos"; 
                   
                Controls.Add(radio[i]);

                
            }
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

        private void btndouble_Click(object sender, EventArgs e)
        {

        }
    }
}
