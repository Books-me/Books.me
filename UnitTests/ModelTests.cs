using NUnit.Framework;
using Books.me.Resources.Models;

namespace UnitTests
{
    internal class ModelTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void UserInfoTest()
        {
            string password = "admin";
            string username = "admin";

            User user = new User(username, password);

            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(password, user.Password);
        }
        [Test]
        public void DatabaseInfoTest()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string ServerName = "server27.rdb.superhosting.bg";
            string DatabaseName = "vitrini_booksme";
            string DatabaseId = "vitrini_books";
            string DatabasePassword = "ednodvetri";

            Assert.AreEqual(ServerName, databaseConnection.ServerName);
            Assert.AreEqual(DatabaseName, databaseConnection.DatabaseName);
            Assert.AreEqual(DatabaseId, databaseConnection.DatabaseId);
            Assert.AreEqual(DatabasePassword, databaseConnection.DatabasePassword);
        }
        [Test]
        public void OpenConnectionTest()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            Assert.IsTrue(databaseConnection.OpenConnection());
        }
        [Test]
        public void CloseConnectionTest()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            Assert.IsTrue(databaseConnection.CloseConnection());
        }
    }
}
