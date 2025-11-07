using KlipBoardTechAutomation.Pages;
using OnlineShop.Pages;
using static System.Net.Mime.MediaTypeNames;

namespace KlipBoardTechAutomation.Tests
{
    public class Login : BaseTest
    {
        private LoginPage _login;

        [SetUp]
        public void TestSetup()
        {
            _login = new LoginPage(Driver);
        }

        [Test]
        public void Login_Should_Be_Success_With_Valid_Credentials()
        {

            _login.GoTo();
            _login.Login(
                name: "AsiTestUser12345",
                password:"Tst12345"
            );

            Assert.That(_login.Welcome.Displayed, "Success header not found");
        }

        [Test]
        public void Login_Should_Be_Denied_With_Invalid_Credentials()
        {

            _login.GoTo();
            _login.Login(
                name: "AsiTestUser12345",
                password: "Tst123"
            );

            Assert.That(_login.Alert.Text, Does.Contain("Error: Incorrect login or password provided."));
        }

        [Test]
        public void Logout_After_Login()
        {

            _login.GoTo();
            _login.Login(
                name: "AsiTestUser12345",
                password: "Tst12345"
            );

            _login.AccountMenu.Click();
            _login.Logout.Click();
            Assert.That(_login.Success.Displayed, "Logout success header not found");
        }
    }


}

