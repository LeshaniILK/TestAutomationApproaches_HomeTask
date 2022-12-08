using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationApproaches_HomeTask.Drivers;

namespace TestAutomationApproaches_HomeTask.PageObjects
{
    internal class YourInformationPage
    {
        public YourInformationPage()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Name, Using = "postalCode")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Name, Using = "continue")]
        public IWebElement ContinueBtn { get; set; }

        public void AddDetails(string firstName, string lastName, int zipCode)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            ZipCode.SendKeys(zipCode.ToString());
        }

        public void CllickContinue()
        {
            ContinueBtn.Click();
        }

        public void VerifySuccessLogin()
        {
            string PageUrl = BaseTest.driver.Url;
            Assert.AreEqual(PageUrl, "https://www.saucedemo.com/checkout-step-two.html");
        }
    }
}
