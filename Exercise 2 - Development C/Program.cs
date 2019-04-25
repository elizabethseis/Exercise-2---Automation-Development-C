using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
namespace Exercise_2___Development_C
{
    class Program
    {
        public static IWebDriver driver;
        public static void Main(string[] args)
        {
            OpenBrowser();
            Execution obj2 = new Execution();
            obj2.execution();
            FillSignUp();
            Birthday();
            Console.ReadLine();
        }

        public static void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }
        public void WaitForElement(By Locator, int seconds)
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

        public static void Click(IWebElement element1)
        {
            element1.Click();
        }

        public void VAsserts(string element1, string element2)
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

        public static void FillSignUp()
        {
            IWebElement Name = driver.FindElement(By.XPath("//input[@name='firstname']"));
            Name.SendKeys("ELIZABETH");
            IWebElement LastName = driver.FindElement(By.XPath("//input[@name='lastname']"));
            LastName.SendKeys("PEREZ");
            IWebElement Phone = driver.FindElement(By.XPath("//input[@name='reg_email__']"));
            Phone.SendKeys("4777902377");
            IWebElement Password = driver.FindElement(By.XPath("//input[@name='reg_passwd__']"));
            Password.SendKeys("Open12345");
            
        }
        public static void Birthday()
        {
            SelectElement DrpDay = new SelectElement(driver.FindElement(By.XPath("//select[@id='day']")));
            SelectElement DrpMonth = new SelectElement(driver.FindElement(By.XPath("//select[@id='month']")));
            SelectElement DrpYear = new SelectElement(driver.FindElement(By.XPath("//select[@id='year']")));
            DrpDay.SelectByValue("21");
            DrpMonth.SelectByValue("8");
            DrpYear.SelectByValue("1988");
            Program obj4 = new Program();
            obj4.WaitForElement(By.XPath("//label[contains(text(),'Female')]"), 5);
            IWebElement RBFemale = driver.FindElement(By.XPath("//label[contains(text(),'Female')]"));
            Click(RBFemale);
        }
    }
}
