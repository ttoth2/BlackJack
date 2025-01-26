namespace BlackJack
{
    partial class blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blackjack));
            this.Playbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_alap = new System.Windows.Forms.TextBox();
            this.txb_playercount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Playbtn
            // 
            this.Playbtn.BackColor = System.Drawing.Color.Transparent;
            this.Playbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbtn.Font = new System.Drawing.Font("NSimSun", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbtn.Location = new System.Drawing.Point(336, 464);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(330, 55);
            this.Playbtn.TabIndex = 0;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("NSimSun", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_alap
            // 
            this.txb_alap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txb_alap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_alap.Location = new System.Drawing.Point(401, 415);
            this.txb_alap.Name = "txb_alap";
            this.txb_alap.Size = new System.Drawing.Size(200, 20);
            this.txb_alap.TabIndex = 2;
            // 
            // txb_playercount
            // 
            this.txb_playercount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txb_playercount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_playercount.Location = new System.Drawing.Point(401, 365);
            this.txb_playercount.Name = "txb_playercount";
            this.txb_playercount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_playercount.Size = new System.Drawing.Size(200, 20);
            this.txb_playercount.TabIndex = 3;
            this.txb_playercount.TextChanged += new System.EventHandler(this.txb_playercount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::BlackJack.Properties.Resources.istockphoto_1218355494_612x612;
            this.label1.Location = new System.Drawing.Point(349, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "BlackJack";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BlackJack.Properties.Resources.fontos_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(222, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 313);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_playercount);
            this.Controls.Add(this.txb_alap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Playbtn);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "blackjack";
            this.Text = "BlackJack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.blackjack_FormClosed);
            this.Load += new System.EventHandler(this.blackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb_alap;
        private System.Windows.Forms.TextBox txb_playercount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

