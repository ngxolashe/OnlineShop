using OnlineShop.Pages;
using static System.Net.Mime.MediaTypeNames;

namespace KlipBoardTechAutomation.Tests
{
    public class Registration : BaseTest
    {
        private RegisterPage _registerPage;

        [SetUp]
        public void TestSetup()
        {
            _registerPage = new RegisterPage(Driver);
        }

        [Test]
        public void Register_Should_Create_New_Account()
        {

            _registerPage.GoTo();

            //To ensure unique email and login name for each test run
            string uniqueId = Guid.NewGuid().ToString("N").Substring(0, 8);
            _registerPage.Register(
                firstName: "Test",
                lastName: "User",
                email: $"test{uniqueId}@example.com",
                address: "123 Main St",
                city: "Testville",
                region: "Gauteng",
                zip: "2001",
                country: "South Africa",
                loginName: $"testuser{uniqueId}",
                password: "Password123!"
            );

            Assert.That(_registerPage.Success.Displayed, "Success header not found");
        }

        [Test]
        public void Register_Should_Create_Existing_Account()
        {

            _registerPage.GoTo();
            _registerPage.Register(
                firstName: "Test",
                lastName: "User",
                email: $"test123@example.com",
                address: "123 Main St",
                city: "Testville",
                region: "Gauteng",
                zip: "2001",
                country: "South Africa",
                loginName: $"testuser123",
                password: "Password123!"
            );

            Assert.That(_registerPage.Alert.Text, Does.Contain("This login name is not available. Try different login name!"));
        }
    }


}