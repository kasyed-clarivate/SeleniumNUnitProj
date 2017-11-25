using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj
{
    class TestClass1 : BaseTest
    {
          [Test]
        public void TestAlerts() {
            mainPage.GenerateAlertButton().Click();
            IAlert alert=helper.SwitchToAlert();
            string alertText = alert.Text;
            Assert.IsTrue(alertText.Contains("Javascript alert"));
            alert.Dismiss();
            alertText = alert.Text;
            Assert.IsTrue(alertText.Contains("You pressed Cancel"));
            alert.Accept();
            Assert.IsTrue(mainPage.MainHeading().Displayed, "Main Page Not Displayed..!");

        }
    }
}
