using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestAutomationApproaches_HomeTask.Drivers;
using TestAutomationApproaches_HomeTask.PageObjects;

namespace TestAutomationApproaches_HomeTask.StepDefinitions
{
    [Binding]
    public class OrderStepDefinitions
    {
        Login loginPO;
        BaseTest  baseTsetPO = new BaseTest();
        HomePage homePagePO;
        Cart cartPO;
        YourInformationPage yourInformationPagePO;

        [Given(@"user in the login page to sign in")]
        public void GivenUserInTheLoginPageToSignIn()
        {
            baseTsetPO.BrowserSetUp();
            loginPO = new Login();
        }

        [When(@"user enter username '([^']*)' and password '([^']*)'")]
        public void WhenUserEnterUsernameAndPassword(string username, string password)
        {
            loginPO.addLoginCredentials(username, password);
        }

        [Then(@"user will login to the Swag Labs")]
        public void ThenUserWillLoginToTheSwagLabs()
        {
            loginPO.clickLoginButton();
        }

        [Given(@"user in the product page")]
        public void GivenUserInTheProductPage()
        {
            homePagePO = new HomePage();
        }

        [When(@"user click on the product")]
        public void WhenUserClickOnTheProduct()
        {
            homePagePO.ClickProduct();
        }

        [Then(@"navigate to the product details page")]
        public void ThenNavigateToTheProductDetailsPage()
        {
            Assert.AreEqual(BaseTest.driver.Url, "https://www.saucedemo.com/inventory-item.html?id=4");
        }

        [When(@"user click on the add to cart button")]
        public void WhenUserClickOnTheAddToCartButton()
        {
            homePagePO.AddToCart();
        }

        [When(@"user click on the cart icon")]
        public void WhenUserClickOnTheCartIcon()
        {
            homePagePO.GoToCart();
        }

        [Then(@"navigate to cart")]
        public void ThenNavigateToCart()
        {
            cartPO = new Cart();
        }

        [When(@"user click on the checkout button")]
        public void WhenUserClickOnTheCheckoutButton()
        {
            cartPO.Checkout();
        }

        [Then(@"navigate to checkout page")]
        public void ThenNavigateToCheckoutPage()
        {
            yourInformationPagePO = new YourInformationPage();
        }

        [When(@"user enter firstName lastName and zipCode")]
        public void WhenUserEnterFirstNameLastNameAndZipCode(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            yourInformationPagePO.AddDetails((string)data.FirstName, (string)data.LastName, data.ZipCode);
        }

        [When(@"user click on the continue button")]
        public void WhenUserClickOnTheContinueButton()
        {
            yourInformationPagePO.CllickContinue();
        }

        [Then(@"navigate to overview page")]
        public void ThenNavigateToOverviewPage()
        {
            Assert.AreEqual(BaseTest.driver.Url, "https://www.saucedemo.com/checkout-step-two.html");
        }
    }
}
