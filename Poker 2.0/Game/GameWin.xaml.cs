using System;
using System.Windows;

namespace Poker_2._0.Game
{
    public partial class GameWin : Window
    {
        public GameWin()
        {
            InitializeComponent();
        }

        Player player = new Player();
        Bot bot = new Bot();
        GameClass game = new GameClass();
        int round = 1;
        //пропуск ставки, если они равны
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            player.turn += 1;
            string card1 = "", card2 = "", card3 = "", card4 = "", card5 = "";
            if (bot.turn != player.turn) bot.turn =player.turn;
            else { game.turn = player.turn; }
            if (round == 1)
            {
            FirstCard:
                card1 = GameClass.DrawCards(ref game.card1, ref game.suit1);
                if (((game.card1 == player.Card1) && (game.suit1 == player.Card1Suit)) || ((game.card1 == player.Card2) && (game.suit1 == player.Card2Suit))
                    || ((game.card1 == bot.Card1) && (game.suit1 == bot.Card1Suit)) || ((game.card1 == bot.Card2) && (game.suit1 == bot.Card2Suit))) goto FirstCard;
                else { this.Card1.Text = card1; }
            SecondCard:
                card2 = GameClass.DrawCards(ref game.card2, ref game.suit2);
                if (((game.card1 == player.Card1) && (game.suit1 == player.Card1Suit)) || ((game.card1 == player.Card2) && (game.suit1 == player.Card2Suit)) ||
                    ((game.card1 == bot.Card1) && (game.suit1 == bot.Card1Suit)) || ((game.card1 == bot.Card2) && (game.suit1 == bot.Card2Suit)) || ((game.card2 == game.card1) && (game.suit2 == game.suit1))) goto SecondCard;
                else { this.Card2.Text = card2; }
            ThirdCard:
                card3 = GameClass.DrawCards(ref game.card3, ref game.suit3);
                if (((game.card1 == player.Card1) && (game.suit1 == player.Card1Suit)) || ((game.card1 == player.Card2) && (game.suit1 == player.Card2Suit)) ||
                    ((game.card1 == bot.Card1) && (game.suit1 == bot.Card1Suit)) || ((game.card1 == bot.Card2) && (game.suit1 == bot.Card2Suit)) || ((game.card3 == game.card1) && (game.suit3 == game.suit1)) ||
                    ((game.card3 == game.card2) && (game.suit3 == game.suit2))) goto ThirdCard;
                else { this.Card3.Text = card3; }
                round = 2;
            }
            else if (round == 2)
            {
            FourthCard:
                card4 = GameClass.DrawCards(ref game.card4, ref game.suit4);
                if (((game.card1 == player.Card1) && (game.suit1 == player.Card1Suit)) || ((game.card1 == player.Card2) && (game.suit1 == player.Card2Suit)) ||
                    ((game.card1 == bot.Card1) && (game.suit1 == bot.Card1Suit)) || ((game.card1 == bot.Card2) && (game.suit1 == bot.Card2Suit)) || ((game.card3 == game.card1) && (game.suit3 == game.suit1)) ||
                    ((game.card3 == game.card2) && (game.suit3 == game.suit2)) || ((game.card4 == game.card3) && (game.suit4 == game.suit3)) || ((game.card4 == game.card1) && (game.suit4 == game.suit1)) ||
                    ((game.card4 == game.card2) && (game.suit4 == game.suit2))) goto FourthCard;
                else { this.Card4.Text = card4; round = 3; }
            }
            else if (round == 3)
            {
            FifthCard:
                card5 = GameClass.DrawCards(ref game.card5, ref game.suit5);
                if (((game.card1 == player.Card1) && (game.suit1 == player.Card1Suit)) || ((game.card1 == player.Card2) && (game.suit1 == player.Card2Suit)) ||
                    ((game.card1 == bot.Card1) && (game.suit1 == bot.Card1Suit)) || ((game.card1 == bot.Card2) && (game.suit1 == bot.Card2Suit)) || ((game.card3 == game.card1) && (game.suit3 == game.suit1)) ||
                    ((game.card3 == game.card2) && (game.suit3 == game.suit2)) || ((game.card4 == game.card3) && (game.suit4 == game.suit3)) || ((game.card4 == game.card1) && (game.suit4 == game.suit1)) ||
                    ((game.card4 == game.card2) && (game.suit4 == game.suit2)) || ((game.card5 == game.card4) && (game.suit5 == game.suit4)) || ((game.card5 == game.card3) && (game.suit5 == game.suit3)) ||
                    ((game.card5 == game.card2) && (game.suit5 == game.suit2)) || ((game.card5 == game.card1) && (game.suit5 == game.suit1))) goto FifthCard;
                else { this.Card5.Text = card5; round = 4; }
            }
            else if (round == 4) 
            {
                this.BotCard1.Text = $"{bot.Card1} of {bot.Card1Suit}";
                this.BotCard2.Text = $"{bot.Card2} of {bot.Card2Suit}";
                int PLcomb = 0, Bcomb = 0;
                GameClass.CheckCombs(ref PLcomb, player.Card1, player.Card2, player.Card1Suit, player.Card2Suit, game.card1, game.suit1, game.card2, game.suit2, game.card3, game.suit3, game.card4, game.suit4, game.card5, game.suit5);
                GameClass.CheckCombs(ref Bcomb, bot.Card1, bot.Card2, bot.Card1Suit, bot.Card2Suit, game.card1, game.suit1, game.card2, game.suit2, game.card3, game.suit3, game.card4, game.suit4, game.card5, game.suit5);
                if (GameClass.CompareCombs(PLcomb, Bcomb)==1)
                {
                    player.Money += game.bank;
                    game.bank = 0;
                    player.bet = 0;
                    player.RaiseBet = 0;
                    bot.RaiseBet = 0;
                    bot.bet = 0;
                    game.bet = 0;
                    MessageBox.Show("You won!");
                    Window_Loaded(CheckButton, e);
                }
                else if(GameClass.CompareCombs(PLcomb, Bcomb)==0)
                {
                    bot.Money += game.bank;
                    game.bank = 0;
                    player.bet = 0;
                    player.RaiseBet = 0;
                    bot.RaiseBet = 0;
                    bot.bet = 0;
                    game.bet = 0;
                    MessageBox.Show("You Lose!");
                    Window_Loaded(CheckButton, e);
                }
                else
                {
                    bot.Money += (game.bank) / 2;
                    player.Money += (game.bank) / 2;
                    game.bank = 0;
                    player.bet = 0;
                    player.RaiseBet = 0;
                    bot.RaiseBet = 0;
                    bot.bet = 0;
                    game.bet = 0;
                    MessageBox.Show("Draw!");
                    Window_Loaded(CheckButton, e);
                }
            }
        }
        //Уравнивание ставки
        private void CallButton_Click(object sender, RoutedEventArgs e)
        {
            player.bet += (game.bet - player.bet);
            player.Money -= player.bet;
            game.bet = player.bet;
            if (bot.bet != game.bet)
            {
                bot.bet += (game.bet - bot.bet);
                bot.Money -= bot.bet;
                game.bank += (player.bet + bot.bet);
            }
            else
            {
                player.turn += 1;
                bot.turn += 1;
                game.turn += 1;
            }
            this.BotCard1.Text = $"{bot.Card1} of {bot.Card1Suit}";
            this.BotCard2.Text = $"{bot.Card2} of {bot.Card2Suit}";
        }
        //Подъём ставок
        private void RaiseButton_Click(object sender, RoutedEventArgs e)
        {
            if (player.RaiseBet >= player.Money) MessageBox.Show($"You don't have that much money. Your maximum bet is {player.Money}");
            else
            {
                player.RaiseBet = Convert.ToInt32(this.RaiseBetBlock.Text);
                player.bet += player.RaiseBet;
                player.Money -= player.bet;
                this.MoneyText.Text = player.Money.ToString();
                player.turn += 1;
                if (bot.bet != player.bet)
                {
                    if (bot.Money < player.RaiseBet)
                    { bot.bet = bot.Money; bot.turn += 1; bot.Money = 0; }
                    else { bot.bet += (player.bet - bot.bet); bot.turn += 1; bot.Money -= bot.bet; this.BotMoney.Text = bot.Money.ToString(); }
                }
                game.bank += (player.bet + bot.bet);
                player.RaiseBet = 0;
                bot.RaiseBet = 0;
                player.bet = 0;
                bot.bet = 0;
                this.BankText.Text = game.bank.ToString();
                if (player.turn == bot.turn) game.turn += 1;
            }

        }
        //Сброс карт
        private void FoldButton_Click(object sender, RoutedEventArgs e)
        {
            bot.Money += game.bank;
            game.bank = 0;
            player.RaiseBet = 0;
            player.bet = 0;
            bot.RaiseBet = 0;
            bot.bet = 0;
            this.BankText.Text = game.bank.ToString();
            Window_Loaded(FoldButton, e);
        }
        //Раздача карт игрокам и раздача денег
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MoneyText.Text = ($"Money: {Convert.ToString(player.Money)}");
            this.BankText.Text = ($"Bank: {Convert.ToString(game.bank)}");
            this.BotMoney.Text = ($"Bot: {Convert.ToString(bot.Money)}");
            string PlCard1 = "";
            string PlCard2 = "";
            string PlCard1Suit = "";
            string PlCard2Suit = "";
            int num1, num2, suit1, suit2, num3, num4, suit3, suit4;
            Random rnd = new Random();
            num1 = rnd.Next(2, 14);
            switch (num1)
            {
                case 2:
                    PlCard1 = "Two";
                    break;
                case 3:
                    PlCard1 = "Three";
                    break;
                case 4:
                    PlCard1 = "Four";
                    break;
                case 5:
                    PlCard1 = "Five";
                    break;
                case 6:
                    PlCard1 = "Six";
                    break;
                case 7:
                    PlCard1 = "Seven";
                    break;
                case 8:
                    PlCard1 = "Eignt";
                    break;
                case 9:
                    PlCard1 = "Nine";
                    break;
                case 10:
                    PlCard1 = "Ten";
                    break;
                case 11:
                    PlCard1 = "Jack";
                    break;
                case 12:
                    PlCard1 = "Queen";
                    break;
                case 13:
                    PlCard1 = "King";
                    break;
                case 14:
                    PlCard1 = "Ace";
                    break;

            }
            suit1 = rnd.Next(0, 3);
            switch (suit1)
            {
                case 0:
                    PlCard1Suit = "clubs";
                    break;
                case 1:
                    PlCard1Suit = "diamonds";
                    break;
                case 2:
                    PlCard1Suit = "spades";
                    break;
                case 3:
                    PlCard1Suit = "hearts";
                    break;
            }
            SecondPL:
            num2 = rnd.Next(2, 14);
            switch (num2)
            {
                case 2:
                    PlCard2 = "Two";
                    break;
                case 3:
                    PlCard2 = "Three";
                    break;
                case 4:
                    PlCard2 = "Four";
                    break;
                case 5:
                    PlCard2 = "Five";
                    break;
                case 6:
                    PlCard2 = "Six";
                    break;
                case 7:
                    PlCard2 = "Seven";
                    break;
                case 8:
                    PlCard2 = "Eignt";
                    break;
                case 9:
                    PlCard2 = "Nine";
                    break;
                case 10:
                    PlCard2 = "Ten";
                    break;
                case 11:
                    PlCard2 = "Jack";
                    break;
                case 12:
                    PlCard2 = "Queen";
                    break;
                case 13:
                    PlCard2 = "King";
                    break;
                case 14:
                    PlCard2 = "Ace";
                    break;
            }
            suit2 = rnd.Next(0, 3);
            switch (suit2)
            {
                case 0:
                    PlCard2Suit = "clubs";
                    break;
                case 1:
                    PlCard2Suit = "diamonds";
                    break;
                case 2:
                    PlCard2Suit = "spades";
                    break;
                case 3:
                    PlCard2Suit = "hearts";
                    break;
            }
            if ((num2 == num1) && (suit2 == suit1)) goto SecondPL;
            this.PlCArd1.Text = ($"{PlCard1} of {PlCard1Suit}");
            this.PlCArd2.Text = ($"{PlCard2} of {PlCard2Suit}");
            player.Card1 = PlCard1;
            player.Card2 = PlCard2;
            player.Card1Suit = PlCard1Suit;
            player.Card2Suit = PlCard2Suit;
            string BCard1 = "";
            string BCard2 = "";
            string BCard1Suit = "";
            string BCard2Suit = "";
            num3 = rnd.Next(2, 14);
            switch (num3)
            {
                case 2:
                    BCard1 = "Two";
                    break;
                case 3:
                    BCard1 = "Three";
                    break;
                case 4:
                    BCard1 = "Four";
                    break;
                case 5:
                    BCard1 = "Five";
                    break;
                case 6:
                    BCard1 = "Six";
                    break;
                case 7:
                    BCard1 = "Seven";
                    break;
                case 8:
                    BCard1 = "Eignt";
                    break;
                case 9:
                    BCard1 = "Nine";
                    break;
                case 10:
                    BCard1 = "Ten";
                    break;
                case 11:
                    BCard1 = "Jack";
                    break;
                case 12:
                    BCard1 = "Queen";
                    break;
                case 13:
                    BCard1 = "King";
                    break;
                case 14:
                    BCard1 = "Ace";
                    break;

            }
            suit3 = rnd.Next(0, 4);
            switch (suit3)
            {
                case 0:
                    BCard1Suit = "clubs";
                    break;
                case 1:
                    BCard1Suit = "diamonds";
                    break;
                case 2:
                    BCard1Suit = "spades";
                    break;
                case 3:
                    BCard1Suit = "hearts";
                    break;
            }
            SecondB:
            num4 = rnd.Next(2, 14);
            switch (num4)
            {
                case 2:
                    BCard2 = "Two";
                    break;
                case 3:
                    BCard2 = "Three";
                    break;
                case 4:
                    BCard2 = "Four";
                    break;
                case 5:
                    BCard2 = "Five";
                    break;
                case 6:
                    BCard2 = "Six";
                    break;
                case 7:
                    BCard2 = "Seven";
                    break;
                case 8:
                    BCard2 = "Eignt";
                    break;
                case 9:
                    BCard2 = "Nine";
                    break;
                case 10:
                    BCard2 = "Ten";
                    break;
                case 11:
                    BCard2 = "Jack";
                    break;
                case 12:
                    BCard2 = "Queen";
                    break;
                case 13:
                    BCard2 = "King";
                    break;
                case 14:
                    BCard2 = "Ace";
                    break;
            }
            suit4 = rnd.Next(0, 4);
            switch (suit4)
            {
                case 0:
                    BCard2Suit = "clubs";
                    break;
                case 1:
                    BCard2Suit = "diamonds";
                    break;
                case 2:
                    BCard2Suit = "spades";
                    break;
                case 3:
                    BCard2Suit = "hearts";
                    break;
            }
            if (((num4 == num3) && (suit4 == suit3))&&(((num4==num2)||(num4==num1))&&((suit4==suit2)||(suit4==suit1)))) goto SecondB;
            bot.Card1 = BCard1;
            bot.Card2 = BCard2;
            bot.Card1Suit = BCard1Suit;
            bot.Card2Suit = BCard2Suit;
            round = 1;
            this.Card1.Text = "";
            this.Card2.Text = "";
            this.Card3.Text = "";
            this.Card4.Text = "";
            this.Card5.Text = "";
            this.BotCard1.Text = "";
            this.BotCard2.Text = "";
        }
    }
}