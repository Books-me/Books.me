using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.me.Resources.Models
{
    public class User
    {
        private string username;
        private string password;
        private static int booksAdded;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public static int BooksAdded
        {
            get { return booksAdded; }
            set { booksAdded = value; }
        }
    }
}
