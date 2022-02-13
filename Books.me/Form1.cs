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



namespace Books.me
{
    public partial class Form1 : Form
    {

        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form1()
        {
            server = "sql11.freesqldatabase.com";
            database = "sql11472544";
            uid = "sql11472544";
            password = "U399XUYDdH";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn =new MySqlConnection(connString);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            if (IsLogin(user, password))
            {
                MessageBox.Show($"Welcome {user} !");
            }
            else
            {
                MessageBox.Show($"{user} does not exist or password is incorrect!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            if (Register(user, password))
            {
                MessageBox.Show($"User {user}has been created!");
            }
            else
            {
                MessageBox.Show($"User {user} has never been created!");
            }
            

        }
        public bool Register(string user, string pass)
        {
            string query = $"INSERT INTO uinfo (id,username,password) VALUES ('','{user}', '{pass}');";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new  MySqlCommand(query,conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        return false;
                    }
                    
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        public  bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM uinfo WHERE username='{user}' AND password= '{pass}';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;

                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {

                conn.Close();
                return false;
            }
        }





        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("Incorrect credentials!");
                        break;
                }
                return false;
            }
        }
    }
}
