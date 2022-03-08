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
        public HomePageForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"WELCOME, {Globals.currentUser.ToUpper()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.OpenConnection();
            
            string query = "INSERT INTO bookToUser (id, bookIdFk, userIdFk) VALUES ('', 1, 1), ('', 2, 1)";
            //string query1 = "INSERT INTO books(book_id, title, author, description, genre, type, pages, time, rating, coverPhoto) VALUES ('', 'peshko', 'peshko','peshko','peshko','peshko','peshko','peshko','peshko','peshko'), ('', 'peshko1', 'peshko','peshko','peshko','peshko','peshko','peshko','peshko','peshko');";
            string query2 = "SELECT books FROM books JOIN bookToUser on books.book_id = bookToUser.bookIdFk WHERE bookToUser.userIdFk = 1";
            MySqlCommand cmd = new MySqlCommand(query, dbCon.conn);
            cmd.ExecuteNonQuery();*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
