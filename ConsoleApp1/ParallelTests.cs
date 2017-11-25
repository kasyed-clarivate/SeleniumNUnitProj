using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumNUnitProj
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTests : BaseTest
    {
        public FirefoxTests() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void TestParallelLogin()
        {
            Console.WriteLine("In the Test Login ...!");
            mainPage.LogOutMenuLink().Click();
            loginPage.UserNameTextBox().SendKeys("Username01");
            loginPage.PasswordTextBox().SendKeys("Password01");
            loginPage.LoginButton().Click();
            Assert.IsTrue(mainPage.MainHeading().Displayed, "Main Page Not Displayed..!");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTests : BaseTest
    {
        public ChromeTests() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void TestParallelNewWindow()
        {
            Console.WriteLine("In the New Window Test...!");
            string currentWindow = helper.GetCurrentWindowHandle();
            mainPage.HtmlPopupLink().Click();
            helper.SwitchToLastWindow();
            Assert.IsTrue(popupWindow.MainHeadingPopup().Text.Contains("Execute Automation"),
                          "Popup Main Heading Not Displayed");
            Assert.IsTrue(popupWindow.SubHeadingPopup().Text.Contains("demo popup"),
                         "Popup Sub Heading Not Displayed");
            helper.CloseWindow();
            helper.SwitchToWindow(currentWindow);
            Assert.IsTrue(mainPage.MainHeading().Displayed, "Main Page Not Displayed..!");

        }
    }

}
