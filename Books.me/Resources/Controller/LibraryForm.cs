using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Books.me.Resources.Models;
using System.Runtime.InteropServices;

namespace Books.me.Resources.Controller
{
    public partial class LibraryForm : Form
    {
        public static List<string> AddedBooksName = new List<string>();

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
        public LibraryForm()
        {
            InitializeComponent();
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
                    AddedBooksName.Clear();
                    string query = $"SELECT title FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = {Globals.currentID}";
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddedBooksName.Add(reader["title"].ToString());
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
                    string addedBook1 = AddedBooksName[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                    libraryBook1.Enabled = true;

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    break;
                case 2:
                    addedBook1 = AddedBooksName[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook2 = AddedBooksName[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);

                    libraryBook1.Enabled = true;
                    libraryBook2.Enabled = true;
                    break;
                case 3:
                    addedBook1 = AddedBooksName[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksName[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook3 = AddedBooksName[2];
                    addedBook3 = string.Join("", addedBook3.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);

                    libraryBook1.Enabled = true;
                    libraryBook2.Enabled = true;
                    libraryBook3.Enabled = true;
                    break;
                case 4:
                    addedBook1 = AddedBooksName[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksName[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook3 = AddedBooksName[2];
                    addedBook3 = string.Join("", addedBook3.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook4 = AddedBooksName[3];
                    addedBook4 = string.Join("", addedBook4.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);
                    this.libraryBook4.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook4, Properties.Resources.Culture);

                    libraryBook1.Enabled = true;
                    libraryBook2.Enabled = true;
                    libraryBook3.Enabled = true;
                    libraryBook4.Enabled = true;
                    break;
                case 5:
                    addedBook1 = AddedBooksName[0];
                    addedBook1 = string.Join("", addedBook1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook2 = AddedBooksName[1];
                    addedBook2 = string.Join("", addedBook2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook3 = AddedBooksName[2];
                    addedBook3 = string.Join("", addedBook3.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    addedBook4 = AddedBooksName[3];
                    addedBook4 = string.Join("", addedBook4.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    string addedBook5 = AddedBooksName[4];
                    addedBook5 = string.Join("", addedBook5.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

                    this.libraryBook1.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook1, Properties.Resources.Culture);
                    this.libraryBook2.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook2, Properties.Resources.Culture);
                    this.libraryBook3.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook3, Properties.Resources.Culture);
                    this.libraryBook4.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook4, Properties.Resources.Culture);
                    this.libraryBook5.Image = (Image)Properties.Resources.ResourceManager.GetObject(addedBook5, Properties.Resources.Culture);

                    libraryBook1.Enabled = true;
                    libraryBook2.Enabled = true;
                    libraryBook3.Enabled = true;
                    libraryBook4.Enabled = true;
                    libraryBook5.Enabled = true;
                    break;
            }
            if (booksAmount>5)
            {
                lblLibraryMaxed.Text = "Added books limit reached!";
            }
        }
        private void LibraryForm_Load(object sender, EventArgs e)
        {
            GetAddedToLibraryBooks();
            DisplayAddedBooks(AddedBooksName.Count);
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            if (PdfReaderForm.DurationRead == 1)
            {
                timeReading.Text = PdfReaderForm.DurationRead + " Minute";
            }
            else
            {
                timeReading.Text = PdfReaderForm.DurationRead + " Minutes";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        private void CloseLibraryFormOpenPDF()
        {
            this.Hide();
            PdfReaderForm pdfReaderForm = new PdfReaderForm();
            pdfReaderForm.Closed += (s, args) => this.Close();
            pdfReaderForm.Show();

        }

        private void libraryBook1_Click(object sender, EventArgs e)
        {
            Globals.BookClicked = 0;
            CloseLibraryFormOpenPDF();
            Dispose();
        }

        private void libraryBook2_Click(object sender, EventArgs e)
        {
            Globals.BookClicked = 1;
            CloseLibraryFormOpenPDF();
        }

        private void libraryBook3_Click(object sender, EventArgs e)
        {
            Globals.BookClicked = 2;
            CloseLibraryFormOpenPDF();
        }

        private void libraryBook4_Click(object sender, EventArgs e)
        {
            Globals.BookClicked = 3;
            CloseLibraryFormOpenPDF();
            Dispose();
        }

        private void libraryBook5_Click(object sender, EventArgs e)
        {
            Globals.BookClicked = 4;
            CloseLibraryFormOpenPDF();
        }

        private void buttonBackToHomePage_Click(object sender, EventArgs e)
        {
            CloseLibraryForm();
        }
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}
