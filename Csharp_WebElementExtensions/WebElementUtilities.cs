using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using SeleniumExtras.WaitHelpers;

namespace Csharp_WebElementExtensions
{
    public static class WebElementUtilities
    {
      public static IWebDriver driver;
        public static WebDriverWait wait;
       
        public static IWebElement FindByID (this WebDriver driver, string IdValue, double waitTimeInSeconds)
        {
            try
            {
                wait =  new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                wait.Until(ExpectedConditions.ElementExists(By.Id(IdValue)));
                if (driver.FindElement(By.Id(IdValue)).Displayed)
                {
                    Console.WriteLine("Element is Displayed Successfully");
                }
                return driver.FindElement(By.Id(IdValue));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Element is not Displayed "+ex.Message);
                throw new ElementNotVisibleException("Element is not Displayed " + ex.Message);
            }
        }

        public static IWebElement FindByName(this WebDriver driver, string NameValue, double waitTimeInSeconds)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                wait.Until(ExpectedConditions.ElementExists(By.Name(NameValue)));
                if (driver.FindElement(By.Name(NameValue)).Displayed)
                {
                    Console.WriteLine("Element is Displayed Successfully");
                }
                return driver.FindElement(By.Name(NameValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Element is not Displayed " + ex.Message);
                throw new ElementNotVisibleException("Element is not Displayed " + ex.Message);
            }
        }

        public static IWebElement FindByCSS(this WebDriver driver, string CssValue, double waitTimeInSeconds)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector(CssValue)));
                if (driver.FindElement(By.CssSelector(CssValue)).Displayed)
                {
                    Console.WriteLine("Element is Displayed Successfully");
                }
                return driver.FindElement(By.CssSelector(CssValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Element is not Displayed " + ex.Message);
                throw new ElementNotVisibleException("Element is not Displayed " + ex.Message);
            }
        }

        public static IWebElement FindByXpath(this WebDriver driver, string xpathValue, double waitTimeInSeconds)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                wait.Until(ExpectedConditions.ElementExists(By.XPath(xpathValue)));
                if (driver.FindElement(By.XPath(xpathValue)).Displayed)
                {
                    Console.WriteLine("Element is Displayed Successfully");
                }
                return driver.FindElement(By.XPath(xpathValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Element is not Displayed " + ex.Message);
                throw new ElementNotVisibleException("Element is not Displayed " + ex.Message);
            }
        }
    }
}
