using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlineShop.Pages
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) { }

        public IWebElement FirstName => Driver.FindElement(By.Id("AccountFrm_firstname"));
        public IWebElement LastName => Driver.FindElement(By.Id("AccountFrm_lastname"));
        public IWebElement Email => Driver.FindElement(By.Id("AccountFrm_email"));
        public IWebElement Address => Driver.FindElement(By.Id("AccountFrm_address_1"));
        public IWebElement City => Driver.FindElement(By.Id("AccountFrm_city"));
        public IWebElement Region => Driver.FindElement(By.Id("AccountFrm_zone_id"));
        public IWebElement Zip => Driver.FindElement(By.Id("AccountFrm_postcode"));
        public IWebElement Country => Driver.FindElement(By.Id("AccountFrm_country_id"));
        public IWebElement LoginName => Driver.FindElement(By.Id("AccountFrm_loginname"));
        public IWebElement Password => Driver.FindElement(By.Id("AccountFrm_password"));
        public IWebElement ConfirmPassword => Driver.FindElement(By.Id("AccountFrm_confirm"));
        public IWebElement AgreeCheckbox => Driver.FindElement(By.Name("agree"));
        public IWebElement ContinueButton => Driver.FindElement(By.XPath("//button[@title='Continue']"));
        public IWebElement Success => Driver.FindElement(By.XPath("//h1/span[contains(text(),'Your Account Has Been Created!')]"));
        public IWebElement Alert => Driver.FindElement(By.CssSelector(".alert-danger"));


        public void Register(string firstName, string lastName, string email, string address, string city, string region, string zip, string country, string loginName, string password)
        {
            LoginLink.Click();
            ContinueButton.Click(); 
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            Email.SendKeys(email);
            Address.SendKeys(address);
            City.SendKeys(city);
            var selectCountry = new SelectElement(Country);
            selectCountry.SelectByText(country); //Countr determines which region are your options
            var selectRegion = new SelectElement(Region);
            selectRegion.SelectByText(region);
            Zip.SendKeys(zip);
            LoginName.SendKeys(loginName);
            Password.SendKeys(password);
            ConfirmPassword.SendKeys(password);
            AgreeCheckbox.Click();
            ContinueButton.Click();
        }
    }
}