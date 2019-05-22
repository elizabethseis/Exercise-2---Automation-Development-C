using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace Exercise_2___Development_C
{
    class Program
    {
        
        public static IWebDriver driver;
        
        public static void SetUpBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            
        }
        
        public static void Main(string[] args)
        {
        }

        
        
        public static void WaitForElement(By Locator, int seconds)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(Locator));
            }
            catch (Exception i)
            {
                Console.WriteLine("Element is not displayed");
            }
        }

        public static void Click(string element)
        {
            driver.FindElement(By.Id(element)).Click();
        }

        public  static void VAsserts(string element1, string element2)
        {

            try
            {
                Assert.AreEqual(element1, element2);
                Console.WriteLine("Assert is correct");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        } 

        public static void EnterText(string element, string value)
        {
            driver.FindElement(By.Name(element)).SendKeys(value);
            Console.WriteLine(value);
        }
        public static void DropDown(string element, string value)
        {
            new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
        }
    }
}
