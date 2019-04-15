namespace Test
{
    partial class TestBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBtn));
            this.DeckBtn = new System.Windows.Forms.Button();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerDrawnCard = new System.Windows.Forms.PictureBox();
            this.dealerDrawnCard = new System.Windows.Forms.PictureBox();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.StayBtn = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.playerCards = new System.Windows.Forms.Label();
            this.dealerCards = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TestDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDrawnCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDrawnCard)).BeginInit();
            this.SuspendLayout();
            // 
            // DeckBtn
            // 
            this.DeckBtn.AutoSize = true;
            this.DeckBtn.Enabled = false;
            this.DeckBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeckBtn.Image")));
            this.DeckBtn.Location = new System.Drawing.Point(220, 204);
            this.DeckBtn.Name = "DeckBtn";
            this.DeckBtn.Size = new System.Drawing.Size(79, 103);
            this.DeckBtn.TabIndex = 0;
            this.DeckBtn.UseVisualStyleBackColor = true;
            this.DeckBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dealerCard1
            // 
            this.dealerCard1.Location = new System.Drawing.Point(334, 11);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(79, 103);
            this.dealerCard1.TabIndex = 1;
            this.dealerCard1.TabStop = false;
            this.dealerCard1.Click += new System.EventHandler(this.DealerCard1_Click);
            // 
            // dealerCard2
            // 
            this.dealerCard2.Location = new System.Drawing.Point(419, 11);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(79, 103);
            this.dealerCard2.TabIndex = 2;
            this.dealerCard2.TabStop = false;
            this.dealerCard2.Click += new System.EventHandler(this.DealerCard2_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.Location = new System.Drawing.Point(419, 428);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(79, 103);
            this.playerCard2.TabIndex = 3;
            this.playerCard2.TabStop = false;
            this.playerCard2.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.Location = new System.Drawing.Point(334, 428);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(79, 103);
            this.playerCard1.TabIndex = 4;
            this.playerCard1.TabStop = false;
            this.playerCard1.Click += new System.EventHandler(this.PlayerCard1_Click);
            // 
            // playerDrawnCard
            // 
            this.playerDrawnCard.Location = new System.Drawing.Point(373, 319);
            this.playerDrawnCard.Name = "playerDrawnCard";
            this.playerDrawnCard.Size = new System.Drawing.Size(79, 103);
            this.playerDrawnCard.TabIndex = 5;
            this.playerDrawnCard.TabStop = false;
            this.playerDrawnCard.Click += new System.EventHandler(this.PlayerDrawnCard_Click);
            // 
            // dealerDrawnCard
            // 
            this.dealerDrawnCard.Location = new System.Drawing.Point(373, 120);
            this.dealerDrawnCard.Name = "dealerDrawnCard";
            this.dealerDrawnCard.Size = new System.Drawing.Size(79, 103);
            this.dealerDrawnCard.TabIndex = 6;
            this.dealerDrawnCard.TabStop = false;
            this.dealerDrawnCard.Click += new System.EventHandler(this.DealerDrawnCard_Click);
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(744, 530);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(79, 23);
            this.NewGameBtn.TabIndex = 7;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // StayBtn
            // 
            this.StayBtn.Location = new System.Drawing.Point(507, 505);
            this.StayBtn.Name = "StayBtn";
            this.StayBtn.Size = new System.Drawing.Size(79, 23);
            this.StayBtn.TabIndex = 8;
            this.StayBtn.Text = "Stay";
            this.StayBtn.UseVisualStyleBackColor = true;
            this.StayBtn.Click += new System.EventHandler(this.StayBtn_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(504, 489);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(41, 13);
            this.playerScore.TabIndex = 9;
            this.playerScore.Text = "Score: ";
            this.playerScore.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Location = new System.Drawing.Point(504, 11);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(41, 13);
            this.dealerScore.TabIndex = 10;
            this.dealerScore.Text = "Score: ";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Location = new System.Drawing.Point(381, 261);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(0, 13);
            this.GameOverLabel.TabIndex = 11;
            this.GameOverLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // playerCards
            // 
            this.playerCards.AutoSize = true;
            this.playerCards.Location = new System.Drawing.Point(217, 428);
            this.playerCards.Name = "playerCards";
            this.playerCards.Size = new System.Drawing.Size(73, 13);
            this.playerCards.TabIndex = 12;
            this.playerCards.Text = "Current Hand:";
            // 
            // dealerCards
            // 
            this.dealerCards.AutoSize = true;
            this.dealerCards.Location = new System.Drawing.Point(217, 11);
            this.dealerCards.Name = "dealerCards";
            this.dealerCards.Size = new System.Drawing.Size(73, 13);
            this.dealerCards.TabIndex = 13;
            this.dealerCards.Text = "Current Hand:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // TestDataLabel
            // 
            this.TestDataLabel.Location = new System.Drawing.Point(12, 11);
            this.TestDataLabel.Name = "TestDataLabel";
            this.TestDataLabel.Size = new System.Drawing.Size(486, 516);
            this.TestDataLabel.TabIndex = 15;
            this.TestDataLabel.Text = "Test Data:";
            this.TestDataLabel.Visible = false;
            // 
            // TestBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.TestDataLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dealerCards);
            this.Controls.Add(this.playerCards);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.StayBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.dealerDrawnCard);
            this.Controls.Add(this.playerDrawnCard);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.DeckBtn);
            this.Name = "TestBtn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDrawnCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDrawnCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeckBtn;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerDrawnCard;
        private System.Windows.Forms.PictureBox dealerDrawnCard;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button StayBtn;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label playerCards;
        private System.Windows.Forms.Label dealerCards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TestDataLabel;
    }
}

