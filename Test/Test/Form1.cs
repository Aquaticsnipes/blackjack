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
    public partial class Game : Form
    {
        CardGroup player;
        CardGroup dealer;
        CardGroup deck;
        public Game()
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
            int handVal;
            tmp = deck.DealTopCard();
            player.AddToDeck(tmp);
            playerDrawnCard.Image = Image.FromFile("../../images/cards/" + tmp.FileName());
            if (player.value > 21)
            {
                player.AceCheck();
                if(player.value > 21)
                {
                    DeckBtn.Enabled = false;
                    playerScore.Text = "Score: " + player.value + " You bust!";
                    DealerTurn();
                }
            }
            else if(player.value == 21)
            {
                DeckBtn.Enabled = false;
                playerScore.Text = "Score: " + player.value;
            }
            else
            {
                playerScore.Text = "Score: " + player.value;
            }
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
            playerScore.Text = "Score: " + player.value;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DealerTurn()
        {
            StayBtn.Enabled = false;
            DeckBtn.Enabled = false;
            dealerCard1.Image = Image.FromFile("../../images/cards/" + dealer.GetCard(0).FileName());
            while (dealer.value < 17 && dealer.value < 22)
            {
                dealer.AddToDeck(deck.DealTopCard());
            }
            
            if(dealer.GetNumCard() > 2)
            {
                dealerDrawnCard.Image = Image.FromFile("../../images/cards/" + dealer.GetCard(dealer.GetNumCard()-1).FileName());
            }
            dealerScore.Text = "Score: " + dealer.value;
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
            if (dealer.value > player.value)
            {
                if(dealer.value < 22)
                {
                    GameOverLabel.Text = "Dealer Wins";
                }
                else if (player.value < 22)
                {
                    GameOverLabel.Text = "You Win!";
                }
                else
                {
                    GameOverLabel.Text = "It's A Push";
                }
                
            }
            else if (dealer.value < player.value)
            {
                if (player.value < 22)
                {
                    GameOverLabel.Text = "You Win!";
                }
                else if (dealer.value < 22)
                {
                    GameOverLabel.Text = "Dealer Wins";
                }
                else
                {
                    GameOverLabel.Text = "It's A Push";
                }
            }
            else if (dealer.value == player.value)
            {
                GameOverLabel.Text = "It's A Push";
            }
            else{
                GameOverLabel.Text = "Not sure what case this would be";
            }
        }
    }
}
