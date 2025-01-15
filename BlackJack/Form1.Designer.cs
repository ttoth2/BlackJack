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
            this.Playbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_alap = new System.Windows.Forms.TextBox();
            this.txb_playercount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playbtn
            // 
            this.Playbtn.Location = new System.Drawing.Point(335, 300);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(330, 55);
            this.Playbtn.TabIndex = 0;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = true;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_alap
            // 
            this.txb_alap.Location = new System.Drawing.Point(400, 251);
            this.txb_alap.Name = "txb_alap";
            this.txb_alap.Size = new System.Drawing.Size(200, 20);
            this.txb_alap.TabIndex = 2;
            // 
            // txb_playercount
            // 
            this.txb_playercount.Location = new System.Drawing.Point(400, 215);
            this.txb_playercount.Name = "txb_playercount";
            this.txb_playercount.Size = new System.Drawing.Size(200, 20);
            this.txb_playercount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(349, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "BlackJack";
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_playercount);
            this.Controls.Add(this.txb_alap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Playbtn);
            this.Name = "blackjack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.blackjack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb_alap;
        private System.Windows.Forms.TextBox txb_playercount;
        private System.Windows.Forms.Label label1;
    }
}

