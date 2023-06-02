using OpenQA.Selenium;

namespace PageObjects
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private static IWebElement BtnCalc => driver.FindElement(By.XPath("//a[@href='/calc']"));
        private static IWebElement BtnFaq => driver.FindElement(By.XPath("//a[@href='/faq']"));
        private IWebElement txtHeader => driver.FindElement(By.TagName("h1"));

        public string GetTextFromHeader() => txtHeader.Text;
        public void ClickCalc() => BtnCalc.Click();
        public void ClickFaq() => BtnFaq.Click();
        
    }
}