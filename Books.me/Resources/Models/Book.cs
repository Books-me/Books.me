using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.me.Resources.Models
{
    internal class Book
    {
        private string title;
        private string author;
        private string description;
        private string genre;
        private string type;
        private string pages;
        private string timeToRead;
        private string rating;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public string TimeToRead
        {
            get { return timeToRead; }
            set { timeToRead = value; }
        }
        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
