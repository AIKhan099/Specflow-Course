using System;
using OpenQA.Selenium;
using sample.Support;
using TechTalk.SpecFlow;

namespace sample.StepDefinitions
{
    [Binding]
    public class LoginWithTableStepDefinitions
    {
        LoginPage loginpage = new LoginPage();

        IWebDriver driver;
        public LoginWithTableStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [When(@"I enter the credentials\.")]
        public void WhenIEnterTheCredentials_(Table table)
        {
          Dictionary<string,string> credentials = new Dictionary<string,string>();
        foreach(var row in table.Rows)
            {
                credentials.Add(row[0], row[1]);
                
            }
            Console.WriteLine(credentials["Username"]);
            Console.WriteLine(credentials["Password"]);
            //driver.FindElement(By.XPath(loginpage.UsernameInputBarXpath)).SendKeys(credentials["Username"]);
            //driver.FindElement(By.XPath(loginpage.PasswordInputBarXpath)).SendKeys(credentials["Password"]);

            SeleniumSetMethods.EnterText(driver: driver, element: loginpage.UsernameInputBarXpath, text: credentials["Username"],type:PropertyType.Xpath);
            SeleniumSetMethods.EnterText(driver: driver, element: loginpage.PasswordInputBarXpath, text: credentials["Password"], type: PropertyType.Xpath);
            Thread.Sleep(5000);

        }
    }
}
