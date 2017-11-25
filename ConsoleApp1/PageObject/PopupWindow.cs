using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj.PageObject
{

    class PopupWindow : WaitCommonClass
    {
        private IWebDriver driver;

        public PopupWindow(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SubHeadingPopup() {
            return WaitElementToBeVisible(driver, By.XPath("//body/p[contains(text(),'demo popup')]"));
        }

        public IWebElement MainHeadingPopup()
        {
            return WaitElementToBeVisible(driver, By.XPath("//body/h1[contains(text(),'Execute Automation')]"));
        }

    }
}
