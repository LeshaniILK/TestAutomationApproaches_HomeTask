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
    internal class Login
    {
        public Login()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-name")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement loginBTN { get; set; }


        public void addLoginCredentials(string _username, string _password)
        {
            username.SendKeys(_username);
            password.SendKeys(_password);
        }

        public void clickLoginButton()
        {
            loginBTN.Click();
        }
    }
}
