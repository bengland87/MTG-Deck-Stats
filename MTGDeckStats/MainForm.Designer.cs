namespace MTGDeckStats
{
    partial class MainForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblMatchWin = new System.Windows.Forms.Label();
            this.lblMatchTie = new System.Windows.Forms.Label();
            this.lblMatchLose = new System.Windows.Forms.Label();
            this.lblMatchMull = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.lblGameWin = new System.Windows.Forms.Label();
            this.lblGameTie = new System.Windows.Forms.Label();
            this.lblGameLose = new System.Windows.Forms.Label();
            this.lblGameMull = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMWins = new System.Windows.Forms.TextBox();
            this.txtMTies = new System.Windows.Forms.TextBox();
            this.txtMLosses = new System.Windows.Forms.TextBox();
            this.txtGWins = new System.Windows.Forms.TextBox();
            this.txtGLosses = new System.Windows.Forms.TextBox();
            this.txtMulligans = new System.Windows.Forms.TextBox();
            this.txtGTies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Deck";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Deck";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Location = new System.Drawing.Point(485, 42);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDeck.TabIndex = 2;
            this.btnDeleteDeck.Text = "Delete Deck";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            this.btnDeleteDeck.Click += new System.EventHandler(this.btnDeleteDeck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Match Win %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Match Tie %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Match Lose %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avg Muligans Per Match";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Games Played";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Game Win %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Game Tie %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Game Lose %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Matches Played";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Avg Muligans Per Game";
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(156, 18);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(0, 13);
            this.lblMatches.TabIndex = 15;
            // 
            // lblMatchWin
            // 
            this.lblMatchWin.AutoSize = true;
            this.lblMatchWin.Location = new System.Drawing.Point(156, 43);
            this.lblMatchWin.Name = "lblMatchWin";
            this.lblMatchWin.Size = new System.Drawing.Size(0, 13);
            this.lblMatchWin.TabIndex = 16;
            // 
            // lblMatchTie
            // 
            this.lblMatchTie.AutoSize = true;
            this.lblMatchTie.Location = new System.Drawing.Point(156, 68);
            this.lblMatchTie.Name = "lblMatchTie";
            this.lblMatchTie.Size = new System.Drawing.Size(0, 13);
            this.lblMatchTie.TabIndex = 17;
            // 
            // lblMatchLose
            // 
            this.lblMatchLose.AutoSize = true;
            this.lblMatchLose.Location = new System.Drawing.Point(156, 93);
            this.lblMatchLose.Name = "lblMatchLose";
            this.lblMatchLose.Size = new System.Drawing.Size(0, 13);
            this.lblMatchLose.TabIndex = 18;
            // 
            // lblMatchMull
            // 
            this.lblMatchMull.AutoSize = true;
            this.lblMatchMull.Location = new System.Drawing.Point(156, 118);
            this.lblMatchMull.Name = "lblMatchMull";
            this.lblMatchMull.Size = new System.Drawing.Size(0, 13);
            this.lblMatchMull.TabIndex = 19;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(156, 158);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(0, 13);
            this.lblGames.TabIndex = 20;
            // 
            // lblGameWin
            // 
            this.lblGameWin.AutoSize = true;
            this.lblGameWin.Location = new System.Drawing.Point(156, 183);
            this.lblGameWin.Name = "lblGameWin";
            this.lblGameWin.Size = new System.Drawing.Size(0, 13);
            this.lblGameWin.TabIndex = 21;
            // 
            // lblGameTie
            // 
            this.lblGameTie.AutoSize = true;
            this.lblGameTie.Location = new System.Drawing.Point(156, 208);
            this.lblGameTie.Name = "lblGameTie";
            this.lblGameTie.Size = new System.Drawing.Size(0, 13);
            this.lblGameTie.TabIndex = 22;
            // 
            // lblGameLose
            // 
            this.lblGameLose.AutoSize = true;
            this.lblGameLose.Location = new System.Drawing.Point(156, 233);
            this.lblGameLose.Name = "lblGameLose";
            this.lblGameLose.Size = new System.Drawing.Size(0, 13);
            this.lblGameLose.TabIndex = 23;
            // 
            // lblGameMull
            // 
            this.lblGameMull.AutoSize = true;
            this.lblGameMull.Location = new System.Drawing.Point(156, 258);
            this.lblGameMull.Name = "lblGameMull";
            this.lblGameMull.Size = new System.Drawing.Size(0, 13);
            this.lblGameMull.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Update Stats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Clear Stats";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMWins
            // 
            this.txtMWins.Location = new System.Drawing.Point(155, 49);
            this.txtMWins.Name = "txtMWins";
            this.txtMWins.Size = new System.Drawing.Size(42, 20);
            this.txtMWins.TabIndex = 3;
            // 
            // txtMTies
            // 
            this.txtMTies.Location = new System.Drawing.Point(155, 75);
            this.txtMTies.Name = "txtMTies";
            this.txtMTies.Size = new System.Drawing.Size(42, 20);
            this.txtMTies.TabIndex = 4;
            // 
            // txtMLosses
            // 
            this.txtMLosses.Location = new System.Drawing.Point(155, 101);
            this.txtMLosses.Name = "txtMLosses";
            this.txtMLosses.Size = new System.Drawing.Size(42, 20);
            this.txtMLosses.TabIndex = 5;
            // 
            // txtGWins
            // 
            this.txtGWins.Location = new System.Drawing.Point(155, 131);
            this.txtGWins.Name = "txtGWins";
            this.txtGWins.Size = new System.Drawing.Size(42, 20);
            this.txtGWins.TabIndex = 6;
            // 
            // txtGLosses
            // 
            this.txtGLosses.Location = new System.Drawing.Point(155, 183);
            this.txtGLosses.Name = "txtGLosses";
            this.txtGLosses.Size = new System.Drawing.Size(42, 20);
            this.txtGLosses.TabIndex = 8;
            // 
            // txtMulligans
            // 
            this.txtMulligans.Location = new System.Drawing.Point(155, 214);
            this.txtMulligans.Name = "txtMulligans";
            this.txtMulligans.Size = new System.Drawing.Size(42, 20);
            this.txtMulligans.TabIndex = 9;
            // 
            // txtGTies
            // 
            this.txtGTies.Location = new System.Drawing.Point(155, 157);
            this.txtGTies.Name = "txtGTies";
            this.txtGTies.Size = new System.Drawing.Size(42, 20);
            this.txtGTies.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "New Match Wins";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "New Match Ties";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "New Match Losses";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "New Game Wins";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "New Game Ties";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "New Game Losses";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "New Mulligans";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtMWins);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtMTies);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMLosses);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtGWins);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtGLosses);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMulligans);
            this.panel1.Controls.Add(this.txtGTies);
            this.panel1.Location = new System.Drawing.Point(337, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 286);
            this.panel1.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(41, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Update Deck Statistics";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblGameMull);
            this.panel2.Controls.Add(this.lblGameLose);
            this.panel2.Controls.Add(this.lblGameTie);
            this.panel2.Controls.Add(this.lblGameWin);
            this.panel2.Controls.Add(this.lblGames);
            this.panel2.Controls.Add(this.lblMatchMull);
            this.panel2.Controls.Add(this.lblMatchLose);
            this.panel2.Controls.Add(this.lblMatchTie);
            this.panel2.Controls.Add(this.lblMatchWin);
            this.panel2.Controls.Add(this.lblMatches);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 286);
            this.panel2.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 386);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(397, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Help me produce more apps and upgrade exisiting features by donating via Paypal:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=R6CPUL2YTR55" +
    "6";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 434);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteDeck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "MTG Deck Stats";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteDeck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblMatchWin;
        private System.Windows.Forms.Label lblMatchTie;
        private System.Windows.Forms.Label lblMatchLose;
        private System.Windows.Forms.Label lblMatchMull;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblGameWin;
        private System.Windows.Forms.Label lblGameTie;
        private System.Windows.Forms.Label lblGameLose;
        private System.Windows.Forms.Label lblGameMull;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMWins;
        private System.Windows.Forms.TextBox txtMTies;
        private System.Windows.Forms.TextBox txtMLosses;
        private System.Windows.Forms.TextBox txtGWins;
        private System.Windows.Forms.TextBox txtGLosses;
        private System.Windows.Forms.TextBox txtMulligans;
        private System.Windows.Forms.TextBox txtGTies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
    }
}

