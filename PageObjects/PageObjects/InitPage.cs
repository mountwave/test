using OpenQA.Selenium;

namespace PageObjects
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver1) : base(driver1)
        {

        }

        private static IWebElement BtnCalc => driver.FindElement(By.XPath("//a[@href='/calc']"));

        public void ClickCalc() => BtnCalc.Click();
    }
}
