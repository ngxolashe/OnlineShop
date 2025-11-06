using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OnlineShop.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected abstract string PageUrl { get; }

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

    }
}