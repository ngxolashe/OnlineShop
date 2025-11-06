using OpenQA.Selenium;

namespace OnlineShop.Pages
{
    public class HomePage : BasePage
    {
        protected override string PageUrl => "https://automationteststore.com/";

        // Locators
        private readonly By _loginLinkLocator = By.LinkText("Login or register");

        public HomePage(IWebDriver driver) : base(driver) { }

        public IWebElement LoginLink => WaitAndFindElement(_loginLinkLocator);

    }
}
