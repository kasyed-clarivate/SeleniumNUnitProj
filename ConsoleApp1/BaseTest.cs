using SeleniumNUnitProj.main;
using SeleniumNUnitProj.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using System.Reflection;

namespace SeleniumNUnitProj
{   public enum BrowserType {
        Firefox,
        Chrome,
        ChromeHeadless
    }
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public MainPage mainPage;
        public PopupWindow popupWindow;
        public Helper helper;
        private BrowserType _browserType;

        public BaseTest() {
            _browserType = BrowserType.Chrome;
        }
        public BaseTest(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [OneTimeSetUp]
        public void OneTimeSettingUp()
        { 
            Console.WriteLine("One Time Setting Up...!");
            if (_browserType == BrowserType.Chrome)
            { //string path = AppDomain.CurrentDomain.BaseDirectory;
                string path = Assembly.GetExecutingAssembly().CodeBase;
                Console.WriteLine("Path :"+path);
                Console.WriteLine("Chrome Browser Invoked..!");
                driver = new ChromeDriver("D:/Work/ProjectCSharp/ConsoleApp1Solution/ConsoleApp1/drivers/");
              //  driver = new ChromeDriver(path+"/drivers/");
            }
            else if (_browserType == BrowserType.Firefox)
            {   
                Console.WriteLine("Firefox Browser Invoked..!");
                driver = new FirefoxDriver("D:/Work/ProjectCSharp/ConsoleApp1Solution/ConsoleApp1/drivers/");
            }
            else if(_browserType==BrowserType.ChromeHeadless) {
                Console.WriteLine("Chrome Headless Browser Invoked..!");
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("--headless");
               // option.AddArgument("D:/Work/ProjectCSharp/ConsoleApp1Solution/ConsoleApp1/drivers/");
                driver = new ChromeDriver("D:/Work/ProjectCSharp/ConsoleApp1Solution/ConsoleApp1/drivers/", option);
            }
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
           // driver.Manage().Cookies.DeleteAllCookies();
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
