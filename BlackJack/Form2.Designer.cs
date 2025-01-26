namespace BlackJack
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.quitbtn = new System.Windows.Forms.Button();
            this.btnstand = new System.Windows.Forms.Button();
            this.btnhit = new System.Windows.Forms.Button();
            this.btndouble = new System.Windows.Forms.Button();
            this.txbpp = new System.Windows.Forms.TextBox();
            this.txbop = new System.Windows.Forms.TextBox();
            this.txbtet = new System.Windows.Forms.TextBox();
            this.txbossz = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.Transparent;
            this.quitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbtn.Font = new System.Drawing.Font("NSimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbtn.Location = new System.Drawing.Point(878, 549);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(105, 60);
            this.quitbtn.TabIndex = 0;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // btnstand
            // 
            this.btnstand.BackColor = System.Drawing.Color.Transparent;
            this.btnstand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstand.Font = new System.Drawing.Font("NSimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnstand.Location = new System.Drawing.Point(12, 402);
            this.btnstand.Name = "btnstand";
            this.btnstand.Size = new System.Drawing.Size(135, 50);
            this.btnstand.TabIndex = 1;
            this.btnstand.Text = "STAND";
            this.btnstand.UseVisualStyleBackColor = false;
            this.btnstand.Click += new System.EventHandler(this.btnstand_Click);
            // 
            // btnhit
            // 
            this.btnhit.BackColor = System.Drawing.Color.Transparent;
            this.btnhit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhit.Font = new System.Drawing.Font("NSimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnhit.Location = new System.Drawing.Point(12, 309);
            this.btnhit.Name = "btnhit";
            this.btnhit.Size = new System.Drawing.Size(135, 50);
            this.btnhit.TabIndex = 2;
            this.btnhit.Text = "HIT";
            this.btnhit.UseVisualStyleBackColor = false;
            this.btnhit.Click += new System.EventHandler(this.btnhit_Click);
            // 
            // btndouble
            // 
            this.btndouble.BackColor = System.Drawing.Color.Transparent;
            this.btndouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndouble.Font = new System.Drawing.Font("NSimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndouble.Location = new System.Drawing.Point(12, 210);
            this.btndouble.Name = "btndouble";
            this.btndouble.Size = new System.Drawing.Size(135, 45);
            this.btndouble.TabIndex = 3;
            this.btndouble.Text = "DOUBLE";
            this.btndouble.UseVisualStyleBackColor = false;
            this.btndouble.Click += new System.EventHandler(this.btndouble_Click);
            // 
            // txbpp
            // 
            this.txbpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbpp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbpp.Location = new System.Drawing.Point(681, 391);
            this.txbpp.Name = "txbpp";
            this.txbpp.ReadOnly = true;
            this.txbpp.Size = new System.Drawing.Size(100, 20);
            this.txbpp.TabIndex = 4;
            // 
            // txbop
            // 
            this.txbop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbop.Location = new System.Drawing.Point(681, 96);
            this.txbop.Name = "txbop";
            this.txbop.ReadOnly = true;
            this.txbop.Size = new System.Drawing.Size(97, 20);
            this.txbop.TabIndex = 5;
            // 
            // txbtet
            // 
            this.txbtet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbtet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbtet.Location = new System.Drawing.Point(68, 12);
            this.txbtet.Name = "txbtet";
            this.txbtet.ReadOnly = true;
            this.txbtet.Size = new System.Drawing.Size(110, 20);
            this.txbtet.TabIndex = 6;
            // 
            // txbossz
            // 
            this.txbossz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbossz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbossz.Location = new System.Drawing.Point(671, 586);
            this.txbossz.Name = "txbossz";
            this.txbossz.ReadOnly = true;
            this.txbossz.Size = new System.Drawing.Size(172, 20);
            this.txbossz.TabIndex = 7;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(878, 470);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(105, 56);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.ControlBox = false;
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txbossz);
            this.Controls.Add(this.txbtet);
            this.Controls.Add(this.txbop);
            this.Controls.Add(this.txbpp);
            this.Controls.Add(this.btndouble);
            this.Controls.Add(this.btnhit);
            this.Controls.Add(this.btnstand);
            this.Controls.Add(this.quitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "BlackJack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Button btnstand;
        private System.Windows.Forms.Button btnhit;
        private System.Windows.Forms.Button btndouble;
        private System.Windows.Forms.TextBox txbpp;
        private System.Windows.Forms.TextBox txbop;
        private System.Windows.Forms.TextBox txbtet;
        private System.Windows.Forms.TextBox txbossz;
        private System.Windows.Forms.Button btnnext;
    }
}