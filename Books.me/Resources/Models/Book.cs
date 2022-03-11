using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.me.Resources.Models
{
    internal class Book
    {
        private static int id;
        private static string title;
        private static string author;
        private static string description;
        private static string genre;
        private static string type;
        private static string pages;
        private static string timeToRead;
        private static string rating;
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }
        public static string Author
        {
            get { return author; }
            set { author = value; }
        }
        public static string Description
        {
            get { return description; }
            set { description = value; }
        }
        public static string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public static string Type
        {
            get { return type; }
            set { type = value; }
        }
        public static string Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public static string TimeToRead
        {
            get { return timeToRead; }
            set { timeToRead = value; }
        }
        public static string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
