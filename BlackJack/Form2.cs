﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BlackJack.blackjack;
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
            public bool flag { get; set; }
            public List<Kartya> lap { get; set; }
        }


        public List<Kartya> oszto = new List<Kartya>();
        public List<Kartya> pakk = new List<Kartya>();
        public List<jatekos> jatekosok = new List<jatekos>();
        public int jatekosszam = 0;
        public int alap = 0;
        public int check = 0;
        public List<PictureBox> picture = new List<PictureBox>();
        public List<PictureBox> picture2 = new List<PictureBox>();
        RadioButton[] radio = new RadioButton[5];
        TextBox[] txbp = new TextBox[5];
        TextBox t = new TextBox();
        Label t2 = new Label();
        Button t3 = new Button();
        System.Drawing.Point loc = new System.Drawing.Point();
        public Game(int a, int b, System.Drawing.Point l)
        {
            InitializeComponent();
            loc = l;
            alap = a;
            jatekosszam = b;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Location = loc;
            var bj = new blackjack();
            txbpp.Text = "0";
            txbop.Text = "0";
            txbtet.Text = "0";
            for (int i = 0; i < jatekosszam; i++)
            {
                jatekosok.Add(new jatekos { szam = i.ToString(), tet = 0, lap = new List<Kartya>(), flag = false, össz = alap });
                radio[i] = new RadioButton();
                radio[i].Name = i.ToString();
                radio[i].Location = new Point(920, 30 + i * 40);
                radio[i].Text = $"{(i + 1).ToString()}.játékos";
                radio[i].CheckedChanged += r_Checked;
                Controls.Add(radio[i]);
            }
            t2 = new Label();
            t3 = new Button();
            t = new TextBox();
           
            t.Size = new Size(200, 40);
            t2.Size = new Size(200, 30);
            t3.Size = new Size(200, 40);

            t.Location = new Point(400, 300);
            t2.Location = new Point(400, 260);
            t3.Location = new Point(400, 340);

            t3.Click += t_Click;
            t3.Text = "tét megadása";
            Controls.Add(t);
            Controls.Add(t2);
            Controls.Add(t3);

            radio[0].Checked = true;

            txbossz.Text = jatekosok[check].össz.ToString();
            tetek();


        }
        public void tetek()
        {
            t2.Text = $" Kérem adjon meg egy tétet! (max {jatekosok[check].össz})";

            t.Text = "0";
            t.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
        }

        public List<Kartya> Pakli()
        {
            Random rand = new Random();
            List<Kartya> kartyak = new List<Kartya>();

            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            for (int a = 0; a < 2; a++)
            {
                int szam = 1;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < ranks.Length; j++)
                    {
                        szam++;
                        kartyak.Add(new Kartya { Rang = ranks[j], Ert = values[j], id = szam, lat = false });
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



        public int megszam(List<Kartya> a)
        {
            int valasz = 0;
            foreach(Kartya k in a)
            {
                if (k.Rang == "Ace")
                {
                    if (valasz >= 11)
                    {
                        valasz++;
                    }
                    else 
                    { valasz += k.Ert; }
                }
                else { valasz += k.Ert; }
            }
            return valasz;
        }
        public Kartya pluszK()
        {
            Kartya temp = pakk[0];
            pakk.RemoveAt(0);
            return temp;
        }
        private void oszt()
        {

            oszto.Add(pluszK());
            picture.Clear();
            for (int i = 0; i < oszto.Count; i++)
            {
                picture.Add(new PictureBox());
                picture[i].Size = new Size(140, 220);
                picture[i].SizeMode = PictureBoxSizeMode.StretchImage;
                if (i == 0)
                {
                    picture[i].Image = Image.FromFile(@"..\..\kartya\1.png");
                }
                else
                {
                    picture[i].Image = Image.FromFile($"..\\..\\kartya\\{oszto[i].id}.png");
                }
                picture[i].Location = new Point(310+i*50, 35);
                Controls.Add(picture[i]);
                picture[i].BringToFront();
            }
            for (int i = 0; i < jatekosszam; i++)
            {
                if (radio[i].Enabled)
                {
                    jatekosok[i].lap.Add(pluszK());
                    jatekosok[i].lap.Add(pluszK());
                }  
            }
            mutat();
        }

        private void mutat()
        {
            picture2.Clear();
            for (int i = 0; i < jatekosok[check].lap.Count; i++)
            {
                picture2.Add(new PictureBox());
                picture2[i].Size = new Size(140, 220);
                picture2[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picture2[i].Image = Image.FromFile($"..\\..\\kartya\\{jatekosok[check].lap[i].id}.png");
                picture2[i].Location = new Point(310 + i * 50, 310);
                Controls.Add(picture2[i]);
                picture2[i].BringToFront();
            }
        }

        private void r_Checked(object sender, EventArgs e)
        {
            for (int i = 0; i < jatekosszam; i++ )
            {
                if (radio[i].Checked)
                {
                    check = i; break;
                    
                }
            }
            txbtet.Text = jatekosok[check].tet.ToString();
            txbossz.Text = jatekosok[check].össz.ToString();
            try
            {
                mutat();
            }
            catch (Exception ex) { }
        }
        private void t_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(t.Text) <= jatekosok[check].össz && int.Parse(t.Text) > 0)
                {
                   
                   
                    jatekosok[check].össz -= int.Parse(t.Text);
                    jatekosok[check].tet = int.Parse(t.Text);
                    if (jatekosszam != 1)
                    {
                        if (check == jatekosszam - 1)
                        {
                            txbtet.Text = jatekosok[check].tet.ToString();
                            txbossz.Text = jatekosok[check].össz.ToString();
                        
                            radio[check].Checked = false;
                            radio[0].Checked = true;        
                            
                            t.Text = "0";
                            t2.Text = $" Kérem adjon meg egy tétet! ({jatekosok[check].össz} - 0)";
                            t.Visible = false;
                            t2.Visible = false;
                            t3.Visible = false;
                            pakk = Pakli();
                            oszto.Add(pluszK());
                            oszt();
                        }
                        else
                        {
                            txbtet.Text = jatekosok[check+1].tet.ToString();
                            txbossz.Text = jatekosok[check+1].össz.ToString();
                            radio[check].Checked = false;
                            radio[check + 1].Checked = true;
                            
                        }
                    } 
                    else 
                    { 
                        txbtet.Text =  jatekosok[check].tet.ToString();
                        txbossz.Text = jatekosok[check].össz.ToString();
                        t.Text = "0";
                        t.Visible = false;
                        t2.Text = $" Kérem adjon meg egy tétet! ({jatekosok[check].össz} - 0)";
                        t2.Visible = false;
                        t3.Visible = false;
                        pakk = Pakli();
                        oszto.Add(pluszK());
                        oszt() ;
                    }
                }else MessageBox.Show("nem megfelelő tét");
            }
            catch (Exception ex) { MessageBox.Show("nem megfelelő "); }  
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnhit_Click(object sender, EventArgs e)
        {
            jatekosok[check].lap.Add(pluszK());
            if (megszam(jatekosok[check].lap) > 21)
            {
                veszt();
            } 
            
            picture2.Add(new PictureBox());
            picture2[picture2.Count-1].Size = new Size(140, 220);
            picture2[picture2.Count - 1].SizeMode = PictureBoxSizeMode.StretchImage;
            picture2[picture2.Count - 1].Image = Image.FromFile($"{jatekosok[check].lap[picture2.Count - 1].id}.png");
            picture2[picture2.Count - 1].Location = new Point(430+ (picture2.Count - 3)* 20, 340);
            Controls.Add(picture2[picture2.Count - 1]);
        }

        public void veszt()
        {
            jatekosok[check].flag = true;
            jatekosok[check].tet = 0;
        }
        public void dönt()
        {

        }
        public void nyer()
        {

        }

        private void btnstand_Click(object sender, EventArgs e)
        {
            jatekosok[check].flag = true;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }
    }
}
