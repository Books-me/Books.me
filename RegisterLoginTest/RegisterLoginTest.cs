using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books.me.Resources.Controller;

namespace RegisterLoginTest
{
    [TestClass]
    public class RegisterLoginTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string username = "";
            string password = "";
            LoginForm loginFormTest = new LoginForm();
            loginFormTest.Register(username, password);
            
        }
    }
}