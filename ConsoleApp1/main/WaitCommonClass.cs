using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SeleniumNUnitProj.main
{
    class WaitCommonClass
    {   private static int WAiT_TIME=2;

        public IWebElement WaitElementToBeVisible(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public IWebElement WaitElementToBeExists(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.ElementExists(by));
        }

        public IWebElement WaitElementToBeClickable(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public IList<IWebElement> waitElementsToBeExist(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

    }
}
