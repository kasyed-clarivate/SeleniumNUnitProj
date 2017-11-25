using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNUnitProj.main
{
   public class Helper
    {
        IWebDriver driver;
        public Helper(IWebDriver driver) {
            this.driver = driver;
        } 

        public String GetCurrentWindowHandle()
        {
            return driver.CurrentWindowHandle;
        }


        public IList<String> GetCurrentWindowHandles()
        {
            return driver.WindowHandles;
        }

        public void SwitchToWindow(string windowName) {
            driver.SwitchTo().Window(windowName);
        }

        public void SwitchToLastWindow() {
            IList<string> allWindows = driver.WindowHandles;
            string newWindow = allWindows[allWindows.Count - 1];
            driver.SwitchTo().Window(newWindow);
        }

        public IAlert SwitchToAlert()
        {            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            return wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public void AcceptAlert(IAlert alert)
        {
            alert.Accept();
        }

        public void DismissAlert(IAlert alert)
        {
            alert.Dismiss();
        }

        public string GetText(IAlert alert)
        {
            return alert.Text;
        }

        public void CloseWindow()
        {
            driver.Close();
        }

    }
}
