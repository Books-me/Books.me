using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.me.Resources.Models;
using MySql.Data.MySqlClient;

namespace Books.me.Resources.Controller
{
    public partial class SingleBookForm : Form
    {
        public SingleBookForm()
        {
            InitializeComponent();
        }

        private void SingleBookForm_Load(object sender, EventArgs e)
        {
            switch (Book.Title)
            {
                case "The Subtle Art of Not Giving a F*ck":
                    this.singleBookImage.Image = Books.me.Properties.Resources.TheSubtleArtOfNotGivingAFuck_bk1;
                    break;
                case "The Alchemist":
                    this.singleBookImage.Image = Books.me.Properties.Resources.TheAlchemist_bk2;
                    break;
                case "Shadow and Bone":
                    this.singleBookImage.Image = Books.me.Properties.Resources.ShadowAndBone_bk3;
                    break;
                case "IT":
                    this.singleBookImage.Image = Books.me.Properties.Resources.IT_bk4;
                    break;
                case "The Nature of Space and Time":
                    this.singleBookImage.Image = Books.me.Properties.Resources.TheNatureOfSpaceAndTime_bk5;
                    break;
                case "Elon Musk":
                    this.singleBookImage.Image = Books.me.Properties.Resources.ElonMusk_bk6;
                    break;
                case "The Lightning Thief":
                    this.singleBookImage.Image = Books.me.Properties.Resources.TheLightningTief_bk7;
                    break;
                case "Under the Yoke: Pod Igoto":
                    this.singleBookImage.Image = Books.me.Properties.Resources.PodIgoto_bk8;
                    break;
                case "Murder on the Orient Express":
                    this.singleBookImage.Image = Books.me.Properties.Resources.MurderOnTheOrientExpress_bk9;
                    break;
                case "Arsène Lupin, Gentleman-Thief":
                    this.singleBookImage.Image = Books.me.Properties.Resources.TheAdventuresOfArseneLupinGentleman_Thief_bk10;
                    break;
                case "Hamlet":
                    this.singleBookImage.Image = Books.me.Properties.Resources.Hamlet_bk11;
                    break;
                case "The Prince and the Pauper":
                    this.singleBookImage.Image = Books.me.Properties.Resources.ThePrinceAndThePauper_bk12;
                    break;
            }
            lblBookName.Text = Book.Title;
            lblAuthor.Text = Book.Author;
            lblDescription.Text = Book.Description;
            lblGenre.Text = "Genre: " + Book.Genre;
            lblType.Text = "This book is: " + Book.Type;
            lblPageCount.Text = Book.Pages + " Pages";
            lblTimeRead.Text = Book.TimeToRead + " Hours";
            switch (Book.Rating)
            {
                case "4":
                    this.rating.Image = Books.me.Properties.Resources._4star;
                    break;
                case "4.5":
                    this.rating.Image = Books.me.Properties.Resources._4_5star;
                    break;
                case "5":
                    this.rating.Image = Books.me.Properties.Resources._5star;
                    break;

            }
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.OpenConnection();
            string query = $"SELECT book_id FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = {Globals.currentID}";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
            List<int> AddedBooksId = new List<int>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AddedBooksId.Add(Int32.Parse(reader["book_id"].ToString()));
            }
            this.Refresh();

            if (AddedBooksId.Contains(Book.Id))
            {
                btnAddToLibrary.Text = "Added";
            }
            else
            {
                btnAddToLibrary.Text = "Add To Library";
                btnAddToLibrary.Refresh();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Closed += (s, args) => this.Close();
            homePageForm.Show();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pageCountIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToLibrary_Click(object sender, EventArgs e)
        {
            if (btnAddToLibrary.Text == "Add To Library")
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                databaseConnection.OpenConnection();

                string query = $"INSERT INTO bookToUser (id, bookIdFk, userIdFk) VALUES ('', {Book.Id}, {Globals.currentID})";
                //string query2 = "SELECT books FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = 1";

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                cmd.ExecuteNonQuery();
                databaseConnection.CloseConnection();
            }
            
        }
    }
}
