//using System;
//using TechTalk.SpecFlow;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;

//namespace sample.StepDefinitions
//{
//    [Binding]
//    public class ThirdTableDataDrivenExampleStepDefinitions
//    {
       
//        IWebDriver driver = new ChromeDriver();
//        [Given(@"I am at the login page of automation exercise website\.")]
//        public void GivenIAmAtTheLoginPageOfAutomationExerciseWebsite_()
//        {
//            driver.Navigate().GoToUrl("https://www.automationexercise.com/login");
//        }
//        //[When(@"I enter email '([^']*)'\.")]
//        //public void WhenIEnterEmail_(string username)
//        //{
//        //    driver.FindElement(By.XPath("\"//input[@data-qa=\\\"login-email\\\"]\"")).SendKeys(username);
//        //}

//        //[When(@"I enter password '([^']*)'\.")]
//        //public void WhenIEnterPassword_(string password)
//        //{
//        //    driver.FindElement(By.XPath("\"//input[@data-qa=\\\"login-password\\\"]\"")).SendKeys(password);
//        //}
//        [When(@"I enter username (.*)\.")]
//        public void WhenIEnterUsernameJenGmail_Co_(string username)
//        {
//            driver.FindElement(By.XPath("//input[@data-qa='login-email']")).SendKeys(username);
//        }

//        [When(@"I enter password (.*)\.")]
//        public void WhenIEnterPassword_(string password)
//        {
//            driver.FindElement(By.XPath("//input[@data-qa='login-password']")).SendKeys(password);
//        }

//        [When(@"I click the login button\.")]
//        public void WhenIClickTheLoginButton_()
//        {
//            driver.FindElement(By.XPath("//button[@data-qa=\"login-button\"]")).Click();
//            Thread.Sleep(3000);
//        }

//        [Then(@"I successfully logged in\.")]
//        public void ThenISuccessfullyLoggedIn_()
//        {
//            driver.Quit();
//            Console.WriteLine("I have logged in successfully.");
//        }
//    }
//}