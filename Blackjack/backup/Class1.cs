using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
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

        void split(Hand currentHand)
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

        protected void playCode(Hand currentHand, int code)
        {
            switch (code)
            {
                case 1://hit
                    hit(currentHand);
                case 2://stand
                    stand(currentHand);
                case 3: //double down
                    doubleDown(currentHand);
                case 4: //split
                    split(currentHand);
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
                      playCode(splitStrat[]);
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
        public Card dealerCard;
        public Dealer(Deck deck)
            : base(deck)
        {
            dealerCard = handList.ElementAt(0).cards[0];//assigns the first card to be visible to everyone
        }

        public void strategy(Hand currentHand)
        {
            if (currentHand.getTotal() < 16)
            {
                Hit(currentHand);
            }

            else
                Stay(currentHand);
        }
    }

    public class UserPlayer : Player
    {

    }
    public class CardShark : Player
    {

    }
}
