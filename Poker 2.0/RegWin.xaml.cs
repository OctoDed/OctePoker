using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Poker_2._0
{
    public partial class RegWin : Window
    {
        public RegWin()
        {
            InitializeComponent();
        }

        List<User> user = new List<User>();
        private void LoadUser()
        {
            user = DBmangment.LoadUser();
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string logpath = $"D:\\учебная херобрань\\програмки\\Poker 2.0\\Poker 2.0\\Players\\{this.loginText.Text}.txt";
            string paspath = $"D:\\учебная херобрань\\програмки\\Poker 2.0\\Poker 2.0\\Players\\notpass{this.loginText.Text}.txt";
            if ((this.loginText.Text == "") || (this.pass1.Text == "")) MessageBox.Show("Uncorrect login or password");
            else if (!File.Exists(logpath))
            {
                using (FileStream logfile = new FileStream(logpath, FileMode.OpenOrCreate))
                using (StreamWriter writer = new StreamWriter(logfile))
                {
                    writer.WriteLine(this.loginText.Text);
                }
                try
                {
                    using (FileStream pasfile = new FileStream(paspath, FileMode.OpenOrCreate))
                    using (StreamWriter writer = new StreamWriter(pasfile))
                    {
                        writer.WriteLine(User.GetHash(this.pass1.Text));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uncorrect passwoed");
                }
            }
            else MessageBox.Show("User with this login is already exists");
        }

        private void CanelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
