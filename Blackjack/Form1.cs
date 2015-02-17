using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{

    public partial class Form1 : Form
    {
        //static EventWaitHandle _mainWaitHandle = new AutoResetEvent(false);
        static EventWaitHandle _waitHandle = new AutoResetEvent(false);
        public Form1 GUI = Form.ActiveForm as Form1;
        Table gameTable;
        int countingSystem;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.DarkGreen;

            PictureBox[] myPictureBox = { AJCard1, AJCard2, AJCard3, AJCard4, AJCard5, AJCard6, AJCard7 };
            AJhand = myPictureBox;

            PictureBox[] myPictureBox2 = { CSCard1, CSCard2, CSCard3, CSCard4, CSCard5, CSCard6, CSCard7 };
            CShand = myPictureBox2;

            PictureBox[] myPictureBox3 = { DealerCard1, DealerCard2, DealerCard3, DealerCard4, DealerCard5, DealerCard6, DealerCard7 };
            DealerHand = myPictureBox3;

            PictureBox[] myPictureBox4 = { UserPlayerCard1, UserPlayerCard2, UserPlayerCard3, UserPlayerCard4, UserPlayerCard5, UserPlayerCard6, UserPlayerCard7 };
            PlayerHand = myPictureBox4;


            Button[] playerChoices = { hitButton, stayButton, doubleButton, betButton, splitButton };
            playerChoicesGUI = playerChoices;

            playerBetGUI = playerBet;


            AJBankrollGUI = AJBankroll;
            CSBankrollGUI = CSBankroll;
            playerBankrollGUI = playerBankroll;
            GUI = Form.ActiveForm as Form1;
            



        }



        public static void Form1_changeCardImage(Image card, PictureBox target)
        {
            target.Image = card;
            target.Refresh();
        }


        delegate void SetTextCallback(Label label, string text);//methods that allow a text box to be changed across threads
        private void SetText(Label label, string text)//this method copied from Stack Overflow
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, label, text);
            }
            else
            {
                label.Text = text;
                label.Refresh();
            }
        }
        public void changeBankroll(Label label, double d)
        {
            SetText(label, d.ToString());
            //label.Refresh();

        }

        delegate void ToggleButtonCallback(Button button, bool val);//allows cross-thread enabling and disabling of buttons
        public void ToggleButton(Button button, bool val)
        {
            if (button.InvokeRequired)
            {
                ToggleButtonCallback d = new ToggleButtonCallback(ToggleButton);
                this.Invoke(d, button, val);
            }
            else
            {
                button.Enabled = val;

            }
        }

        delegate void ChangeImageCallback(PictureBox pictureBox, Image image);
        public void ChangeImage(PictureBox pictureBox, Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                ChangeImageCallback d = new ChangeImageCallback(ChangeImage);
                this.Invoke(d, pictureBox, image);
            }
            else
            {
                pictureBox.Image = image;
                pictureBox.Refresh();
            }
        }

        delegate void ToggleImageCallback(PictureBox pictureBox, bool val);
        public void ToggleImage(PictureBox pictureBox, bool val)
        {
            if (pictureBox.InvokeRequired)
            {
                ToggleImageCallback d = new ToggleImageCallback(ToggleImage);
                this.Invoke(d, pictureBox, val);
            }
            else
            {
                pictureBox.Visible = val;
                pictureBox.Refresh();
            }
        }

        delegate void AddTextCallback(RichTextBox textbox, string text);//adds text to a textbox
        public void AddText(RichTextBox textbox, string text)
        {
            if (textbox.InvokeRequired)
            {
                AddTextCallback d = new AddTextCallback(AddText);
                this.Invoke(d, textbox, text);
            }
            else
            {
                textbox.AppendText(text);
                textbox.ScrollToCaret();
            }
        }

        private void button4_Click(object sender, EventArgs e)//start game button
        {
            
            button4.Visible = false;
            welcomeLabel.Visible = false;
            playerName.Text = playerNameBox.Text;
            playerNameBox.Visible = false;
            enterNameLabel.Visible = false;
            AJText.Visible = true;
            playerText.Visible = true;
            CSText.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            if (radioButton1.Checked)
                countingSystem = 0;
            if (radioButton2.Checked)
                countingSystem = 1;
            if (radioButton3.Checked)
                countingSystem = 2;
            if (radioButton4.Checked)
                countingSystem = 3;


            this.Refresh();
            gameTable = new Table(this.AJBankrollGUI, this.CSBankrollGUI, this.playerBankroll,
                                        this.AJhand, this.DealerHand, this.CShand, this.PlayerHand, this.playerChoicesGUI,
                                        this.playerBetGUI, this.GUI);

            UP = gameTable.you;
            //gameTable.gameControl();

            new Thread(Game).Start();
        }
        void Game()//thread for the game control
        {
            gameTable.gameControl();
        }
        //private void splitButton_Click()
        //{
        //    UP.splitClick();
        //}
        //private void hitButton_Click()
        //{
        //    UP.hitClick();
        //}
        //private void doubleButton_Click()
        //{
        //    UP.doubleClick();
        //}
        //private void stayButton_Click()
        //{
        //    UP.stayClick();
        //}
        //private void betButton_Click()
        //{
        //    UP.betClick();
        //}



        public static Image[] cardsArray = {
            Blackjack.Properties.Resources._1,  Blackjack.Properties.Resources._2,  Blackjack.Properties.Resources._3,  
            Blackjack.Properties.Resources._4,  Blackjack.Properties.Resources._5,  Blackjack.Properties.Resources._6,  
            Blackjack.Properties.Resources._7,  Blackjack.Properties.Resources._8,  Blackjack.Properties.Resources._9,  
            Blackjack.Properties.Resources._10,  Blackjack.Properties.Resources._11,  Blackjack.Properties.Resources._12,  
            Blackjack.Properties.Resources._13,  Blackjack.Properties.Resources._14,  Blackjack.Properties.Resources._15,  
            Blackjack.Properties.Resources._16,  Blackjack.Properties.Resources._17,  Blackjack.Properties.Resources._18,  
            Blackjack.Properties.Resources._19,  Blackjack.Properties.Resources._20,  Blackjack.Properties.Resources._21,  
            Blackjack.Properties.Resources._22,  Blackjack.Properties.Resources._23,  Blackjack.Properties.Resources._24,  
            Blackjack.Properties.Resources._25,  Blackjack.Properties.Resources._26,  Blackjack.Properties.Resources._27,  
            Blackjack.Properties.Resources._28,  Blackjack.Properties.Resources._29,  Blackjack.Properties.Resources._30,  
            Blackjack.Properties.Resources._31,  Blackjack.Properties.Resources._32,  Blackjack.Properties.Resources._33,  
            Blackjack.Properties.Resources._34,  Blackjack.Properties.Resources._35,  Blackjack.Properties.Resources._36,  
            Blackjack.Properties.Resources._37,  Blackjack.Properties.Resources._38,  Blackjack.Properties.Resources._39,  
            Blackjack.Properties.Resources._40,  Blackjack.Properties.Resources._41,  Blackjack.Properties.Resources._42,  
            Blackjack.Properties.Resources._43,  Blackjack.Properties.Resources._44,  Blackjack.Properties.Resources._45,  
            Blackjack.Properties.Resources._46,  Blackjack.Properties.Resources._47,  Blackjack.Properties.Resources._48,  
            Blackjack.Properties.Resources._49, Blackjack.Properties.Resources._50,  Blackjack.Properties.Resources._51,  
            Blackjack.Properties.Resources._52,  Blackjack.Properties.Resources.back
         };

        public PictureBox[] AJhand;
        public PictureBox[] CShand;
        public PictureBox[] DealerHand;
        public PictureBox[] PlayerHand;
        public Button[] playerChoicesGUI;
        public Label AJBankrollGUI;
        public Label CSBankrollGUI;
        public Label playerBankrollGUI;
        public TextBox playerBetGUI;
        public UserPlayer UP;
        //public RichTextBox CSText;
        //public RichTextBox playerText;
        //public RichTextBox AJText;

        private Label welcomeLabel;




        public class Card
        {
            public int index;
            public int ID;
            public int suitID;
            public int value;
            public string face;
            public string suit;
            static Random r = new Random();
            public string name;
            public string shortName;

            public Card(int val)
            {
                this.index = val;
                this.ID = val % 13 + 1;
                this.suitID = (val / 13) % 4;

                if (ID > 10)
                    this.value = 10;

                else
                    this.value = this.ID;

                switch (this.ID)
                {
                    case 1: this.face = "Ace";
                        break;
                    case 2: this.face = "2";
                        break;
                    case 3: this.face = "3";
                        break;
                    case 4: this.face = "4";
                        break;
                    case 5: this.face = "5";
                        break;
                    case 6: this.face = "6";
                        break;
                    case 7: this.face = "7";
                        break;
                    case 8: this.face = "8";
                        break;
                    case 9: this.face = "9";
                        break;
                    case 10: this.face = "10";
                        break;
                    case 11: face = "Jack";
                        break;
                    case 12: face = "Queen";
                        break;
                    case 13: face = "King";
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

                this.name = face + " of " + suit;

                shortName = face[0] + "";
                if (ID == 10)
                    shortName = "10";
            }



        }
        public class Deck
        {
            //PictureBox[] DealerArray;
            static Random r = new Random();
            Card[] deck = new Card[416];
            List<Card> discardPile = new List<Card>();
            int numDecks;
            public int numCards;
            int currentCard = 0;
            public Dealer dealer;
            public CardShark counter;

            public Deck(int num, PictureBox[] handArray)
            {
                numDecks = num;
                numCards = numDecks * 52;

                for (int i = 0; i < numCards; i++)
                    this.deck[i] = new Card(i);

                this.dealer = new Dealer(this, handArray);
            }

            public void Shuffle()
            {

                for (int n = numCards - 1; n > 0; --n)
                {
                    int k = r.Next(n + 1);
                    Card temp = this.deck[n];
                    this.deck[n] = this.deck[k];
                    this.deck[k] = temp;
                }
                currentCard = 0;
                discardPile.Clear();
                counter.resetCount();
            }

            public Card Deal()
            {
                currentCard++;
                return deck[currentCard - 1];
            }


            public void discard(Card[] hand)//adds the cards in the hand to the discard pile
            {
                for (int i = 0; hand[i] != null; i++)
                {

                    discardPile.Add(hand[i]);

                }
            }
        }

        public class Hand
        {
            public bool isDealer = false;
            public bool blackjack = false;
            public bool stopFlag = false;
            public bool previouslySplit = false;
            public double wager;

            //PictureBox test thing
            public PictureBox[] handArray;

            Deck deck;
            public Card[] cards = new Card[22];//hands can theoretically have up to 22 cards if they are all aces.
            public int total;
            public Boolean soft;
            public int numCards;

            public Hand(Deck deck, bool isDealer)//special extra constructor for dealer to call
            {
                this.isDealer = isDealer;
                createHand(deck);
            }
            public Hand(Deck deck)
            {
                createHand(deck);
            }
            public void createHand(Deck deck)
            {
                this.deck = deck;

                for (int i = 0; i < 2; i++)
                {
                    hit();
                }
                updateTotal();

                if (total == 21 && previouslySplit == false)
                {
                    blackjack = true;
                    stopFlag = true;
                }
            }

            public void discard()
            {
                deck.discard(cards);
            }

            //checks if an ace is in the hand
            private Boolean hasAce()
            {
                for (int i = 0; i < numCards; i++)
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
                numCards = 1;
                hit();
                updateTotal();

            }

            public void updateTotal()
            {

                int value = 0;
                for (int i = 0; i < numCards; i++)
                    value += cards[i].value;


                if (value <= 11 && hasAce())
                {
                    soft = true;
                    value += 10;
                }

                total = value;
                if (value >= 21)
                    stopFlag = true;

            }

            public int getTotal()
            {
                return total;
            }

            public void hit()//hand receives a card and updates
            {
                Card newCard = this.deck.Deal();
                cards[numCards] = newCard;
                numCards++;
                updateTotal();

                if (!isDealer || numCards != 2)//makes sure this isn't the dealer's hole card
                    deck.counter.score(newCard);//shows the card to the card counter for him to count it

            }

        }

        public class Table
        {
            public Player cardShark;
            public Player basicJoe;
            public UserPlayer you;
            public Player dealer;
            Deck deck;
            public static int minBet = 1;
            public static int maxBet = 100;
            Form1 form;


            public Table(Label AJBankroll, Label CSBankroll, Label playerBankroll, PictureBox[] AJhand, PictureBox[] Dealer,
                            PictureBox[] CShand, PictureBox[] PlayerHand, Button[] playerChoices, TextBox playerBet, Form1 GUI)
            {
                form = (Form1)Form.ActiveForm;
                int numDecks = 8;
                deck = new Deck(numDecks, Dealer);
                dealer = deck.dealer;
                cardShark = new CardShark(deck, CShand);
                basicJoe = new BasicJoe(deck, AJhand);
                you = new UserPlayer(deck, PlayerHand, playerChoices, playerBet);

                cardShark.banklabel = CSBankroll;
                form.changeBankroll(cardShark.banklabel, cardShark.bankroll);

                basicJoe.banklabel = AJBankroll;
                form.changeBankroll(basicJoe.banklabel, basicJoe.bankroll);

                you.banklabel = playerBankroll;
                form.changeBankroll(you.banklabel, you.bankroll);



                // gameControl();
            }

            public void gameControl()
            {//main game loop



                while (true)
                {
                    deck.Shuffle();//shuffles the deck and deals everyone their first cards
                    dealer.createHand(true);
                    basicJoe.createHand();
                    you.createHand();
                    cardShark.createHand();

                    //cards need to not show before bets are made
                    basicJoe.makeWager();
                    cardShark.makeWager();
                    you.makeWager();

                    dealer.revealHand();
                    basicJoe.revealHand();
                    you.revealHand();
                    cardShark.revealHand();


                    basicJoe.strategy();
                    you.strategy();
                    cardShark.strategy();
                    dealer.strategy();

                    basicJoe.resolve();
                    you.resolve();
                    cardShark.resolve();
                    dealer.resolve();


                }
            }

            public void insurance()
            {
                basicJoe.checkInsurance();
                you.checkInsurance();
                cardShark.checkInsurance();
            }


        }

        public abstract class Player
        {
            public RichTextBox textBox;
            protected Form1 form = (Form1)Form.ActiveForm;
            public Label banklabel;
            public PictureBox[] handArray;
            public Card firstCard;
            public String playerName;
            protected Deck deck;
            public List<Hand> handList = new List<Hand>();
            //public Hand hand;
            public double bankroll;
            protected int numSplits;
            public double insuranceWager;
            //Key: 1: hit, 2: Stand, 3: Double Down, 4: Split

            //State Space for Normal Hands
            public static int[,] normalStrat = new int[,] {
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
            {2,2,2,2,2,2,2,2,2,2}, //17
            {2,2,2,2,2,2,2,2,2,2}, //18
            {2,2,2,2,2,2,2,2,2,2}, //19
            {2,2,2,2,2,2,2,2,2,2}  //20
            };

            //State Space for hands with aces
            public static int[,] aceStrat = new int[,] {
                {1,1,1,1,1,1,1,1,1,1},  //soft 12 
                {1,1,3,3,3,1,1,1,1,1}, // soft 13 (ace and 2)
                {1,1,3,3,3,1,1,1,1,1}, // soft 14 (ace and 3)
                {1,1,3,3,3,1,1,1,1,1}, // soft 15
                {1,1,3,3,3,1,1,1,1,1}, // soft 16
                {3,3,3,3,3,1,1,1,1,1}, // soft 17
                {2,3,3,3,3,2,2,1,1,2}, // soft 18
                {2,2,2,2,3,2,2,2,2,2}, // soft 19
                {2,2,2,2,2,2,2,2,2,2}  // soft 20
                
            };

            //State Space for hands containing only a pair
            public static int[,] splitStrat = new int[,]{
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

            public Player(Deck deck, PictureBox[] handArray)
            {
                this.deck = deck;
                this.handArray = handArray;
                bankroll = 10000;
            }

            public void createHand()
            {
                createHand(deck);
            }
            public void createHand(bool isDealer)
            {
                Hand hand = new Hand(deck, isDealer);
                this.handList.Add(hand);
                firstCard = hand.cards[0];

                //if (isDealer)
                //{
                //    updateGUI_dealer(handArray, hand);
                //}
                //else
                //    updateGUI(handArray, hand);
            }

            public void createHand(Deck deck)
            {
                Hand hand = new Hand(deck);
                this.handList.Add(hand);
                firstCard = handList.ElementAt(0).cards[0];
                //updateGUI(handArray, hand);
            }

            public void revealHand()//hands are revealed after bets are made
            {
                revealHand(handList.ElementAt(0));
            }
            public void revealHand(Hand currentHand)
            {
                if (currentHand.isDealer)
                {
                    updateGUI_dealer(handArray, currentHand);
                    if (firstCard.ID == 1)//if the visible card is an ace, ask players if they would like to take insurance
                        form.gameTable.insurance();
                }
                else
                    updateGUI(handArray, currentHand);
            }
            public void checkInsurance()
            {
                //does nothing by default, as insurance is a bad bet typically
            }
            public void insurance()
            {
                insuranceWager = handList.ElementAt(0).wager / 2;
                bankroll -= insuranceWager;
                form.changeBankroll(banklabel, bankroll);
            }

            public void strategy()
            {
                strategy(handList.ElementAt(0));
            }
            public abstract void strategy(Hand currentHand);

            protected void split(Hand currentHand)
            {

                //removes the current hand from the hand list, then adds both new hands to the end of the hands list
                handList.Remove(currentHand);
                currentHand.stopFlag = true;

                Hand newHand1 = new Hand(deck, currentHand.cards[0]);
                Hand newHand2 = new Hand(deck, currentHand.cards[1]);
                handList.Add(newHand1);
                handList.Add(newHand2);
                numSplits++;
                newHand1.previouslySplit = true;
                newHand2.previouslySplit = true;


                //allows the player to play both hands, one after another
                strategy(newHand1);
                strategy(newHand2);
            }

            protected void hit(Hand currentHand)
            {
                string text = playerName + " hit\n";
                form.AddText(textBox, text);
                currentHand.hit();

            }

            protected void stand(Hand currentHand)
            {
                string text = playerName + " stand\n";
                form.AddText(textBox, text);
                currentHand.stopFlag = true;//stops the hand
            }

            protected void doubleDown(Hand currentHand)
            {
                string text = playerName + " double down\n";
                form.AddText(textBox, text);
                bankroll -= currentHand.wager;
                currentHand.wager *= 2;
                currentHand.hit();
                currentHand.stopFlag = true;

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
                updateGUI(handArray, currentHand);
            }

            public void resolve()
            {
                resolve(deck.dealer);
            }

            public void resolve(Dealer dealer)
            {
                Hand dealerHand = dealer.handList.ElementAt(0);
                if (textBox != null)
                    for (int i = 0; i < handList.Count; i++)
                    {
                        Hand currentHand = handList.ElementAt(i);
                        //Console.Write(playerName + " Hand " + i + ": ");
                        string text = playerName + " Hand " + i + ": ";
                        form.AddText(textBox, text);
                        if (currentHand.total > 21)//busted
                        {
                            text = ("bust ");
                        }
                        else if (currentHand.blackjack == true)
                        {
                            text = ("Blackjack! ");
                            bankroll += (currentHand.wager * 2.5);
                        }
                        else if (dealerHand.total > 21)
                        {
                            text = ("dealer bust ");
                            bankroll += (currentHand.wager * 2);
                        }
                        else if (currentHand.total < dealerHand.total)
                        {
                            text = "lose ";
                        }
                        else if (currentHand.total == dealerHand.total)
                        {
                            text = "tie ";
                            bankroll += (currentHand.wager);
                        }
                        else if (currentHand.total > dealerHand.total)
                        {
                            text = "win ";
                            bankroll += (currentHand.wager * 2);
                        }

                        form.AddText(textBox, text);
                        //Console.WriteLine(currentHand.total + " to " + dealerHand.total);
                        text = currentHand.total + " to " + dealerHand.total + "\n";
                        form.AddText(textBox, text);


                        currentHand.discard();
                    }

                if (dealerHand.blackjack && insuranceWager > 0)//if the dealer had a blackjack, payout insurance if taken
                {
                    string text = "insurance win!\n";
                    form.AddText(textBox, text);
                    bankroll += insuranceWager * 3;
                }
                insuranceWager = 0;

                if (banklabel != null)//updates label
                    form.changeBankroll(banklabel, bankroll);

                handList.Clear();//after resolving, clear the hands  
            }

            public void updateGUI(PictureBox[] handArray, Hand currentHand)
            {

                int i = 0;
                for (i = 0; i < currentHand.numCards; i++)
                {
                    form.ToggleImage(handArray[i], true);
                    form.ChangeImage(handArray[i], cardsArray[currentHand.cards[i].index % 52]);
                    //handArray[i].Image = cardsArray[currentHand.cards[i].index % 52];
                    //handArray[i].Refresh();
                }
                for (i = currentHand.numCards; i < 7; i++)
                {
                    form.ToggleImage(handArray[i], false);
                }
            }

            public void updateGUI_dealer(PictureBox[] handArray, Hand currentHand)
            {

                int i = 0;
                for (i = 0; i < currentHand.numCards; i++)
                {
                    form.ToggleImage(handArray[i], true);
                    if (i == 1)
                        form.ChangeImage(handArray[i], cardsArray[52]);
                    else
                        form.ChangeImage(handArray[i], cardsArray[currentHand.cards[i].index % 52]);
                    //handArray[i].Image = cardsArray[currentHand.cards[i].index % 52];
                    //handArray[i].Refresh();
                }
                for (; i < 7; i++)
                {
                    form.ToggleImage(handArray[i], false);
                }
            }

            public void resetGUI(PictureBox[] handArray, Hand currentHand)
            {
                int i = 0;
                for (i = 0; i < 7; i++)
                {
                    form.ToggleImage(handArray[i], false);
                }
            }
            public void play()
            {
                makeWager();
                strategy();
            }

            public abstract void makeWager();
            public void makeWager(double bet)
            {
                handList.ElementAt(0).wager = bet;
                bankroll -= bet;
                form.changeBankroll(banklabel, bankroll);
            }

        }

        public class BasicJoe : Player
        {



            public BasicJoe(Deck deck, PictureBox[] handArray)
                : base(deck, handArray)
            {
                playerName = "Basic Joe";
                textBox = form.AJText;
            }

            public override void strategy(Hand currentHand)
            {
                strategy(currentHand, deck.dealer.firstCard);
            }

            public void strategy(Hand currentHand, Card firstCard)
            {

                //Checking for splits
                if (currentHand.cards[0].value == currentHand.cards[1].value)
                {
                    if (numSplits < 3)
                    {
                        playCode(currentHand, splitStrat[currentHand.cards[0].value - 1, firstCard.value - 1]); 
                    }
                }

                while (currentHand.stopFlag == false)//looping as long as the player does not bust, stand, or double down
                {
                    if (currentHand.soft)//if the hand is soft (has an ace)
                    {
                        playCode(currentHand, aceStrat[currentHand.total - 12, firstCard.value - 1]);
                    }
                    else
                        playCode(currentHand, normalStrat[currentHand.total - 1, firstCard.value - 1]);

                    if (currentHand.stopFlag == false)
                        updateGUI(handArray, currentHand);

                    //if(currentHand.stopFlag == true)
                    //resetGUI(handArray, currentHand);
                }
            }

            public override void makeWager()//basic joe always bets the minimum
            {
                makeWager(Table.minBet);
            }
        }

        public class Dealer : Player
        {

            public Dealer(Deck deck, PictureBox[] handArray)
                : base(deck, handArray)
            {
                playerName = "Dealer";
                this.handArray = handArray;
                textBox = form.dealerText;
            }


            public override void strategy(Hand currentHand)
            {
                updateGUI(handArray, currentHand);
                deck.counter.score(currentHand.cards[1]);

                while (currentHand.total < 16)
                {
                    hit(currentHand);
                    updateGUI(handArray, currentHand);

                    //if (currentHand.stopFlag == true)
                    //    resetGUI(handArray, currentHand);
                }

                stand(currentHand);
                //resetGUI(handArray, currentHand);
            }
            public override void makeWager()
            {
                //does nothing
            }
        }

        public class UserPlayer : Player
        { // indexes: 0 : hitButton, 1 : stayButton, 2 : doubleButton, 3: betButton, 4: splitButton


            Button[] playerChoices;
            TextBox playerBet;
            public int choice = 0;
            public UserPlayer(Deck deck, PictureBox[] handArray, Button[] playerChoices, TextBox playerBet)
                : base(deck, handArray)
            {

                // PictureBox[] myHandArray = { };
                //this.handArray = null;

                this.playerChoices = playerChoices;
                this.playerBet = playerBet;
                textBox = form.playerText;

            }
            public void betClick()//methods called when buttons are clicked, assuming they are enabled
            {
                _waitHandle.Set();
            }
            public void hitClick()//Key: 1: hit, 2: Stand, 3: Double Down, 4: Split
            {
                choice = 1;
                _waitHandle.Set();
            }
            public void stayClick()
            {
                choice = 2;
                _waitHandle.Set();
            }
            public void doubleClick()
            {
                choice = 3;
                _waitHandle.Set();
            }
            public void splitClick()
            {
                choice = 4;
                _waitHandle.Set();
            }
            public void insuranceClick()
            {
                insurance();
                _waitHandle.Set();
            }
            public void noInsuranceClick()
            {
                //does nothing but unpause
                _waitHandle.Set();
            }


            public override void strategy(Hand currentHand)
            {

                updateGUI(handArray, currentHand);

                if (currentHand.cards[0].value == currentHand.cards[1].value && numSplits < 3)//checks for split, enables the buttons
                    form.ToggleButton(form.splitButton, true);

                while (currentHand.stopFlag != true)//loops everything other than the split decision
                {
                    updateGUI(handArray, currentHand);

                    form.ToggleButton(form.hitButton, true);
                    form.ToggleButton(form.doubleButton, true);
                    form.ToggleButton(form.stayButton, true);

                    Waiter();//waits for a button click, then performs the relevant actions


                    form.ToggleButton(form.hitButton, false);
                    form.ToggleButton(form.doubleButton, false);
                    form.ToggleButton(form.stayButton, false);
                    form.ToggleButton(form.splitButton, false);

                    playCode(currentHand, choice);
                }




                strategy(currentHand, this.playerChoices);

            }

            public void strategy(Hand currentHand, Button[] playerChoices)
            {

            }

            static void Waiter()
            {
                Console.WriteLine("Waiting...");
                _waitHandle.WaitOne();                // Wait for notification
                Console.WriteLine("Notified");

            }

            public override void makeWager()
            {

                form.ToggleButton(form.betButton, true);
                Waiter();
                form.ToggleButton(form.betButton, false);

                String betString = form.playerBet.Text;
                double betAmount = Table.minBet;//sets the bet to the minimum bet or whatever the player enters, if valid
                try
                {
                    betAmount = Convert.ToDouble(betString);
                }
                catch (FormatException)
                {

                }
                betAmount = (betAmount > Table.maxBet) ? Table.maxBet : betAmount;


                makeWager(betAmount);
                //_mainWaitHandle.Set();
            }
            new public void checkInsurance()
            {//activates insurance buttons, waits for a click
                form.ToggleButton(form.insuranceButton, true);
                form.ToggleButton(form.noInsuranceButton, true);
                Waiter();
                form.ToggleButton(form.insuranceButton, false);
                form.ToggleButton(form.noInsuranceButton, false);
            }
            //system.windows.forms.timer timer = new system.windows.forms.timer();
            //public void Delayed()
            //{

            //    timer.Interval = 100;
            //    timer.Tick += (s, e) =>
            //    {

            //        timer.Stop();
            //    };
            //    timer.Start();
            //}
        }

        public class CardShark : Player
        {
            float count;
            float trueCount;
            int cardsDealt;
            int totalCards;
            int cardsRemaining;
            int system;//card counting system chosen, defaults to hi-lo
            //Label bankrollLabel = CSBankroll;

            //TODO: make systems choosable
            float[,] value ={//uses the counting system's number and the id of the card to change the count by that value
                           {-1,1,1,1,1,1,0,0,0,-1,-1,-1,-1},    //0: Hi-lo
                           {-1,(float)0.5,1,1,(float)1.5,1,(float)0.5,0,(float)-0.5,-1,-1,-1,-1},    //1: Halves
                           {-1,1,1,2,2,2,1,0,0,-2,-2,-2,-2},    //3: Zen
                           {0,1,1,2,2,2,1,0,-1,-2,-2,-2,-2}     //4:Omega II
                       };
            float[] startCount = { 0,0,0,0 };//starting count for each system, which needs to be added for each one


            //variant of basic strategy table including illustrious 18
            //Key: 1: hit, 2: Stand, 3: Double Down, 4: Split
            //greater than 4 = illustrious 18

            public static int[,] illustrious = new int[,]{//illustrious 18 counts and actions, starting at #2. #1: take insurance if count is >= 3
            {0,4,5,4,4,2,3,1,1,4,3,5,-1,0,-2,-1,-2},
            {2,2,4,4,3,2,2,3,3,3,3,2, 2,2, 2, 2, 2}
        };

            //State Space for Normal Hands
            new private static int[,] normalStrat = new int[,] {
           //Order is 2 - Ace for dealer's card
            {1,1,1,1,1,1,1,1,1,1}, //1
            {1,1,1,1,1,1,1,1,1,1}, //2
            {1,1,1,1,1,1,1,1,1,1}, //3
            {1,1,1,1,1,1,1,1,1,1}, //4
            {1,1,1,1,1,1,1,1,1,1}, //5
            {1,1,1,1,1,1,1,1,1,1}, //6  
            {1,1,1,1,1,1,1,1,1,1}, //7-
            {1,1,1,3,3,1,1,1,1,1}, //8
            {13,3,3,3,3,15,1,1,1,1}, //9
            {3,3,3,3,3,3,3,3,9,14}, //10
            {3,3,3,3,3,3,3,3,3,12}, //11
            {11,10,18,19,20,1,1,1,1,1}, //12
            {17,21,2,2,2,1,1,1,1,1}, //13
            {2,2,2,2,2,1,1,1,1,1}, //14
            {2,2,2,2,2,1,1,1,6,1}, //15
            {2,2,2,2,2,1,1,16,5,1}, //16
            {2,2,2,2,2,2,2,2,2,2}, //17
            {2,2,2,2,2,2,2,2,2,2}, //18
            {2,2,2,2,2,2,2,2,2,2}, //19
            {2,2,2,2,2,2,2,2,2,2}  //20
            };

            //State Space for hands with aces
            new private static int[,] aceStrat = new int[,] {
                {1,1,1,1,1,1,1,1,1,1},  //soft 12
                {1,1,3,3,3,1,1,1,1,1}, // soft 13 (ace and 2)
                {1,1,3,3,3,1,1,1,1,1}, // soft 14 (ace and 3)
                {1,1,3,3,3,1,1,1,1,1}, // soft 15
                {1,1,3,3,3,1,1,1,1,1}, // soft 16
                {3,3,3,3,3,1,1,1,1,1}, // soft 17
                {2,3,3,3,3,2,2,1,1,2}, // soft 18
                {2,2,2,2,3,2,2,2,2,2}, // soft 19
                {2,2,2,2,2,2,2,2,2,2}  // soft 20
                
            };

            //State Space for hands containing only a pair
            new private static int[,] splitStrat = new int[,]{
                {4,4,4,4,4,4,4,4,4,4},//Aces
                {1,4,4,4,4,4,1,1,1,1},//2
                {1,1,4,4,4,4,1,1,1,1},//3
                {1,1,1,3,3,1,1,1,1,1},//4
                {3,3,3,3,3,3,3,3,1,1},//5
                {4,4,4,4,4,1,1,1,1,1},//6
                {4,4,4,4,4,4,1,1,2,1},//7
                {4,4,4,4,4,4,4,4,4,4},//8
                {4,4,4,4,4,2,4,4,2,2},//9
                {2,2,2,7,8,2,2,2,2,2} //10's
                };

            new protected void playCode(Hand currentHand, int code)
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
                    default:
                        if (code > 4 && code <= 21)//if the code is one of the illustrious 18
                        {
                            if (trueCount > illustrious[0, code - 5])
                            {
                                playCode(currentHand, illustrious[1, code - 5]);
                            }
                            else
                            {
                                hit(currentHand);
                            }
                        }
                        break;
                }
                updateGUI(handArray, currentHand);
            }
            public CardShark(Deck deck, PictureBox[] handArray)
                : base(deck, handArray)
            {
                playerName = "Card Shark";
                deck.counter = this;
                this.handArray = handArray;
                totalCards = deck.numCards;
                textBox = form.CSText;
                system = form.countingSystem;
            }

            new public void checkInsurance()
            {
                if (trueCount >= 3)
                {
                    insurance();
                }
            }

            public override void strategy(Hand currentHand)
            {
                strategy(currentHand, deck.dealer.firstCard);
            }

            public void strategy(Hand currentHand, Card firstCard)
            {

                //Checking for splits
                if (currentHand.cards[0].value == currentHand.cards[1].value)
                {
                    if (numSplits < 3)
                    {
                        playCode(currentHand, splitStrat[currentHand.cards[0].value - 1, firstCard.value - 1]); 
                    }
                }

                while (currentHand.stopFlag == false)//looping as long as the player does not bust, stand, or double down
                {
                    if (currentHand.soft)//if the hand is soft (has an ace)
                    {
                        playCode(currentHand, aceStrat[currentHand.total - 12, firstCard.value - 1]);
                    }
                    else
                        playCode(currentHand, normalStrat[currentHand.total - 1, firstCard.value - 1]);

                    if (currentHand.stopFlag == false)
                        updateGUI(handArray, currentHand);

                    //if(currentHand.stopFlag == true)
                    //resetGUI(handArray, currentHand);
                }
            }

            public void score(Card card)
            {
                score(card, system);
            }

            private void score(Card card, int system)
            {
                count += value[system, card.ID - 1];
                cardsDealt++;
                cardsRemaining--;
                trueCount = count * 52 / cardsRemaining;
            }

            public void resetCount()
            {
                cardsRemaining = totalCards;
                cardsDealt = 0;
                count = startCount[system];
            }
            public override void makeWager()//makes bets proportional to the truecount
            {
                //multiplies the truecount by the minimum bet, and makes sure the value is within the table's betting range
                double bet = Table.minBet * (trueCount);
                if (bet < Table.minBet)
                {
                    bet = Table.minBet;
                }
                else if (bet > Table.maxBet)
                {
                    bet = Table.maxBet;
                }

                handList.ElementAt(0).wager = bet;
                bankroll -= bet;
                form.changeBankroll(banklabel, bankroll);
            }
        }
        //public static Form1 ActiveForm()
        //{
        //    return (Form1)Form.ActiveForm;
        //}

        public void hitButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.hitClick();

        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.stayClick();
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.doubleClick();

        }

        private void betButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.betClick();
            //_waitHandle.Set();
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.splitClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.insuranceClick();
        }

        private void noInsuranceButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Form.ActiveForm;
            form.UP.noInsuranceClick();
        }



    }
}

