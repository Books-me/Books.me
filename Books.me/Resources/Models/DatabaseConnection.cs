using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.me.Resources.Models
{
    internal class DatabaseConnection
    {
        public MySqlConnection conn;
        private string serverName;
        private string databaseName;
        private string databaseId;
        private string password;
        private string connectionString;

        public string ServerName
        {
            get { return serverName; }  
            set { serverName = value; }
        }
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        public string DatabaseId
        {
            get { return databaseId; }
            set { databaseId = value; }
        }
        private string DatabasePassword
        {
            get { return password; }
            set { password = value; }
        }
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public DatabaseConnection()
        {
            ServerName = "server27.rdb.superhosting.bg";
            DatabaseName = "vitrini_booksme";
            DatabaseId = "vitrini_books";
            DatabasePassword = "ednodvetri";
            ConnectionString = $"SERVER={ServerName};DATABASE={DatabaseName};UID={DatabaseId};PASSWORD={DatabasePassword};";
            conn = new MySqlConnection(ConnectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
