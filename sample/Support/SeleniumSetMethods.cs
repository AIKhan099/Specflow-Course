using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Runtime;

namespace sample.Support
{
    internal class SeleniumSetMethods
    {
        public static void EnterText( IWebDriver driver, String element, String text, PropertyType type )
        {
            if (type == PropertyType.Xpath)
            {
                driver.FindElement(By.XPath(element)).SendKeys(text);
            }
            if (type == PropertyType.Id)
            {
                driver.FindElement(By.Id(element)).SendKeys(text);
            }
            if (type == PropertyType.Name)
            {
                driver.FindElement(By.Name(element)).SendKeys(text);
            }

        }
        public static void ClickBtn(IWebDriver driver, String element, PropertyType type)
        {
            if (type == PropertyType.Xpath)
            {
                driver.FindElement(By.XPath(element)).Click();
            }

            if (type==PropertyType.Id)
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (type==PropertyType.Name)
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
    }
}
