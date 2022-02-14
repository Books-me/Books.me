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


namespace Books.me
{
    public partial class LoginForm : Form
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
        
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public LoginForm()
        {
            server = "sql11.freesqldatabase.com";
            database = "sql11472544";
            uid = "sql11472544";
            password = "U399XUYDdH";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn =new MySqlConnection(connString);

            InitializeComponent();


            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPass.Text;
            if (IsLogin(user, password))
            {
                MessageBox.Show($"Welcome {user} !");
            }
            if (user == "" && password == "")
            {
                waringLabel.Text = "Please enter credentials!";
            }
            else
            {
                waringLabel.Text = $"{user} non-existent or incorrect credentials!";
            }
        }

       

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPass.Text;
            if (Register(user, password))
            {
                MessageBox.Show($"{user}has been created!\n Log In your new account");
            }
            else
            {
                MessageBox.Show($"{user} has never been created!");
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

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtUsername.Focus();    
        }

        private void waringLabel_Click(object sender, EventArgs e)
        {

        }

        private void switchLabel_Click(object sender, EventArgs e)
        {
            loginButton.Visible=true;
            registerButton.Visible = false;
            switchLabel.Visible = false;
            waringLabel.Text = "Sign in to your existing account";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
