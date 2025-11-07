namespace KlipBoardTechAutomation.Core.Configuration
{
    public class TestSettings
    {
        public string BaseUrl { get; set; } = "https://automationteststore.com/";
        public int DefaultTimeout { get; set; } = 10;
        public bool CaptureScreenshotOnFailure { get; set; } = true;
        public string ScreenshotPath { get; set; } = "TestResults/Screenshots";
    }
}