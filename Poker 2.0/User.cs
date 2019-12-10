using System;
using System.Security.Cryptography;
using System.Text;

namespace Poker_2._0
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public static string GetHash(string text)
        {
            var sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
            return Convert.ToBase64String(hash);
        }
    }
}
