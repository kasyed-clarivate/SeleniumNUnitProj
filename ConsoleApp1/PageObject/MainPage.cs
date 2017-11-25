using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj.PageObject
{
    class MainPage : WaitCommonClass
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LogOutMenuLink() {
            return WaitElementToBeVisible(driver, By.XPath("//div[@id='cssmenu']//span[text()='Logout']"));
        }

        public IWebElement MainHeading()
        {
            return WaitElementToBeVisible(driver, By.XPath("//body/h1[contains(text(),'Execute Automation')]"));
        }

        public IWebElement HtmlPopupLink()
        {
            return WaitElementToBeVisible(driver, By.XPath("//form[@id='details']//a[@href='popup.html']"));
        }

        public IWebElement GenerateAlertButton()
        {
            return WaitElementToBeVisible(driver, By.Name("generate"));
        }

    }
}
