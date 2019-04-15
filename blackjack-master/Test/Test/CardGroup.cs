using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class CardGroup
    {
        Card[] deck;
        int numCards;
        public CardGroup()
        {
            numCards = 0;
            deck = new Card[52];
        }

        private void SetNumCard(int n)
        {
            numCards = n;
        }

        public int GetNumCard()
        {
            return numCards;
        }

        public Card GetCard(int i)
        {
            return deck[i];
        }

        public void SetCard(int i, Card c)
        {
            deck[i] = c;
        }

        public void AddToDeck(Card c)
        {
            deck[numCards] = c;
            numCards++;
            Hand();
        }

        public void MakeWholeDeck()
        {
            String[] suits = new String[] { "Hearts", "Spades", "Clubs", "Diamonds" };
            String[] values = new String[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            deck = new Card[52];
            numCards = 0;

            foreach(String s in suits)
            {
                foreach(String val in values)
                {
                    AddToDeck(new Card(val, s));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i > 0; --i)
            {
                int j = rand.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public Card DealTopCard()
        {
            Card c = deck[numCards - 1];
            deck[numCards - 1] = null;
            numCards--;
            return c;
        }

        public override string ToString()
        {
            String tmp = "";
            foreach(Card c in deck)
            {
                if (c != null)
                {
                    tmp += c.ToString() + "\n";
                }
            }
            return tmp;
        }

        public string ToTestOut()
        {
            int count = 1;
            String tmp = "";
            foreach (Card c in deck)
            {
                if (c != null)
                {
                    tmp += c.ToString() + ", ";
                    count++;
                }
                if (count % 6 == 0)
                {
                    tmp += "\n";
                }
            }
            return tmp;
        }

        public int Hand()
        {
            int value = 0;
            foreach(Card c in deck)
            {
                if(c != null)
                {
                    value += c.GetValue();
                }
            }
            
            if(value > 21){
                foreach (Card c in deck)
                {
                    if (c != null && c.ToString().Contains("Ace"))
                    {
                        value -= 10;
                    }
                }
            }
            
            return value;
        }
    }
}
