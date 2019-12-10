using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_2._0
{
    class DBmangment
    {
        public static List<User> LoadUser()
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnetcionString()))
                {
                var output = cnn.Query<User>("select * from Users", new DynamicParameters());
                return output.ToList();
                }
            }
        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnetcionString()))
            {
                var output = cnn.Query<User>("Select * from Users", new DynamicParameters());
                cnn.Execute("insert into Users (Login, Password) values (@Login, @Password)", user);
            }
        }
        private static string LoadConnetcionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
