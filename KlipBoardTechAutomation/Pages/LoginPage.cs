using OnlineShop.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KlipBoardTechAutomation.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement LoginName => Driver.FindElement(By.Id("loginFrm_loginname"));
        public IWebElement LoginPassword => Driver.FindElement(By.Id("loginFrm_password"));
        public IWebElement LoginButton => Driver.FindElement(By.XPath("//button[@title='Login']"));

        public IWebElement Alert => Driver.FindElement(By.CssSelector(".alert-danger"));

        public IWebElement Welcome => Driver.FindElement(By.CssSelector(".menu_text"));
        public IWebElement AccountMenu => Driver.FindElement(By.CssSelector("#main_menu_top > li.dropdown.current > a > span"));

        public IWebElement Logout => WaitAndFindElement(By.CssSelector("#main_menu_top > li.dropdown.current > ul > li:nth-child(2) > a > span"));
        public IWebElement Success => Driver.FindElement(By.XPath("//h1/span[contains(text(),'Account Logout')]"));

        public void Login(string name, string password)
        {
            LoginLink.Click();
            LoginName.SendKeys(name);
            LoginPassword.SendKeys(password);
            LoginButton.Click();
        }
    }
}
