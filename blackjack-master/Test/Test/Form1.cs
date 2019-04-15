using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class TestBtn : Form
    {
        CardGroup player;
        CardGroup dealer;
        CardGroup deck;
        public TestBtn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StayBtn.Enabled = false;
        }

        //the deck button
        private void Button1_Click(object sender, EventArgs e)
        {
            Card tmp;
            tmp = deck.DealTopCard();
            player.AddToDeck(tmp);
            playerDrawnCard.Image = Image.FromFile("../../images/cards/" + tmp.FileName());
            int handVal = player.Hand();
            if (handVal > 21)
            {
                DeckBtn.Enabled = false;
                playerScore.Text = "Score: " + handVal + " You bust!";
                DealerTurn();
            }
            else if(handVal == 21)
            {
                DeckBtn.Enabled = false;
                playerScore.Text = "Score: " + handVal;
            }
            else
            {
                playerScore.Text = "Score: " + handVal;
            }
            playerCards.Text = "Current Hand: \n" + player.ToString();
        }

        //player card 2
        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {

        }

        private void DealerDrawnCard_Click(object sender, EventArgs e)
        {

        }

        private void PlayerDrawnCard_Click(object sender, EventArgs e)
        {
           
        }

        private void DealerCard2_Click(object sender, EventArgs e)
        {

        }

        private void DealerCard1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Card tmp;
            player = new CardGroup();
            dealer = new CardGroup();
            deck = new CardGroup();

            StayBtn.Enabled = true;
            DeckBtn.Enabled = true;
            GameOverLabel.Text = "";
            playerScore.Text = "Score: ";
            dealerScore.Text = "Score: ";
            playerCard1.Image = null;
            playerCard2.Image = null;
            playerDrawnCard.Image = null;
            dealerCard1.Image = null;
            dealerCard2.Image = null;
            dealerDrawnCard.Image = null;

            DeckBtn.Enabled = true;

            deck.MakeWholeDeck();
            deck.Shuffle();
            deck.Shuffle();

            tmp = deck.DealTopCard();
            player.AddToDeck(tmp);
            Console.WriteLine(Environment.CurrentDirectory);
            playerCard1.Image = Image.FromFile("../../images/cards/" + tmp.FileName());
            tmp = deck.DealTopCard();
            player.AddToDeck(tmp);
            playerCard2.Image = Image.FromFile("../../images/cards/" + tmp.FileName());
            tmp = deck.DealTopCard();
            dealer.AddToDeck(tmp);
            dealerCard1.Image = Image.FromFile("../../images/cards/Back.gif");
            tmp = deck.DealTopCard();
            dealer.AddToDeck(tmp);
            dealerCard2.Image = Image.FromFile("../../images/cards/" + tmp.FileName());
            playerScore.Text = "Score: " + player.Hand();
            playerCards.Text = "Current Hand: \n" + player.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DealerTurn()
        {
            StayBtn.Enabled = false;
            DeckBtn.Enabled = false;
            dealerCard1.Image = Image.FromFile("../../images/cards/" + dealer.GetCard(0).FileName());
            while (dealer.Hand() < 17 && dealer.Hand() < 22)
            {
                dealer.AddToDeck(deck.DealTopCard());
            }
            
            if(dealer.GetNumCard() > 2)
            {
                dealerDrawnCard.Image = Image.FromFile("../../images/cards/" + dealer.GetCard(dealer.GetNumCard()-1).FileName());
            }
            dealerScore.Text = "Score: " + dealer.Hand();
            dealerCards.Text = "Current Hand: \n" + dealer.ToString();
            RoundOver();
            }

        private void StayBtn_Click(object sender, EventArgs e)
        {
            DealerTurn();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RoundOver()
        {
            int dHand = dealer.Hand();
            int pHand = player.Hand();
            if (dHand > pHand)
            {
                if(dHand< 22)
                {
                    GameOverLabel.Text = "Dealer Wins";
                }
                else if (pHand < 22)
                {
                    GameOverLabel.Text = "You Win!";
                }
                else
                {
                    GameOverLabel.Text = "It's A Push";
                }
                
            }
            else if (dHand < pHand)
            {
                if (pHand < 22)
                {
                    GameOverLabel.Text = "You Win!";
                }
                else if (dHand < 22)
                {
                    GameOverLabel.Text = "Dealer Wins";
                }
                else
                {
                    GameOverLabel.Text = "It's A Push";
                }
            }
            else if (dHand == pHand)
            {
                GameOverLabel.Text = "It's A Push";
            }
            else{
                GameOverLabel.Text = "Not sure what case this would be";
            }
        }

        private void LoadGamePage()
        {
            StayBtn.Visible = true;
            NewGameBtn.Visible = true;
            playerCard1.Visible = true;
            playerCard2.Visible = true;
            playerDrawnCard.Visible = true;
            dealerCard1.Visible = true;
            dealerCard2.Visible = true;
            dealerDrawnCard.Visible = true;
            DeckBtn.Visible = true;
            playerScore.Visible = true;
            dealerScore.Visible = true;
            playerCards.Visible = true;
            dealerCards.Visible = true;
        }

        private void LoadTestPage()
        {
            StayBtn.Visible = false;
            playerCard1.Visible = false;
            playerCard2.Visible = false;
            playerDrawnCard.Visible = false;
            dealerCard1.Visible = false;
            dealerCard2.Visible = false;
            dealerDrawnCard.Visible = false;
            DeckBtn.Visible = false;
            playerScore.Visible = false;
            dealerScore.Visible = false;
            playerCards.Visible = false;
            dealerCards.Visible = false;
            TestDataLabel.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoadTestPage();
            CardGroup testDeck = new CardGroup();

            testDeck.MakeWholeDeck();
            TestDataLabel.Text = "\n\n\n";
            TestDataLabel.Text += testDeck.ToTestOut();
            testDeck.Shuffle();
            TestDataLabel.Text += "\n\n\n";
            TestDataLabel.Text += testDeck.ToTestOut();
            Card tmp = testDeck.DealTopCard();
            testDeck.AddToDeck(tmp);
            TestDataLabel.Text += "\n\n\n";
            TestDataLabel.Text += testDeck.ToTestOut();
            TestDataLabel.BringToFront();
            NewGameBtn.BringToFront();
        }
    }
}
