using Poker_2._0.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;


namespace Poker_2._0
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        GameWin gamewin = new GameWin();
        List<User> user = new List<User>();
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string logpath = $"D:\\учебная херобрань\\програмки\\Poker 2.0\\Poker 2.0\\Players\\{this.LoginBox.Text}.txt";
            string paspath = $"D:\\учебная херобрань\\програмки\\Poker 2.0\\Poker 2.0\\Players\\notpass{this.LoginBox.Text}.txt";
            try
            {
                using (FileStream logfile = new FileStream(logpath, FileMode.Open))
                using (StreamReader logreader = new StreamReader(logfile))
                using (FileStream pasfile = new FileStream(paspath, FileMode.Open))
                using (StreamReader pasreader = new StreamReader(pasfile))
                {
                    if ((this.LoginBox.Text != logreader.ReadLine()) || (User.GetHash(this.PassBox.Text) != pasreader.ReadLine()))
                    {
                        MessageBox.Show("Cannot find this login or password.\nTry again.");
                    }
                    else
                    {
                        this.Close();
                        gamewin.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find this user\nTry again");
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegWin reg = new RegWin();
            reg.Show();
        }
        
    }
}