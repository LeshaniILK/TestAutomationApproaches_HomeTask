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
    internal class Cart
    {
        public Cart()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.Name, Using = "checkout")]
        public IWebElement CheckoutBtn { get; set; }

        public void Checkout()
        {
            CheckoutBtn.Click();
        }

    }
}
