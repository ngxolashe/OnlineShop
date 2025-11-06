using OpenQA.Selenium;

namespace OnlineShop.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://automationteststore.com/";

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        public IWebElement LoginLink => _driver.FindElement(By.LinkText("Login or register"));
    }
}
