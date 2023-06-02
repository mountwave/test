using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
    public class CalcTest : BaseTest
    {
        [Test]
        public void NegativeLogin()
        {
            BasePage basep = new(driver);
            basep.ClickCalc();
            Thread.Sleep(1000);
            CalcPage calc = new CalcPage(driver);
            calc.SendTextToCitizenship("Россия");
            calc.SelectCitizanship();
            calc.SendTextToArrival("01/02/2023");
            calc.SendTextToDeparture("28/02/2023");
            Thread.Sleep(2000);
            calc.ClickCalculationBtn();
            Thread.Sleep(2000);
            string warningMessage = calc.GetWarningMessage();
            string expectedMessage = "* Не является юридической консультацией. Расчет сделан на основании правил";
            Assert.AreEqual(expectedMessage, warningMessage, $"{expectedMessage} is not equal to {warningMessage}");
            Thread.Sleep(10000);
        }
    }
}
