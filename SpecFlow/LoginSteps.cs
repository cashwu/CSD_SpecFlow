using NUnit.Framework;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class LoginSteps
    {
        private InternetExplorerDriver Driver
        {
            get
            {
                return (InternetExplorerDriver)ScenarioContext.Current["DRIVER"];
            }
        }

        [Given(@"there is a user with username ""(.*)"" and password ""(.*)""")]
        public void GivenThereIsAUserWithUsernameAndPassword(string username, string password)
        {
            //insert user to db
        }

        [When(@"login with ""(.*)"" and ""(.*)""")]
        public void WhenLoginWithAnd(string username, string password)
        {
            Driver.Navigate().GoToUrl("http://localhost:13748/Account/Login");

            Driver.FindElementById("Email").SendKeys(username);
            Driver.FindElementById("Password").SendKeys(password);
            Driver.FindElementByClassName("btn").Click();
        }
        
        [Then(@"i can see ""(.*)""")]
        public void ThenICanSee(string message)
        {
            Assert.IsNotNull(Driver.FindElementByLinkText(message));
        }
    }
}

