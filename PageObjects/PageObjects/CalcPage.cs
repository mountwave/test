using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjects
{
    public class CalcPage : BasePage
    {
        public CalcPage(IWebDriver driver1) : base(driver1)
        {

        }

        private IWebElement txtCitizenship => driver.FindElement(By.XPath("//input[@id='input-50']"));
        private IWebElement itemSelectCitizenship => driver.FindElement(By.XPath("//*[@id='list-item-88-0']/div/div"));
        private IWebElement txtArrival => driver.FindElement(By.XPath("//input[@id='input-59']"));
        private IWebElement txtDeparture => driver.FindElement(By.XPath("//input[@id='input-65']"));
        private IWebElement btnCalculate => driver.FindElement(By.XPath("//span[text()=' Рассчитать ']"));
        private IWebElement warningMessage => driver.FindElement(By.XPath("//div[@class='calc-view_additional-information']"));
        

        public void SendTextToCitizenship(string text)  => txtCitizenship.SendKeys(text);
        public void SelectCitizanship() => itemSelectCitizenship.Click();
        public void SendTextToArrival(string text) => txtArrival.SendKeys(text);
        public void SendTextToDeparture(string text) => txtDeparture.SendKeys(text);
        public void ClickCalculationBtn() => btnCalculate.Click();
        public string GetWarningMessage() => warningMessage.Text;
        
    }
}
