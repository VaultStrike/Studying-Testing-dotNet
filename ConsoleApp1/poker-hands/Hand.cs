using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.poker_hands
{
    public class Hand 
    {


        //Hand h = new Hand("8C TS KC 9H 4S"); 
        public Hand(String handString)
        {
            string[] cardStrings = handString.Split(' ');

            for (int i = 0; i < 5; i++)
            {
                string cardString = cardStrings[i];

                
                char valueChar = cardString[0];
                int value;

                
                if (valueChar == 'T')
                    value = 10;
                else if (valueChar == 'J')
                    value = 11;
                else if (valueChar == 'Q')
                    value = 12;
                else if (valueChar == 'K')
                    value = 13;
                else if (valueChar == 'A')
                    value = 14;
                else
                    value = int.Parse(valueChar.ToString());

                // Second character is the suit
                char suitChar = cardString[1];
                Suit suit;

                if (suitChar == 'C')
                    suit = Suit.CLUBS;
                else if (suitChar == 'D')
                    suit = Suit.DIAMONDS;
                else if (suitChar == 'H')
                    suit = Suit.HEARTS;
                else // 'S'
                    suit = Suit.SPADES;

                cards[i] = new Card(value, suit);
            }
        }

        public Hand()
        {



        }

        private Card[] cards = new Card[5];

        public Card[] Cards { get => cards; set => cards = value; }

        public void Sort()
        {
            Array.Sort<Card>(cards);
        }

    }
}
