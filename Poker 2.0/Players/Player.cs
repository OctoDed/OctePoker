using System;
namespace Poker_2._0
{
    public class Player
    {
        public int Money = 1000;
        public int turn = 0;
        public int bet = 0;
        public int RaiseBet = 0;
        public int comb = 1;
        public string Card1 { get; set; }
        public string Card1Suit { get; set; }
        public string Card2 { get; set; }
        public string Card2Suit { get; set; }
        static public void SetCards(ref string Card1, ref string Card2, ref string Card1Suit, ref string Card2Suit)
        {
            int num1, num2, suit1, suit2;
            Random rnd = new Random();
            num1 = rnd.Next(2, 14);
            switch (num1)
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
            suit1 = rnd.Next(0, 4);
            switch (suit1)
            {
                case 0: Card1Suit = "clubs";
                    break;
                case 1:
                    Card1Suit = "diamonds";
                    break;
                case 2:
                    Card1Suit = "spades";
                    break;
                case 3:
                    Card1Suit = "hearts";
                    break;
            }
            num2 = rnd.Next(2, 14);
            switch (num2)
            {
                case 2:
                    Card2 = "Two";
                    break;
                case 3:
                    Card2 = "Three";
                    break;
                case 4:
                    Card2 = "Four";
                    break;
                case 5:
                    Card2 = "Five";
                    break;
                case 6:
                    Card2 = "Six";
                    break;
                case 7:
                    Card2 = "Seven";
                    break;
                case 8:
                    Card2 = "Eignt";
                    break;
                case 9:
                    Card2 = "Nine";
                    break;
                case 10:
                    Card2 = "Ten";
                    break;
                case 11:
                    Card2 = "Jack";
                    break;
                case 12:
                    Card2 = "Queen";
                    break;
                case 13:
                    Card2 = "King";
                    break;
                case 14:
                    Card2 = "Ace";
                    break;
            }
            suit2 = rnd.Next(0, 4);
            switch (suit2)
            {
                case 0:
                    Card2Suit = "clubs";
                    break;
                case 1:
                    Card2Suit = "diamonds";
                    break;
                case 2:
                    Card2Suit = "spades";
                    break;
                case 3:
                    Card2Suit = "hearts";
                    break;
            }
        }
    }
}
