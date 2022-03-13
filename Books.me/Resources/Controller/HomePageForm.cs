using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using Books.me.Resources.Models;
using Books.me.Resources.Controller;
using ComponentFactory.Krypton;

namespace Books.me.Resources.Controller
{
    public partial class HomePageForm : Form
    {

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
        private DatabaseConnection databaseConnection;
        public HomePageForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            databaseConnection = new DatabaseConnection();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"WELCOME, {Globals.currentUser.ToUpper()}";
            switch (Globals.pageCount)
            {
                case 0:
                    this.leftBook.Image = Books.me.Properties.Resources.TheSubtleArtOfNotGivingAFuck_bk1;
                    this.middleBook.Image = Books.me.Properties.Resources.TheAlchemist_bk2;
                    this.rightBook.Image = Books.me.Properties.Resources.ShadowAndBone_bk3;
                    break;
                case 1:
                    this.leftBook.Image = Books.me.Properties.Resources.IT_bk4;
                    this.middleBook.Image = Books.me.Properties.Resources.TheNatureOfSpaceAndTime_bk5;
                    this.rightBook.Image = Books.me.Properties.Resources.ElonMusk_bk6;
                    break;
                case 2:
                    this.leftBook.Image = Books.me.Properties.Resources.TheLightningTief_bk7;
                    this.middleBook.Image = Books.me.Properties.Resources.PodIgoto_bk8;
                    this.rightBook.Image = Books.me.Properties.Resources.MurderOnTheOrientExpress_bk9;
                    break;
                case 3:
                    this.leftBook.Image = Books.me.Properties.Resources.TheAdventuresOfArseneLupinGentleman_Thief_bk10;
                    this.middleBook.Image = Books.me.Properties.Resources.Hamlet_bk11;
                    this.rightBook.Image = Books.me.Properties.Resources.ThePrinceAndThePauper_bk12;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rightSlide_Click(object sender, EventArgs e)
        {
            switch (Globals.pageCount)
            {
                case 0:
                    this.leftBook.Image = Books.me.Properties.Resources.IT_bk4;
                    this.middleBook.Image = Books.me.Properties.Resources.TheNatureOfSpaceAndTime_bk5;
                    this.rightBook.Image = Books.me.Properties.Resources.ElonMusk_bk6;
                    Globals.pageCount++;
                    break;
                case 1:
                    this.leftBook.Image = Books.me.Properties.Resources.TheLightningTief_bk7;
                    this.middleBook.Image = Books.me.Properties.Resources.PodIgoto_bk8;
                    this.rightBook.Image = Books.me.Properties.Resources.MurderOnTheOrientExpress_bk9;
                    Globals.pageCount++;
                    break;
               case 2:
                    this.leftBook.Image = Books.me.Properties.Resources.TheAdventuresOfArseneLupinGentleman_Thief_bk10;
                    this.middleBook.Image = Books.me.Properties.Resources.Hamlet_bk11;
                    this.rightBook.Image = Books.me.Properties.Resources.ThePrinceAndThePauper_bk12;
                    Globals.pageCount++;
                    break;
                case 3:
                    this.leftBook.Image = Books.me.Properties.Resources.TheSubtleArtOfNotGivingAFuck_bk1;
                    this.middleBook.Image = Books.me.Properties.Resources.TheAlchemist_bk2;
                    this.rightBook.Image = Books.me.Properties.Resources.ShadowAndBone_bk3;
                    Globals.pageCount = 0;
                    break;
            }
        }
        private void leftSlide_Click(object sender, EventArgs e)
        {
            switch (Globals.pageCount)
            {
                case 0:
                    this.leftBook.Image = Books.me.Properties.Resources.TheAdventuresOfArseneLupinGentleman_Thief_bk10;
                    this.middleBook.Image = Books.me.Properties.Resources.Hamlet_bk11;
                    this.rightBook.Image = Books.me.Properties.Resources.ThePrinceAndThePauper_bk12;
                    Globals.pageCount = 3;
                    break;
                case 3:
                    this.leftBook.Image = Books.me.Properties.Resources.TheLightningTief_bk7;
                    this.middleBook.Image = Books.me.Properties.Resources.PodIgoto_bk8;
                    this.rightBook.Image = Books.me.Properties.Resources.MurderOnTheOrientExpress_bk9;
                    Globals.pageCount--;
                    break;
                case 2:
                    this.leftBook.Image = Books.me.Properties.Resources.IT_bk4;
                    this.middleBook.Image = Books.me.Properties.Resources.TheNatureOfSpaceAndTime_bk5;
                    this.rightBook.Image = Books.me.Properties.Resources.ElonMusk_bk6;
                    Globals.pageCount--;
                    break;
                case 1:
                    this.leftBook.Image = Books.me.Properties.Resources.TheSubtleArtOfNotGivingAFuck_bk1;
                    this.middleBook.Image = Books.me.Properties.Resources.TheAlchemist_bk2;
                    this.rightBook.Image = Books.me.Properties.Resources.ShadowAndBone_bk3;
                    Globals.pageCount--;
                    break;
            }
        }

        private void leftBook_Click(object sender, EventArgs e)
        {
            switch (Globals.pageCount)
            {
                case 0:
                    GetBookInfoFromDb(1);
                    break;
                case 1:
                    GetBookInfoFromDb(4);
                    break;
                case 2:
                    GetBookInfoFromDb(7);
                    break;
                case 3:
                    GetBookInfoFromDb(10);
                    break;
            }
            CloseHomePage();
        }
        private void middleBook_Click(object sender, EventArgs e)
        {
            switch (Globals.pageCount)
            {
                case 0:
                    GetBookInfoFromDb(2);
                    break;
                case 1:
                    GetBookInfoFromDb(5);
                    break;
                case 2:
                    GetBookInfoFromDb(8);
                    break;
                case 3:
                    GetBookInfoFromDb(11);
                    break;
            }
            CloseHomePage();
        }

        private void rightBook_Click(object sender, EventArgs e)
        {
            switch (Globals.pageCount)
            {
                case 0:
                    GetBookInfoFromDb(3);
                    break;
                case 1:
                    GetBookInfoFromDb(6);
                    break;
                case 2:
                    GetBookInfoFromDb(9);
                    break;
                case 3:
                    GetBookInfoFromDb(12);
                    break;
            }
            CloseHomePage();
        }
        public void GetBookInfoFromDb(int bookId)
        {
            databaseConnection.OpenConnection();
            string query = $"SELECT * FROM books WHERE books.book_id = {bookId}";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Book.Id = 0;
                Book.Title = "";
                Book.Author = "";
                Book.Description = "";
                Book.Genre = "";
                Book.Type = "";
                Book.Pages = "";
                Book.TimeToRead = "";
                Book.Rating = "";
                Book.Id = (int)reader.GetValue(0);
                Book.Title = (string)reader.GetValue(1);
                Book.Author = (string)reader.GetValue(2);
                Book.Description = (string)reader.GetValue(3);
                Book.Genre = (string)reader.GetValue(4);
                Book.Type = (string)reader.GetValue(5);
                Book.Pages = (string)reader.GetValue(6);
                Book.TimeToRead = (string)reader.GetValue(7);
                Book.Rating = (string)reader.GetValue(8);
                databaseConnection.CloseConnection();
            }
            else
            {
                databaseConnection.CloseConnection();
            }

        }
        public void CloseHomePage()
        {
            this.Hide();
            SingleBookForm libraryForm = new SingleBookForm();
            libraryForm.Closed += (s, args) => this.Close();
            libraryForm.Show();
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            CloseHomePage();
        }
    }

}
