using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_2___Development_C
{
    class Execution
    {
        public void execution()
        {
            Program obj1 = new Program();
            obj1.WaitForElement(By.XPath("//div[@class='mbl _3m9 _6o _6s _mf']"), 5);
            string actualTittle = Program.driver.Title;
            string Text = "Facebook - Log In or Sign Up";
            Console.WriteLine(actualTittle);
            Program obj3 = new Program();
            obj3.VAsserts(actualTittle, Text);
            Program obj5 = new Program();
            obj5.WaitForElement(By.XPath("//h2[@class='inlineBlock _3ma _6n _6s _6v']"), 5);
            string ValidateText = Program.driver.FindElement(By.XPath("//h2[@class='inlineBlock _3ma _6n _6s _6v']")).Text;
            string ExpectedText = "Connect with friends and the\r\nworld around you on Facebook.";
            Program obj6 = new Program();
            obj6.VAsserts(ValidateText, ExpectedText);
        }

    }
}
