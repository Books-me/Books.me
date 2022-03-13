using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.me.Resources.Models;
using MySql.Data.MySqlClient;

namespace Books.me.Resources.Controller
{
    public partial class SingleBookForm : Form
    {
        //rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public SingleBookForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void SingleBookForm_Load(object sender, EventArgs e)
        {
            DisplayCurrentBookData();

            CheckIfBookAdded();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CloseSingleBookForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAddToLibrary_Click(object sender, EventArgs e)
        {
            if (buttonAddToLibrary.Text == "Add To Library")
            {
                buttonAddToLibrary.Enabled = true;
                InsertBookIntoDb();
                buttonAddToLibrary.Enabled = false; 
            }
            else if (buttonAddToLibrary.Text == "Delete From Library")
            {
                buttonAddToLibrary.Enabled = true;
                DeleteBookFromDb();
                buttonAddToLibrary.Enabled = false; 
            }
        }
        public void DisplayCurrentBookData()
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

            lblBookName.Text = Book.Title;
            lblAuthor.Text = Book.Author;
            lblDescription.Text = Book.Description;
            lblGenre.Text = "Genre: " + Book.Genre;
            lblType.Text = "This book is: " + Book.Type;
            lblPageCount.Text = Book.Pages + " Pages";
            lblTimeRead.Text = Book.TimeToRead + " Hours";
        }
        public void CheckIfBookAdded()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = $"SELECT book_id FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = {Globals.currentID}";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
            List<int> AddedBooksId = new List<int>();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (databaseConnection.OpenConnection())
                {
                    while (reader.Read())
                    {
                        AddedBooksId.Add(Int32.Parse(reader["book_id"].ToString()));
                    }
                    this.Refresh();

                    if (AddedBooksId.Contains(Book.Id))
                    {
                        buttonAddToLibrary.Text = "Delete From Library";

                        reader.Close();
                        databaseConnection.CloseConnection();
                    }
                    else
                    {
                        buttonAddToLibrary.Text = "Add To Library";
                        buttonAddToLibrary.Refresh();

                        reader.Close();
                        databaseConnection.CloseConnection();
                    }
                }
                else
                {
                    reader.Close();
                    databaseConnection.CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                reader.Close();
                databaseConnection.CloseConnection();

                throw ex;
            }
        }
        public void CloseSingleBookForm()
        {
            this.Hide();
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Closed += (s, args) => this.Close();
            homePageForm.Show();
        }
        public void InsertBookIntoDb()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                string query = $"INSERT INTO bookToUser (id, bookIdFk, userIdFk) VALUES ('', {Book.Id}, {Globals.currentID})";
                if (databaseConnection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    cmd.ExecuteNonQuery();
                    databaseConnection.CloseConnection();
                }
                else
                {
                    databaseConnection.CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                databaseConnection.CloseConnection();
                throw ex;
            }
        }
        public void DeleteBookFromDb()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                if (databaseConnection.OpenConnection())
                {
                    string query = $"DELETE FROM bookToUser WHERE bookToUser.bookIdFk = {Book.Id}";

                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    cmd.ExecuteNonQuery();
                    databaseConnection.CloseConnection();
                }
                else
                {
                    databaseConnection.CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                databaseConnection.CloseConnection();
                throw ex;
            }
        }
    }
}
