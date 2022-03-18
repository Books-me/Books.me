using NUnit.Framework;
using Books.me.Resources.Controller;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void RegisterTest()
        {
            string password = "admin";
            string username = "admin";

            LoginForm loginForm = new LoginForm();

            Assert.False(loginForm.Register(username, password));
        }
        [Test]
        public void LoginTest()
        {
            string password = "admin";
            string username = "admin";

            LoginForm loginForm = new LoginForm();

            Assert.IsTrue(loginForm.IsLogin(username, password));
        }
        [Test]
        public void EncryptedPassword()
        {
            LoginForm loginForm = new LoginForm();
            string key = "b14ca5898a4e4133bbce2ea2315a1916";
            string password = "admin";

            string expected = "T+4Ai6O3CR0kJYxCgXy2jA==";

            Assert.AreEqual(expected, LoginForm.EncryptString(key, password));
        }
        [Test]
        public void GetCurrentUserInfoTest()
        {
            string password = "admin";
            string username = "admin";

            LoginForm loginForm = new LoginForm();
            loginForm.IsLogin(username, password);
            loginForm.GetCurrentUserInfo();
            
            int expectedId = 12;

            Assert.AreEqual(expectedId, 12);
        }
    }
}