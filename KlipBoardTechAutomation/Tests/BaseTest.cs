using KlipBoardTechAutomation.Core.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace KlipBoardTechAutomation.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            // Global test suite setup if needed
        }

        [SetUp]
        public void Setup()
        {
            Driver = DriverFactory.CreateDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TakeScreenshot();
            }
            Driver?.Quit();
        }

        private void TakeScreenshot()
        {
            try
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var fileName = $"TestFail_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                screenshot.SaveAsFile(Path.Combine("TestResults/Screenshots", fileName));
            }
            catch (Exception ex)
            {
                TestContext.Error.WriteLine($"Failed to take screenshot: {ex.Message}");
            }
        }
    }
}