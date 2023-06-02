using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
    public class SmokeTest : BaseTest
    {
        [Test]
        public void VerifyPageHeaders()
        {
            BasePage basePage = new BasePage(driver);
            basePage.ClickCalc();

            CalcPage calcPage = new CalcPage(driver);
            Thread.Sleep(1000);
            string header = calcPage.GetTextFromHeader();
            Assert.AreEqual("Калькулятор безвизовых дней", header, $"Header {header} is not as expected");

            calcPage.ClickFaq();
            FaqPage faqPage = new FaqPage(driver);
            Thread.Sleep(1000);
            header = faqPage.GetTextFromHeader();
            Assert.AreEqual("Тема вопроса:", header, $"Header {header} is not as expected");
        }
            

    }
}
