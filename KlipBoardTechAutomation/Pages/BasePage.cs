using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlineShop.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected string PageUrl = "https://automationteststore.com/";

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement WaitAndFindElement(By by)
        {
            return Wait.Until(ExpectedConditions.ElementExists(by));
        }

        public virtual void GoTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
        }

        // Locators
        private readonly By _loginLinkLocator = By.LinkText("Login or register");

        private readonly By _home = By.LinkText("Home");

        private readonly By _apparel = By.LinkText("Apparel & accessories");

        public IWebElement LoginLink => WaitAndFindElement(_loginLinkLocator);

        public IWebElement Home => WaitAndFindElement(_home);

        public IWebElement Apparel => WaitAndFindElement(_apparel);

    }
}