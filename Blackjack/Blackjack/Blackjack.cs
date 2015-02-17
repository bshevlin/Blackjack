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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Table table = new Table();

            
        }
    }

    public class Card
    {
        public int ID;
        public int suitID;
        public int value;
        public string face;
        public string suit;
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

        

    }
    public class Deck
    {
        static Random r = new Random();
        Card[] deck = new Card[52];
        int currentCard = 0;
        public Dealer dealer;

        public Deck()
        {
            for (int i = 0; i < 52; i++)
                this.deck[i] = new Card(i);

            this.dealer = new Dealer(this);
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


        public Table()
        {
            deck = new Deck();
            dealer = deck.dealer;
            cardShark = new CardShark(deck);
            basicJoe = new BasicJoe(deck);
            you = new UserPlayer(deck);


        }

    }

    public abstract class Player
    {
        protected Deck deck;
        public List<Hand> handList = new List<Hand>();
        //public Hand hand;
        public int bankroll;
        protected int numSplits;
        //Key: 1: hit, 2: Stand, 3: Double Down, 4: Split

        //State Space for Normal Hands
        protected int[,] normalStrat = new int[,] {
           //Order is 2 - Ace for dealer's card
            {1,1,1,1,1,1,1,1,1,1}, //1
            {1,1,1,1,1,1,1,1,1,1}, //2
            {1,1,1,1,1,1,1,1,1,1}, //3
            {1,1,1,1,1,1,1,1,1,1}, //4
            {1,1,1,1,1,1,1,1,1,1}, //5
            {1,1,1,1,1,1,1,1,1,1}, //6  
            {1,1,1,1,1,1,1,1,1,1}, //7-
            {1,1,1,3,3,1,1,1,1,1}, //8
            {3,3,3,3,3,1,1,1,1,1}, //9
            {3,3,3,3,3,3,3,3,1,1}, //10
            {3,3,3,3,3,3,3,3,3,3}, //11
            {1,1,2,2,2,1,1,1,1,1}, //12
            {2,2,2,2,2,1,1,1,1,1}, //13
            {2,2,2,2,2,1,1,1,1,1}, //14
            {2,2,2,2,2,1,1,1,1,1}, //15
            {2,2,2,2,2,1,1,1,1,1}, //16
            {2,2,2,2,2,2,2,2,2,2} //17+
            };

        //State Space for hands with aces
        protected int[,] aceStrat = new int[,] {
                {1,1,3,3,3,1,1,1,1,1}, // soft 13
                {1,1,3,3,3,1,1,1,1,1}, // soft 14
                {1,1,3,3,3,1,1,1,1,1}, // soft 15
                {1,1,3,3,3,1,1,1,1,1}, // soft 16
                {3,3,3,3,3,1,1,1,1,1}, // soft 17
                {2,3,3,3,3,2,2,1,1,2}, // soft 18
                {2,2,2,2,3,2,2,2,2,2}, // soft 19
                {2,2,2,2,2,2,2,2,2,2}  // soft 20
                //TODO: may need to include case for soft 12
            };

        //State Space for hands containing only a pair
        protected int[,] splitStrat = new int[,]{
                {4,4,4,4,4,4,4,4,4,4},//Aces
                {1,4,4,4,4,4,1,1,1,1},//2
                {1,1,4,4,4,4,1,1,1,1},//3
                {1,1,1,3,3,1,1,1,1,1},//4
                {3,3,3,3,3,3,3,3,1,1},//5
                {4,4,4,4,4,1,1,1,1,1},//6
                {4,4,4,4,4,4,1,1,2,1},//7
                {4,4,4,4,4,4,4,4,4,4},//8
                {4,4,4,4,4,2,4,4,2,2},//9
                {2,2,2,2,2,2,2,2,2,2} //10's
                };

        public Player(Deck deck)
        {
            this.deck = deck;
            bankroll = 10000;
        }

        public void createHand(Deck deck)
        {
            this.handList.Add(new Hand(deck));
        }

        public abstract void strategy(Hand currentHand);

        protected void split(Hand currentHand)
        {

            //removes the current hand from the hand list, then adds both new hands to the end of the hands list
            handList.Remove(currentHand);

            Hand newHand1 = new Hand(deck, currentHand.cards[0]);
            Hand newHand2 = new Hand(deck, currentHand.cards[1]);
            handList.Add(newHand1);
            handList.Add(newHand2);
            numSplits++;

            //TODO: code to display the new hands should be put here

            //allows the player to play both hands, one after another
            strategy(newHand1);
            strategy(newHand2);
        }

        protected void hit(Hand currentHand)
        {
            Console.WriteLine("hit");
        }

        protected void stand(Hand currentHand)
        {
            Console.WriteLine("stand");
        }

        protected void doubleDown(Hand currentHand)
        {

        }

        protected void playCode(Hand currentHand, int code)
        {
            switch (code)
            {
                case 1://hit
                    hit(currentHand);
                    break;
                case 2://stand
                    stand(currentHand);
                    break;
                case 3: //double down
                    doubleDown(currentHand);
                    break;
                case 4: //split
                    split(currentHand);
                    break;
            }
        }

    }

    public class BasicJoe : Player
    {


        public BasicJoe(Deck deck)
            : base(deck)
        {

        }

        public void strategy(Hand currentHand)
        {
            strategy(currentHand, deck.dealer.dealerCard);
        }

        public void strategy(Hand currentHand, Card dealerCard)
            {
                
                //Checking for splits
               if(currentHand.cards[0].value == currentHand.cards[1].value)
               {
                  if(numSplits < 3){
                      playCode(currentHand, splitStrat[dealerCard.value, currentHand.cards[0].value]); //TODO: make sure the array is traversed properly
                  }
               }

                //checking for Aces
                if(currentHand.cards[0].value == 1 || currentHand.cards[1].value == 1)
                {
                    while (true)//loop if there is an ace
                    {

                    }
                }


                
            }
    }

    public class Dealer : Player
    {
        public Deck deck;
        public Card dealerCard;
        public Dealer(Deck deck) : base(deck)
        {
            dealerCard = handList.ElementAt(0).cards[0];//assigns the first card to be visible to everyone
        }

        public void strategy(Hand currentHand)
        {
            if (currentHand.getTotal() < 16)
            {
                hit(currentHand);
            }

            else
                stand(currentHand);
        }
    }

    public class UserPlayer : Player
    {
        public UserPlayer(Deck deck) : base(deck)
        {

        }
    }

    public class CardShark : BasicJoe//TODO: change from basicjoe to player
    {
        public CardShark(Deck deck) : base(deck)
        {

        }
    }
}
