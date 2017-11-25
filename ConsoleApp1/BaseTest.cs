using SeleniumNUnitProj.main;
using SeleniumNUnitProj.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj
{   
    class BaseTest
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public MainPage mainPage;
        public PopupWindow popupWindow;
        public Helper helper;

        [OneTimeSetUp]
        public void OneTimeSettingUp()
        { 
            Console.WriteLine("One Time Setting Up...!");
            driver = new ChromeDriver("D:/Work/ProjectCSharp/ConsoleApp1Solution/ConsoleApp1/drivers/");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            helper = new Helper(driver);
            mainPage = new MainPage(driver);
            loginPage = new LoginPage(driver);
            popupWindow = new PopupWindow(driver);
        }
        [SetUp]
        public void SettingUp()
        {
            Console.WriteLine("Setting Up...!");
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            Console.WriteLine("Deleting Cookies and Tear Down....!");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            Console.WriteLine("One Time Tear Down....!");
        }
    }
}
