using System;

namespace Poker_2._0
{
    class GameClass
    {
        public int bet=0;
        public int bank=0;
        public int turn=0;
        public int RaiseBet=0;
        public string card1;
        public string suit1;
        public string card2;
        public string suit2;
        public string card3;
        public string suit3;
        public string card4;
        public string suit4;
        public string card5;
        public string suit5;
        public static string DrawCards(ref string gamecard, ref string gamesuit)
        {
            Random rnd = new Random();
            GameClass game = new GameClass();
            int num;
            int suitint;
            string Card1="", suit1="", FirstCard;
            num = rnd.Next(2, 14);
            switch (num)
                {
                    case 2:
                        Card1 = "Two";
                        break;
                    case 3:
                        Card1 = "Three";
                        break;
                    case 4:
                        Card1 = "Four";
                        break;
                    case 5:
                        Card1 = "Five";
                        break;
                    case 6:
                        Card1 = "Six";
                        break;
                    case 7:
                        Card1 = "Seven";
                        break;
                    case 8:
                        Card1 = "Eignt";
                        break;
                    case 9:
                        Card1 = "Nine";
                        break;
                    case 10:
                        Card1 = "Ten";
                        break;
                    case 11:
                        Card1 = "Jack";
                        break;
                    case 12:
                        Card1 = "Queen";
                        break;
                    case 13:
                        Card1 = "King";
                        break;
                    case 14:
                        Card1 = "Ace";
                        break;
                }
            suitint = rnd.Next(0, 3);
            switch (suitint)
                {
                    case 0:
                        suit1 = $"clubs";
                        break;
                    case 1:
                        suit1 = "diamonds";
                        break;
                    case 2:
                        suit1 = "spades";
                        break;
                    case 3:
                        suit1 = "hearts";
                        break;
                }
            FirstCard = $"{Card1} of {suit1}";
            gamecard = Card1;
            gamesuit = suit1;
            return FirstCard;
        }
        public static int CheckCombs(ref int comb, string card1, string card2, string suit1, string suit2, string gamecard1, string gamesuit1, string gamecard2, string gamesuit2, string gamecard3, string gamesuit3, string gamecard4, string gamesuit4, string gamecard5, string gamesuit5)
        {
            //Royal Flush
            if ((((card1 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace")) ||
                ((card2 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace"))) &&
                (((((suit1 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit1 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit1 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit1 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades"))) ||
                (((suit2 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit2 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit2 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit2 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades")))))) return comb = 9;
            //Straght Flush
            else if (((((card1 == "Two") && (gamecard1 == "Three") && (gamecard2 == "Four") && (gamecard3 == "Five") && (gamecard4 == "Six")) ||
                ((card1 == "Three") && (gamecard1 == "Four") && (gamecard2 == "Five") && (gamecard3 == "Six") && (gamecard4 == "Seven")) ||
                ((card1 == "Four") && (gamecard1 == "Five") && (gamecard2 == "Six") && (gamecard3 == "Seven") && (gamecard4 == "Eight")) ||
                ((card1 == "Five") && (gamecard1 == "Six") && (gamecard2 == "Seven") && (gamecard3 == "Eight") && (gamecard4 == "Nine")) ||
                ((card1 == "Six") && (gamecard1 == "Seven") && (gamecard2 == "Eight") && (gamecard3 == "Nine") && (gamecard4 == "Ten")) ||
                ((card1 == "Seven") && (gamecard1 == "Eight") && (gamecard2 == "Nine") && (gamecard3 == "Ten") && (gamecard4 == "Jack")) ||
                ((card1 == "Eight") && (gamecard1 == "Nine") && (gamecard2 == "Ten") && (gamecard3 == "Jack") && (gamecard4 == "Queen")) ||
                ((card1 == "Nine") && (gamecard1 == "Ten") && (gamecard2 == "Jack") && (gamecard3 == "Queen") && (gamecard4 == "King")) ||
                ((card1 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace")) ||
                ((card1 == "Ace") && (gamecard1 == "Two") && (gamecard2 == "Three") && (gamecard3 == "Four") && (gamecard4 == "Five"))) ||
                ((((card2 == "Two") && (gamecard1 == "Three") && (gamecard2 == "Four") && (gamecard3 == "Five") && (gamecard4 == "Six")) ||
                ((card2 == "Three") && (gamecard1 == "Four") && (gamecard2 == "Five") && (gamecard3 == "Six") && (gamecard4 == "Seven")) ||
                ((card2 == "Four") && (gamecard1 == "Five") && (gamecard2 == "Six") && (gamecard3 == "Seven") && (gamecard4 == "Eight")) ||
                ((card2 == "Five") && (gamecard1 == "Six") && (gamecard2 == "Seven") && (gamecard3 == "Eight") && (gamecard4 == "Nine")) ||
                ((card2 == "Six") && (gamecard1 == "Seven") && (gamecard2 == "Eight") && (gamecard3 == "Nine") && (gamecard4 == "Ten")) ||
                ((card2 == "Seven") && (gamecard1 == "Eight") && (gamecard2 == "Nine") && (gamecard3 == "Ten") && (gamecard4 == "Jack")) ||
                ((card2 == "Eight") && (gamecard1 == "Nine") && (gamecard2 == "Ten") && (gamecard3 == "Jack") && (gamecard4 == "Queen")) ||
                ((card2 == "Nine") && (gamecard1 == "Ten") && (gamecard2 == "Jack") && (gamecard3 == "Queen") && (gamecard4 == "King")) ||
                ((card2 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace")) ||
                ((card2 == "Ace") && (gamecard1 == "Two") && (gamecard2 == "Three") && (gamecard3 == "Four") && (gamecard4 == "Five"))))) &&
                ((((suit1 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit1 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit1 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit1 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades"))) ||
                (((suit2 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit2 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit2 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit2 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades"))))) return comb = 8;
            //Four
            else if ((((card1 == card2) && (card1 == gamecard1) && (card1 == gamecard2) && (gamecard3 == card1)) || ((card1 == card2) && (card1 == gamecard2) && (card1 == gamecard3) && (gamecard4 == card1))) ||
                (((card1 == card2) && (card2 == gamecard1) && (card2 == gamecard2) && (gamecard3 == card2)) || ((card1 == card2) && (card2 == gamecard2) && (card2 == gamecard3) && (gamecard4 == card2)))) return comb = 7;
            //Full House
            else if (((card1 == card2) || ((card1 == gamecard1) || (card2 == gamecard1)) || ((card1 == gamecard2) || (card2 == gamecard2)) ||
                ((card1 == gamecard3) || (card2 == gamecard3)) || ((card1 == gamecard4) || (card2 == gamecard4)) || ((card1 == gamecard5) || (card2 == gamecard5))) && (((card1 == card2) && (((card1 == gamecard1) || (card2 == gamecard1)) || ((card1 == gamecard2) || (card2 == gamecard2)) || ((card1 == gamecard3) || (card2 == gamecard3)) || ((card1 == gamecard4) || (card2 == gamecard4)) ||
                ((card1 == gamecard5) || (card2 == gamecard5)))) ||
                (((card1 == gamecard1) && (card1 == gamecard2)) || ((card2 == gamecard1) && (card2 == gamecard2))) ||
                (((card1 == gamecard1) && (card1 == gamecard3)) || ((card2 == gamecard1) && (card2 == gamecard3))) ||
                (((card1 == gamecard1) && (card1 == gamecard4)) || ((card2 == gamecard1) && (card2 == gamecard4))) ||
                (((card1 == gamecard1) && (card1 == gamecard5)) || ((card2 == gamecard1) && (card2 == gamecard5))) ||
                (((card1 == gamecard2) && (card1 == gamecard3)) || ((card2 == gamecard2) && (card2 == gamecard3))) ||
                (((card1 == gamecard2) && (card1 == gamecard4)) || ((card2 == gamecard2) && (card2 == gamecard4))) ||
                (((card1 == gamecard2) && (card1 == gamecard5)) || ((card2 == gamecard2) && (card2 == gamecard5))) ||
                (((card1 == gamecard3) && (card1 == gamecard4)) || ((card2 == gamecard3) && (card2 == gamecard4))) ||
                (((card1 == gamecard3) && (card1 == gamecard5)) || ((card2 == gamecard3) && (card2 == gamecard5))) ||
                (((card1 == gamecard4) && (card1 == gamecard5)) || ((card2 == gamecard4) && (card2 == gamecard4))))) return comb = 6;
            //Flush
            else if ((((suit1 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit1 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit1 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit1 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades"))) ||
                (((suit2 == "clubs") && (gamesuit1 == "clubs") && (gamesuit2 == "clubs") && (gamesuit3 == "clubs") && (gamesuit4 == "clubs")) ||
                ((suit2 == "doamonds") && (gamesuit1 == "diamonds") && (gamesuit2 == "diamonds") && (gamesuit3 == "diamonds") && (gamesuit4 == "diamonds")) ||
                ((suit2 == "hearts") && (gamesuit1 == "hearts") && (gamesuit2 == "hearts") && (gamesuit3 == "hearts") && (gamesuit4 == "hearts")) ||
                ((suit2 == "spades") && (gamesuit1 == "spades") && (gamesuit2 == "spades") && (gamesuit3 == "spades") && (gamesuit4 == "spades")))) return comb = 5;
            //Straight
            else if ((((card1 == "Two") && (gamecard1 == "Three") && (gamecard2 == "Four") && (gamecard3 == "Five") && (gamecard4 == "Six")) ||
                ((card1 == "Three") && (gamecard1 == "Four") && (gamecard2 == "Five") && (gamecard3 == "Six") && (gamecard4 == "Seven")) ||
                ((card1 == "Four") && (gamecard1 == "Five") && (gamecard2 == "Six") && (gamecard3 == "Seven") && (gamecard4 == "Eight")) ||
                ((card1 == "Five") && (gamecard1 == "Six") && (gamecard2 == "Seven") && (gamecard3 == "Eight") && (gamecard4 == "Nine")) ||
                ((card1 == "Six") && (gamecard1 == "Seven") && (gamecard2 == "Eight") && (gamecard3 == "Nine") && (gamecard4 == "Ten")) ||
                ((card1 == "Seven") && (gamecard1 == "Eight") && (gamecard2 == "Nine") && (gamecard3 == "Ten") && (gamecard4 == "Jack")) ||
                ((card1 == "Eight") && (gamecard1 == "Nine") && (gamecard2 == "Ten") && (gamecard3 == "Jack") && (gamecard4 == "Queen")) ||
                ((card1 == "Nine") && (gamecard1 == "Ten") && (gamecard2 == "Jack") && (gamecard3 == "Queen") && (gamecard4 == "King")) ||
                ((card1 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace")) ||
                ((card1 == "Ace") && (gamecard1 == "Two") && (gamecard2 == "Three") && (gamecard3 == "Four") && (gamecard4 == "Five"))) ||
                ((((card2 == "Two") && (gamecard1 == "Three") && (gamecard2 == "Four") && (gamecard3 == "Five") && (gamecard4 == "Six")) ||
                ((card2 == "Three") && (gamecard1 == "Four") && (gamecard2 == "Five") && (gamecard3 == "Six") && (gamecard4 == "Seven")) ||
                ((card2 == "Four") && (gamecard1 == "Five") && (gamecard2 == "Six") && (gamecard3 == "Seven") && (gamecard4 == "Eight")) ||
                ((card2 == "Five") && (gamecard1 == "Six") && (gamecard2 == "Seven") && (gamecard3 == "Eight") && (gamecard4 == "Nine")) ||
                ((card2 == "Six") && (gamecard1 == "Seven") && (gamecard2 == "Eight") && (gamecard3 == "Nine") && (gamecard4 == "Ten")) ||
                ((card2 == "Seven") && (gamecard1 == "Eight") && (gamecard2 == "Nine") && (gamecard3 == "Ten") && (gamecard4 == "Jack")) ||
                ((card2 == "Eight") && (gamecard1 == "Nine") && (gamecard2 == "Ten") && (gamecard3 == "Jack") && (gamecard4 == "Queen")) ||
                ((card2 == "Nine") && (gamecard1 == "Ten") && (gamecard2 == "Jack") && (gamecard3 == "Queen") && (gamecard4 == "King")) ||
                ((card2 == "Ten") && (gamecard1 == "Jack") && (gamecard2 == "Queen") && (gamecard3 == "King") && (gamecard4 == "Ace")) ||
                ((card2 == "Ace") && (gamecard1 == "Two") && (gamecard2 == "Three") && (gamecard3 == "Four") && (gamecard4 == "Five"))))) return comb = 4;
            //Set
            else if (((card1 == card2) && (((card1 == gamecard1) || (card2 == gamecard1)) || ((card1 == gamecard2) || (card2 == gamecard2)) || ((card1 == gamecard3) || (card2 == gamecard3)) || ((card1 == gamecard4) || (card2 == gamecard4)) ||
                ((card1 == gamecard5) || (card2 == gamecard5)))) ||
                (((card1 == gamecard1) && (card1 == gamecard2)) || ((card2 == gamecard1) && (card2 == gamecard2))) ||
                (((card1 == gamecard1) && (card1 == gamecard3)) || ((card2 == gamecard1) && (card2 == gamecard3))) ||
                (((card1 == gamecard1) && (card1 == gamecard4)) || ((card2 == gamecard1) && (card2 == gamecard4))) ||
                (((card1 == gamecard1) && (card1 == gamecard5)) || ((card2 == gamecard1) && (card2 == gamecard5))) ||
                (((card1 == gamecard2) && (card1 == gamecard3)) || ((card2 == gamecard2) && (card2 == gamecard3))) ||
                (((card1 == gamecard2) && (card1 == gamecard4)) || ((card2 == gamecard2) && (card2 == gamecard4))) ||
                (((card1 == gamecard2) && (card1 == gamecard5)) || ((card2 == gamecard2) && (card2 == gamecard5))) ||
                (((card1 == gamecard3) && (card1 == gamecard4)) || ((card2 == gamecard3) && (card2 == gamecard4))) ||
                (((card1 == gamecard3) && (card1 == gamecard5)) || ((card2 == gamecard3) && (card2 == gamecard5))) ||
                (((card1 == gamecard4) && (card1 == gamecard5)) || ((card2 == gamecard4) && (card2 == gamecard4)))) return comb = 3;
            //Two Pair
            else if (((card1 == card2) && ((gamecard1 == gamecard2) || (gamecard1 == gamecard3) || (gamecard1 == gamecard4) || (gamecard1 == gamecard5) || (gamecard2 == gamecard3) || (gamecard2 == gamecard4) ||
                (gamecard2 == gamecard5) || (gamecard3 == gamecard4) || (gamecard3 == gamecard5) || (gamecard4 == gamecard5))) ||
                ((card1 == gamecard1) && ((card2 == gamecard2) || (card2 == gamecard3) || (card2 == gamecard4) || (card2 == gamecard5))) || ((card1 == gamecard2) && ((card2 == gamecard1) || (card2 == gamecard3) || (card2 == gamecard4) || (card2 == gamecard5))) ||
                (((gamecard1 == gamecard2) && (gamecard3 == gamecard4)) || ((gamecard1 == gamecard2) && (gamecard3 == gamecard5)) || ((gamecard1 == gamecard3) && (gamecard2 == gamecard4)) || ((gamecard1 == gamecard3) && (gamecard2 == gamecard5)) ||
                ((gamecard1 == gamecard4) && (gamecard2 == gamecard3)) || ((gamecard1 == gamecard4) && (gamecard2 == gamecard5)) || ((gamecard1 == gamecard5) && (gamecard2 == gamecard3)) || ((gamecard1 == gamecard5) && (gamecard2 == gamecard4)))) return comb = 1;
            //Pair
            else if ((card1 == card2) || ((card1 == gamecard1) || (card2 == gamecard1)) || ((card1 == gamecard2) || (card2 == gamecard2)) ||
                ((card1 == gamecard3) || (card2 == gamecard3)) || ((card1 == gamecard4) || (card2 == gamecard4)) || ((card1 == gamecard5) || (card2 == gamecard5))) return comb = 1;
            //High Card
            else return comb;
        }
        public static int CompareCombs(int comb1, int comb2)
        {
            int i;
            if (comb1 > comb2) return i = 1;
            else if (comb1 < comb2) return i = 0;
            else return i = 2;
        }
    }
}

