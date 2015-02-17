using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Card
    {
        int ID;
        int suitID;
        int value;
        string face;
        string suit;
        static Random r = new Random();

        public Card(int val)
        {
            this.ID = val % 13 + 1;
            this.suitID = val / 13;

            if (ID > 10)
                this.value = 10;

            else
                this.value = this.ID;

            switch (this.ID)
            {
                case 1: this.face = "ace";
                    break;
                case 2: this.face = "two";
                    break;
                case 3: this.face = "three";
                    break;
                case 4: this.face = "four";
                    break;
                case 5: this.face = "five";
                    break;
                case 6: this.face = "six";
                    break;
                case 7: this.face = "seven";
                    break;
                case 8: this.face = "eight";
                    break;
                case 9: this.face = "nine";
                    break;
                case 10: this.face = "ten";
                    break;
                case 11: face = "jack";
                    break;
                case 12: face = "queen";
                    break;
                case 13: face = "king";
                    break;

            }
            //Spades : 1 - 13, Clubs: 14 - 26, Diamonds: 27 - 39, Hearts: 40 - 52

            switch (this.suitID)
            {
                case 1: this.suit = "spades";
                    break;
                case 2: this.suit = "clubs";
                    break;
                case 3: this.suit = "diamonds";
                    break;
                case 4: this.suit = "hearts";
                    break;
            }

        }

        public class Deck
        {
            Card[] deck = new Card[52];
            int currentCard = 0;
            public Dealer dealer;

            public Deck(Dealer dealer)
            {
                for (int i = 0; i < 52; i++)
                    this.deck[i] = new Card(i);

                this.dealer = dealer;
            }

            public void Shuffle()
            {
                for (int n = this.deck.Length - 1; n > 0; --n)
                {
                    int k = r.Next(n + 1);
                    Card temp = this.deck[n];
                    this.deck[n] = this.deck[k];
                    this.deck[k] = temp;
                }
            }

            public Card Deal()
            {
                currentCard++;
                return deck[currentCard - 1];
            }
        }

        public class Hand
        {
            Deck deck;
            public Card[] cards = new Card[22];//hands can theoretically have up to 22 cards if they are all aces.
            int total;
            public Boolean soft;

            public Hand(Deck deck)
            {
                this.deck = deck;

                for (int i = 0; i < 2; i++)
                    cards[i] = this.deck.Deal();

                updateTotal();

            }

            //checks if an ace is in the hand
            private Boolean hasAce()
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    if (cards[i].value == 1)
                    {
                        return true;
                    }
                }
                return false;
            }

            //Alternate constructor for the case of a split
            public Hand(Deck deck, Card card)
            {
                this.deck = deck;
                this.cards[0] = card;
                cards[1] = this.deck.Deal();
                updateTotal();

            }

            public void updateTotal()
            {

                int value = 0;
                for (int i = 0; i < cards.Length; i++)
                    value += cards[i].value;


                if (value <= 11 && hasAce())
                {
                    soft = true;
                    value += 10;
                }

                total = value;

            }

            public int getTotal()
            {
                return total;
            }


        }

        public class Table
        {
            Player cardShark;
            Player basicJoe;
            Player you;
            Player dealer;
            Deck deck;


            public Table(int numPlayers)
            {
                deck = new Deck();
                dealer = new Dealer(deck);
                cardShark = new CardShark(deck);
                basicJoe = new BasicJoe(deck);
                you = new UserPlayer(deck);


            }

        }

    }
}
