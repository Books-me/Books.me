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
        private DatabaseConnection databaseConnection;
        public LoginForm()
        {
            databaseConnection = new DatabaseConnection();
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPass.Text);
            if (IsLogin(user.Username, user.Password))
            {
                waringLabel.Text = $"{user.Username} is logged in";
            }
            else
            {
                waringLabel.Text = $"{user.Username} non-existent or incorrect credentials!";
            }
            if (user.Username == "" && user.Password == "")
            {
                waringLabel.ForeColor = Color.Red;
                waringLabel.Text = "Please enter credentials!";
            }

        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPass.Text);
            string query = $"SELECT * FROM uinfo WHERE username='{user}';";

            if (Register(user.Username, user.Password))
            {
                waringLabel.ForeColor = Color.Green;
                waringLabel.Text = $"{user.Username}has been created!\n Log In your new account";
            }
            else
            {
                waringLabel.Text = $"This username is taken!";
            }

        }

        //encryption
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }
 
        public bool Register(string user, string pass)
        {
            string key = "b14ca5898a4e4133bbce2ea2315a1916";

            var encryptedPassword = EncryptString(key, pass);

            string query = $"INSERT INTO uinfo (id,username,password) VALUES ('','{user}', '{encryptedPassword}');";
            try
            {
                if (databaseConnection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        databaseConnection.conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        return false;
                    }
                }
                else
                {
                    databaseConnection.conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                databaseConnection.conn.Close();
                return false;
            }
        }

        public bool IsLogin(string user, string pass)
        {

            string key = "b14ca5898a4e4133bbce2ea2315a1916";
            var encryptedPassword = EncryptString(key, pass);
            string query = $"SELECT * FROM uinfo WHERE username='{user}' AND password= '{encryptedPassword}';";
            try
            {
                if (databaseConnection.OpenConnection())
                {
                    databaseConnection.conn.Ping();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        databaseConnection.conn.Close();
                        return true;

                    }
                    else
                    {
                        reader.Close();
                        databaseConnection.conn.Close();
                        return false;
                    }
                }
                else
                {
                    databaseConnection.conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {

                databaseConnection.conn.Close();
                return false;
            }
        }

        private void Header_Click(object sender, EventArgs e)
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
            waringLabel.Text = "";
        }
        private void switchLabel_Click(object sender, EventArgs e)
        {
            loginButton.Visible = true;
            registerButton.Visible = false;
            switchLabel.Visible = false;
            backToSignIn.Visible = true;
            waringLabel.ForeColor = Color.Green;
            waringLabel.Text = "Sign in to your existing account";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void backToSignIn_Click(object sender, EventArgs e)
        {
            loginButton.Visible = false;
            registerButton.Visible = true;
            switchLabel.Visible = true;
            backToSignIn.Visible = false;
            waringLabel.Text = "";
        }
        private void showPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            showPass.Visible = true;
            hidePassword.Visible = true;
        }
        private void hidePassword_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            hidePassword.Visible = false;
        }
    }
}
