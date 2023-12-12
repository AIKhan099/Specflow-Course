using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace sample.StepDefinitions
{
    [Binding]
    public class FirstPracticalExStepDefinitions
    {
        
        IWebDriver driver;
        public FirstPracticalExStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am at the home page of web application\.")]
        public void GivenIAmAtTheHomePageOfWebApplication_()
        {
            
            driver.Navigate().GoToUrl("https://www.automationexercise.com/login");
            //Thread.Sleep(5000);
            //Console.WriteLine(str + " Given SE");

        }
        


        [Then(@"I close the brower\.")]
        public void ThenICloseTheBrower_()
        {
            //driver.Quit();
            //Console.WriteLine(str + " When SE");
        }
    }
}
