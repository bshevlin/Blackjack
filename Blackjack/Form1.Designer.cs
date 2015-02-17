using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Blackjack
{
    partial class Form1
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
            this.UserPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard6 = new System.Windows.Forms.PictureBox();
            this.UserPlayerCard7 = new System.Windows.Forms.PictureBox();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.playerBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CSBankroll = new System.Windows.Forms.Label();
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.playerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DealerCard2 = new System.Windows.Forms.PictureBox();
            this.DealerCard3 = new System.Windows.Forms.PictureBox();
            this.DealerCard4 = new System.Windows.Forms.PictureBox();
            this.DealerCard5 = new System.Windows.Forms.PictureBox();
            this.DealerCard6 = new System.Windows.Forms.PictureBox();
            this.DealerCard7 = new System.Windows.Forms.PictureBox();
            this.AJCard1 = new System.Windows.Forms.PictureBox();
            this.AJCard2 = new System.Windows.Forms.PictureBox();
            this.AJCard3 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.AJCard4 = new System.Windows.Forms.PictureBox();
            this.AJCard5 = new System.Windows.Forms.PictureBox();
            this.AJCard6 = new System.Windows.Forms.PictureBox();
            this.AJCard7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CSCard1 = new System.Windows.Forms.PictureBox();
            this.CSCard2 = new System.Windows.Forms.PictureBox();
            this.CSCard3 = new System.Windows.Forms.PictureBox();
            this.CSCard4 = new System.Windows.Forms.PictureBox();
            this.CSCard5 = new System.Windows.Forms.PictureBox();
            this.CSCard6 = new System.Windows.Forms.PictureBox();
            this.CSCard7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.AJBankroll = new System.Windows.Forms.Label();
            this.playerBankroll = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.AJText = new System.Windows.Forms.RichTextBox();
            this.playerText = new System.Windows.Forms.RichTextBox();
            this.CSText = new System.Windows.Forms.RichTextBox();
            this.dealerText = new System.Windows.Forms.RichTextBox();
            this.insuranceButton = new System.Windows.Forms.Button();
            this.noInsuranceButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard7)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPlayerCard1
            // 
            this.UserPlayerCard1.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard1.Location = new System.Drawing.Point(223, 505);
            this.UserPlayerCard1.Name = "UserPlayerCard1";
            this.UserPlayerCard1.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard1.TabIndex = 0;
            this.UserPlayerCard1.TabStop = false;
            // 
            // UserPlayerCard2
            // 
            this.UserPlayerCard2.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard2.Location = new System.Drawing.Point(242, 505);
            this.UserPlayerCard2.Name = "UserPlayerCard2";
            this.UserPlayerCard2.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard2.TabIndex = 1;
            this.UserPlayerCard2.TabStop = false;
            // 
            // UserPlayerCard3
            // 
            this.UserPlayerCard3.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard3.Location = new System.Drawing.Point(261, 505);
            this.UserPlayerCard3.Name = "UserPlayerCard3";
            this.UserPlayerCard3.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard3.TabIndex = 2;
            this.UserPlayerCard3.TabStop = false;
            // 
            // UserPlayerCard4
            // 
            this.UserPlayerCard4.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard4.Location = new System.Drawing.Point(281, 505);
            this.UserPlayerCard4.Name = "UserPlayerCard4";
            this.UserPlayerCard4.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard4.TabIndex = 3;
            this.UserPlayerCard4.TabStop = false;
            // 
            // UserPlayerCard5
            // 
            this.UserPlayerCard5.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard5.Location = new System.Drawing.Point(300, 505);
            this.UserPlayerCard5.Name = "UserPlayerCard5";
            this.UserPlayerCard5.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard5.TabIndex = 4;
            this.UserPlayerCard5.TabStop = false;
            // 
            // UserPlayerCard6
            // 
            this.UserPlayerCard6.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard6.Location = new System.Drawing.Point(319, 505);
            this.UserPlayerCard6.Name = "UserPlayerCard6";
            this.UserPlayerCard6.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard6.TabIndex = 5;
            this.UserPlayerCard6.TabStop = false;
            // 
            // UserPlayerCard7
            // 
            this.UserPlayerCard7.Image = global::Blackjack.Properties.Resources.back;
            this.UserPlayerCard7.Location = new System.Drawing.Point(338, 505);
            this.UserPlayerCard7.Name = "UserPlayerCard7";
            this.UserPlayerCard7.Size = new System.Drawing.Size(71, 96);
            this.UserPlayerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPlayerCard7.TabIndex = 6;
            this.UserPlayerCard7.TabStop = false;
            // 
            // hitButton
            // 
            this.hitButton.Enabled = false;
            this.hitButton.Location = new System.Drawing.Point(415, 505);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 50);
            this.hitButton.TabIndex = 7;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.Enabled = false;
            this.stayButton.Location = new System.Drawing.Point(496, 505);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(75, 50);
            this.stayButton.TabIndex = 8;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = true;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Enabled = false;
            this.doubleButton.Location = new System.Drawing.Point(415, 561);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(75, 40);
            this.doubleButton.TabIndex = 9;
            this.doubleButton.Text = "Double Down";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // playerBet
            // 
            this.playerBet.Location = new System.Drawing.Point(117, 505);
            this.playerBet.Name = "playerBet";
            this.playerBet.Size = new System.Drawing.Size(100, 20);
            this.playerBet.TabIndex = 10;
            this.playerBet.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bankroll";
            // 
            // CSBankroll
            // 
            this.CSBankroll.AutoSize = true;
            this.CSBankroll.Location = new System.Drawing.Point(23, 317);
            this.CSBankroll.Name = "CSBankroll";
            this.CSBankroll.Size = new System.Drawing.Size(13, 13);
            this.CSBankroll.TabIndex = 13;
            this.CSBankroll.Text = "0";
            // 
            // DealerCard1
            // 
            this.DealerCard1.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard1.Location = new System.Drawing.Point(389, 13);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(71, 96);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard1.TabIndex = 14;
            this.DealerCard1.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(220, 486);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(36, 13);
            this.playerName.TabIndex = 15;
            this.playerName.Text = "Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dealer";
            // 
            // DealerCard2
            // 
            this.DealerCard2.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard2.Location = new System.Drawing.Point(410, 13);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(71, 96);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard2.TabIndex = 17;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard3.Location = new System.Drawing.Point(439, 13);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(71, 96);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard3.TabIndex = 18;
            this.DealerCard3.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard4.Location = new System.Drawing.Point(466, 13);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(71, 96);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard4.TabIndex = 19;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard5
            // 
            this.DealerCard5.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard5.Location = new System.Drawing.Point(487, 13);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(71, 96);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard5.TabIndex = 20;
            this.DealerCard5.TabStop = false;
            // 
            // DealerCard6
            // 
            this.DealerCard6.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard6.Location = new System.Drawing.Point(516, 13);
            this.DealerCard6.Name = "DealerCard6";
            this.DealerCard6.Size = new System.Drawing.Size(71, 96);
            this.DealerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard6.TabIndex = 21;
            this.DealerCard6.TabStop = false;
            // 
            // DealerCard7
            // 
            this.DealerCard7.Image = global::Blackjack.Properties.Resources.back;
            this.DealerCard7.Location = new System.Drawing.Point(544, 13);
            this.DealerCard7.Name = "DealerCard7";
            this.DealerCard7.Size = new System.Drawing.Size(71, 96);
            this.DealerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DealerCard7.TabIndex = 22;
            this.DealerCard7.TabStop = false;
            // 
            // AJCard1
            // 
            this.AJCard1.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard1.Location = new System.Drawing.Point(698, 505);
            this.AJCard1.Name = "AJCard1";
            this.AJCard1.Size = new System.Drawing.Size(71, 96);
            this.AJCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard1.TabIndex = 23;
            this.AJCard1.TabStop = false;
            // 
            // AJCard2
            // 
            this.AJCard2.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard2.Location = new System.Drawing.Point(719, 505);
            this.AJCard2.Name = "AJCard2";
            this.AJCard2.Size = new System.Drawing.Size(71, 96);
            this.AJCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard2.TabIndex = 24;
            this.AJCard2.TabStop = false;
            // 
            // AJCard3
            // 
            this.AJCard3.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard3.Location = new System.Drawing.Point(742, 505);
            this.AJCard3.Name = "AJCard3";
            this.AJCard3.Size = new System.Drawing.Size(71, 96);
            this.AJCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard3.TabIndex = 25;
            this.AJCard3.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Blackjack.Properties.Resources.back;
            this.pictureBox18.Location = new System.Drawing.Point(654, 13);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(71, 96);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Blackjack.Properties.Resources.back;
            this.pictureBox19.Location = new System.Drawing.Point(664, 13);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(71, 96);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            // 
            // AJCard4
            // 
            this.AJCard4.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard4.Location = new System.Drawing.Point(760, 505);
            this.AJCard4.Name = "AJCard4";
            this.AJCard4.Size = new System.Drawing.Size(71, 96);
            this.AJCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard4.TabIndex = 28;
            this.AJCard4.TabStop = false;
            // 
            // AJCard5
            // 
            this.AJCard5.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard5.Location = new System.Drawing.Point(775, 505);
            this.AJCard5.Name = "AJCard5";
            this.AJCard5.Size = new System.Drawing.Size(71, 96);
            this.AJCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard5.TabIndex = 29;
            this.AJCard5.TabStop = false;
            // 
            // AJCard6
            // 
            this.AJCard6.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard6.Location = new System.Drawing.Point(797, 505);
            this.AJCard6.Name = "AJCard6";
            this.AJCard6.Size = new System.Drawing.Size(71, 96);
            this.AJCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard6.TabIndex = 30;
            this.AJCard6.TabStop = false;
            // 
            // AJCard7
            // 
            this.AJCard7.Image = global::Blackjack.Properties.Resources.back;
            this.AJCard7.Location = new System.Drawing.Point(819, 505);
            this.AJCard7.Name = "AJCard7";
            this.AJCard7.Size = new System.Drawing.Size(71, 96);
            this.AJCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AJCard7.TabIndex = 31;
            this.AJCard7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Average Joe";
            // 
            // CSCard1
            // 
            this.CSCard1.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard1.Location = new System.Drawing.Point(13, 58);
            this.CSCard1.Name = "CSCard1";
            this.CSCard1.Size = new System.Drawing.Size(71, 96);
            this.CSCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard1.TabIndex = 33;
            this.CSCard1.TabStop = false;
            // 
            // CSCard2
            // 
            this.CSCard2.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard2.Location = new System.Drawing.Point(13, 80);
            this.CSCard2.Name = "CSCard2";
            this.CSCard2.Size = new System.Drawing.Size(71, 96);
            this.CSCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard2.TabIndex = 34;
            this.CSCard2.TabStop = false;
            // 
            // CSCard3
            // 
            this.CSCard3.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard3.Location = new System.Drawing.Point(13, 103);
            this.CSCard3.Name = "CSCard3";
            this.CSCard3.Size = new System.Drawing.Size(71, 96);
            this.CSCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard3.TabIndex = 35;
            this.CSCard3.TabStop = false;
            // 
            // CSCard4
            // 
            this.CSCard4.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard4.Location = new System.Drawing.Point(13, 123);
            this.CSCard4.Name = "CSCard4";
            this.CSCard4.Size = new System.Drawing.Size(71, 96);
            this.CSCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard4.TabIndex = 36;
            this.CSCard4.TabStop = false;
            // 
            // CSCard5
            // 
            this.CSCard5.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard5.Location = new System.Drawing.Point(13, 147);
            this.CSCard5.Name = "CSCard5";
            this.CSCard5.Size = new System.Drawing.Size(71, 96);
            this.CSCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard5.TabIndex = 37;
            this.CSCard5.TabStop = false;
            // 
            // CSCard6
            // 
            this.CSCard6.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard6.Location = new System.Drawing.Point(13, 170);
            this.CSCard6.Name = "CSCard6";
            this.CSCard6.Size = new System.Drawing.Size(71, 96);
            this.CSCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard6.TabIndex = 38;
            this.CSCard6.TabStop = false;
            // 
            // CSCard7
            // 
            this.CSCard7.Image = global::Blackjack.Properties.Resources.back;
            this.CSCard7.Location = new System.Drawing.Point(13, 192);
            this.CSCard7.Name = "CSCard7";
            this.CSCard7.Size = new System.Drawing.Size(71, 96);
            this.CSCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSCard7.TabIndex = 39;
            this.CSCard7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Card Shark";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 61);
            this.button4.TabIndex = 41;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Algerian", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(288, 192);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(404, 71);
            this.welcomeLabel.TabIndex = 42;
            this.welcomeLabel.Text = "BLACKJACK";
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.Location = new System.Drawing.Point(277, 293);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(105, 18);
            this.enterNameLabel.TabIndex = 43;
            this.enterNameLabel.Text = "Enter Name";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(280, 317);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(163, 20);
            this.playerNameBox.TabIndex = 44;
            // 
            // AJBankroll
            // 
            this.AJBankroll.AutoSize = true;
            this.AJBankroll.Location = new System.Drawing.Point(832, 485);
            this.AJBankroll.Name = "AJBankroll";
            this.AJBankroll.Size = new System.Drawing.Size(13, 13);
            this.AJBankroll.TabIndex = 45;
            this.AJBankroll.Text = "0";
            // 
            // playerBankroll
            // 
            this.playerBankroll.AutoSize = true;
            this.playerBankroll.Location = new System.Drawing.Point(117, 561);
            this.playerBankroll.Name = "playerBankroll";
            this.playerBankroll.Size = new System.Drawing.Size(13, 13);
            this.playerBankroll.TabIndex = 46;
            this.playerBankroll.Text = "0";
            // 
            // betButton
            // 
            this.betButton.Enabled = false;
            this.betButton.Location = new System.Drawing.Point(26, 505);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(85, 23);
            this.betButton.TabIndex = 47;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(496, 561);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 38);
            this.splitButton.TabIndex = 48;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // AJText
            // 
            this.AJText.Enabled = false;
            this.AJText.Location = new System.Drawing.Point(704, 228);
            this.AJText.Name = "AJText";
            this.AJText.Size = new System.Drawing.Size(200, 254);
            this.AJText.TabIndex = 49;
            this.AJText.Text = "";
            this.AJText.Visible = false;
            // 
            // playerText
            // 
            this.playerText.Enabled = false;
            this.playerText.Location = new System.Drawing.Point(439, 245);
            this.playerText.Name = "playerText";
            this.playerText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.playerText.Size = new System.Drawing.Size(200, 254);
            this.playerText.TabIndex = 50;
            this.playerText.Text = "";
            this.playerText.Visible = false;
            // 
            // CSText
            // 
            this.CSText.Enabled = false;
            this.CSText.Location = new System.Drawing.Point(94, 57);
            this.CSText.Name = "CSText";
            this.CSText.Size = new System.Drawing.Size(200, 254);
            this.CSText.TabIndex = 51;
            this.CSText.Text = "";
            this.CSText.Visible = false;
            // 
            // dealerText
            // 
            this.dealerText.Enabled = false;
            this.dealerText.Location = new System.Drawing.Point(415, 113);
            this.dealerText.Name = "dealerText";
            this.dealerText.Size = new System.Drawing.Size(200, 130);
            this.dealerText.TabIndex = 52;
            this.dealerText.Text = "";
            this.dealerText.Visible = false;
            // 
            // insuranceButton
            // 
            this.insuranceButton.Enabled = false;
            this.insuranceButton.Location = new System.Drawing.Point(26, 534);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(85, 23);
            this.insuranceButton.TabIndex = 53;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // noInsuranceButton
            // 
            this.noInsuranceButton.Enabled = false;
            this.noInsuranceButton.Location = new System.Drawing.Point(26, 563);
            this.noInsuranceButton.Name = "noInsuranceButton";
            this.noInsuranceButton.Size = new System.Drawing.Size(85, 23);
            this.noInsuranceButton.TabIndex = 54;
            this.noInsuranceButton.Text = "No Insurance";
            this.noInsuranceButton.UseVisualStyleBackColor = true;
            this.noInsuranceButton.Click += new System.EventHandler(this.noInsuranceButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(280, 353);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 55;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hi-Lo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(280, 376);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 56;
            this.radioButton2.Text = "Halves";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(280, 399);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 57;
            this.radioButton3.Text = "Zen";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(280, 422);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 58;
            this.radioButton4.Text = "Omega II";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 613);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.noInsuranceButton);
            this.Controls.Add(this.insuranceButton);
            this.Controls.Add(this.AJText);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.playerBankroll);
            this.Controls.Add(this.AJBankroll);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CSCard7);
            this.Controls.Add(this.CSCard6);
            this.Controls.Add(this.CSCard5);
            this.Controls.Add(this.CSCard4);
            this.Controls.Add(this.CSCard3);
            this.Controls.Add(this.CSCard2);
            this.Controls.Add(this.CSCard1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AJCard7);
            this.Controls.Add(this.AJCard6);
            this.Controls.Add(this.AJCard5);
            this.Controls.Add(this.AJCard4);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.AJCard3);
            this.Controls.Add(this.AJCard2);
            this.Controls.Add(this.AJCard1);
            this.Controls.Add(this.DealerCard7);
            this.Controls.Add(this.DealerCard6);
            this.Controls.Add(this.DealerCard5);
            this.Controls.Add(this.DealerCard4);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.CSBankroll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerBet);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.UserPlayerCard7);
            this.Controls.Add(this.UserPlayerCard6);
            this.Controls.Add(this.UserPlayerCard5);
            this.Controls.Add(this.UserPlayerCard4);
            this.Controls.Add(this.UserPlayerCard3);
            this.Controls.Add(this.UserPlayerCard2);
            this.Controls.Add(this.UserPlayerCard1);
            this.Controls.Add(this.playerText);
            this.Controls.Add(this.CSText);
            this.Controls.Add(this.dealerText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPlayerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AJCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSCard7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        PictureBox UserPlayerCard1;
        PictureBox UserPlayerCard2;
        PictureBox UserPlayerCard3;
        PictureBox UserPlayerCard4;
        PictureBox UserPlayerCard5;
        PictureBox UserPlayerCard6;
        PictureBox UserPlayerCard7;
        Button stayButton;
        Button doubleButton;
        TextBox playerBet;
        Label label1;
        Label label2;
        Label CSBankroll;
        PictureBox DealerCard1;
        Label playerName;
        Label label5;
        PictureBox DealerCard2;
        PictureBox DealerCard3;
        PictureBox DealerCard4;
        PictureBox DealerCard5;
        PictureBox DealerCard6;
        PictureBox DealerCard7;
        PictureBox AJCard2;
        PictureBox AJCard3;
        PictureBox AJCard4;
        PictureBox AJCard5;
        PictureBox AJCard6;
        PictureBox AJCard7;
        PictureBox CSCard1;
        PictureBox CSCard2;
        PictureBox CSCard3;
        PictureBox CSCard4;
        PictureBox CSCard5;
        PictureBox CSCard6;
        PictureBox CSCard7;
        PictureBox pictureBox18;
        PictureBox pictureBox19;
        Label label6;
        Label label7;
        Button button4;
        public PictureBox AJCard1;
        private Label enterNameLabel;
        private TextBox playerNameBox;
        public Label AJBankroll;
        private Label playerBankroll;
        private Button betButton;
        private Button splitButton;
        public Button hitButton;
        private RichTextBox AJText;
        private RichTextBox playerText;
        private RichTextBox CSText;
        private RichTextBox dealerText;
        public Button insuranceButton;
        public Button noInsuranceButton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;


    }
}

//TODO:
//add wagers and payouts(1:1 for regular hands, 1.5:1 for blackjacks, 2:1 for insurance), including in the resolve method
//illustrious 18
//finish cardShark's strategy method

//buttons we need:
//name text box
//dropdown menu for counting system
//dropdown menu for numDecks
//start game button

//hit, stand, double down, split
//insurance prompt when relevant (after everyone gets their cards, but before anyone plays)
//wager prompt before starting each new hand

//dispaly for: wagers, bankroll, cards in play