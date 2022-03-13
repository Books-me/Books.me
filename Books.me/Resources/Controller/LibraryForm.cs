using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.me.Resources.Controller;
using MySql.Data.MySqlClient;
using Books.me.Resources.Models;

namespace Books.me.Resources.Controller
{
    public partial class LibraryForm : Form
    {
        private static List<string> AddedBooksId = new List<string>();
        public LibraryForm()
        {
            InitializeComponent();
        }
        private void btnLibraryBack_Click(object sender, EventArgs e)
        {
            CloseLibraryForm();
        }
        public void CloseLibraryForm()
        {
            this.Hide();
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Closed += (s, args) => this.Close();
            homePageForm.Show();
        }
        public static void GetAddedToLibraryBooks()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                if (databaseConnection.OpenConnection())
                {
                    string query = $"SELECT title FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = {Globals.currentID}";
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddedBooksId.Add(reader["title"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                databaseConnection.CloseConnection();

                throw ex;
            }
        }
        public void DisplayAddedBooks(int booksAmount)
        {
            switch (booksAmount)
            {
                case 1:
                    string addedBook1 = AddedBooksId[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    break;
                case 2:
                    addedBook1 = AddedBooksId[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook2 = AddedBooksId[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    break;
                case 3:
                    addedBook1 = AddedBooksId[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksId[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook3 = AddedBooksId[2];
                    addedBook3 = string.Join("", addedBook3.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);
                    break;
                case 4:
                    addedBook1 = AddedBooksId[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksId[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook3 = AddedBooksId[2];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook4 = AddedBooksId[3];
                    addedBook4 = string.Join("", addedBook4.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);
                    this.libraryBook4.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook4, Properties.Resources.Culture);
                    break;
                case 5:
                    addedBook1 = AddedBooksId[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksId[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook3 = AddedBooksId[2];
                    addedBook3 = string.Join("", addedBook3.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook4 = AddedBooksId[3];
                    addedBook4 = string.Join("", addedBook4.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook5 = AddedBooksId[4];
                    addedBook5 = string.Join("", addedBook5.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);
                    this.libraryBook4.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook4, Properties.Resources.Culture);
                    this.libraryBook5.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook5, Properties.Resources.Culture);
                    break;
            }
        }
        private void LibraryForm_Load(object sender, EventArgs e)
        {
            GetAddedToLibraryBooks();
            DisplayAddedBooks(AddedBooksId.Count);
        }
    }
}
