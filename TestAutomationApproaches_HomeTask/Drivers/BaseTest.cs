using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationApproaches_HomeTask.Drivers
{
    internal class BaseTest
    {
        public static IWebDriver driver;

        public void BrowserSetUp()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }

    }

}
