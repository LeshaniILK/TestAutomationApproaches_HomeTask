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
    internal class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@id='item_4_title_link']")]
        public IWebElement Product { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement AddToCartBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".shopping_cart_link")]
        public IWebElement Cart { get; set; }

        public void ClickProduct()
        {
            Product.Click();
        }

        public void AddToCart()
        {
            AddToCartBtn.Click();
        }

        public void GoToCart()
        {
            Cart.Click();
        }
    }
}
