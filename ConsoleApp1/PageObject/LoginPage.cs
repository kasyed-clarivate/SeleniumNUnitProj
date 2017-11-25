using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj.PageObject
{
    public class LoginPage : WaitCommonClass
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver) {
            this.driver = driver;
        }

        public IWebElement UserNameTextBox() {
            return WaitElementToBeVisible(driver, By.Name("UserName"));
        }

        public IWebElement PasswordTextBox()
        {
           // return WaitElementToBeVisible(driver, By.Name("Password"));
            return driver.FindElement(By.Name("Password"));
        }

        public IWebElement LoginButton()
        {
            //return WaitElementToBeVisible(driver, By.XPath("//form[@id='userName']//input[@name='Login']"));
            return driver.FindElement(By.XPath("//form[@id='userName']//input[@name='Login']"));
        }


    }
}
