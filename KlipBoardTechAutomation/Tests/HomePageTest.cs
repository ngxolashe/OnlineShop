using KlipBoardTechAutomation.Core.Drivers;
using NUnit.Framework;
using OnlineShop.Pages;
using OpenQA.Selenium;

namespace OnlineShop.Tests
{
    public class HomePageTests
    {
        private IWebDriver _driver;
        private HomePage _homePage;

        [SetUp]
        public void SetUp()
        {
            _driver = DriverFactory.CreateDriver();
            _homePage = new HomePage(_driver);
        }

        [Test]
        public void HomePage_Should_Display_LoginLink()
        {
            _homePage.GoTo();
            Assert.That(_homePage.LoginLink.Displayed, Is.True, "Login link should be displayed on home page");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
