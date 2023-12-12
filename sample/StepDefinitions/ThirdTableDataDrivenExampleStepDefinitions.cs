using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using sample.Support;

namespace sample.StepDefinitions
{
    [Binding]
    public class ThirdTableDataDrivenExampleStepDefinitions
    {
        /// <summary>
        //
        /// </summary>
        LoginPage loginpage = new LoginPage();

        IWebDriver driver;
        public ThirdTableDataDrivenExampleStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"I am at the login page of automation exercise website\.")]
        public void GivenIAmAtTheLoginPageOfAutomationExerciseWebsite_()
        {
            driver.Navigate().GoToUrl("https://www.automationexercise.com/login");
        }

        [When(@"I enter username (.*)\.")]
        public void WhenIEnterUsernameAutomationGmail_Com_(string username)
        {
            driver.FindElement(By.XPath(loginpage.UsernameInputBarXpath)).SendKeys(username);
        }

        [When(@"I enter password (.*)\.")]
        public void WhenIEnterPassword_(string password)
        {
            driver.FindElement(By.XPath(loginpage.PasswordInputBarXpath)).SendKeys(password);
        }

        [When(@"I click the login button\.")]
        public void WhenIClickTheLoginButton_()
        {
            //driver.FindElement(By.XPath(loginpage.SubmitBtnXpath)).Click();
            SeleniumSetMethods.ClickBtn(driver: driver, element: loginpage.SubmitBtnXpath, type:PropertyType.Xpath);
        }

        [Then(@"I successfully logged in\.")]
        public void ThenISuccessfullyLoggedIn_()
        {
            //driver.Quit();
            //Console.WriteLine("I am successfully logged in.");
            Console.WriteLine("Logged in");
        }
    }
}
