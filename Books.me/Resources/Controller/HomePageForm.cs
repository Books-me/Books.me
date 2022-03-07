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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

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
    }
}
