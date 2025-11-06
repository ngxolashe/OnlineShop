using OnlineShop.Pages;

namespace KlipBoardTechAutomation.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage _homePage;

        [SetUp]
        public void TestSetup()
        {
            _homePage = new HomePage(Driver);
        }

        [Test]
        public void HomePage_Should_Display_BasicElements()
        {
            _homePage.GoTo();

            Assert.Multiple(() =>
            {
                Assert.That(_homePage.LoginLink.Displayed, Is.True, "Login link should be displayed");
            });
        }
    }
}