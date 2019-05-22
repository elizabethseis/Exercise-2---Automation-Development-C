using NUnit.Framework;
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
        private string actualTittle;

        public void SetActualTitle(string ActualTitle)
        {

            ActualTitle = Program.driver.Title;
            this.actualTittle = ActualTitle;

        }

        public string GetActualTitle()
        {

            return this.actualTittle;

        }
        [SetUp]
        public static void OpenBrowser()
        {
            Program.SetUpBrowser();
        }

        [Test]
        public void execution()
        {
            Program.WaitForElement(By.XPath("//div[@class='mbl _3m9 _6o _6s _mf']"), 5);
            Execution page1 = new Execution();
            page1.SetActualTitle(actualTittle);
            Console.WriteLine(page1.GetActualTitle());
            string Text = "Facebook - Log In or Sign Up";
            Program.VAsserts(page1.GetActualTitle(), Text);
            Program.WaitForElement(By.XPath("//h2[@class='inlineBlock _3ma _6n _6s _6v']"), 5);
            Program.EnterText("firstname", "Elizabeth");
            Program.EnterText("lastname", "Perez");
            Program.EnterText("reg_email__", "elizabethseis@hotmail.com");
            Program.EnterText("reg_passwd__", "Password1");
            Program.DropDown("day", "21");
            Program.DropDown("month", "8");
            Program.DropDown("year", "1988");
            string ValidateText = Program.driver.FindElement(By.XPath("//h2[@class='inlineBlock _3ma _6n _6s _6v']")).Text;
            Program.Click("u_0_9");
            string ExpectedText = "Connect with friends and the\r\nworld around you on Facebook.";
            Program.VAsserts(ValidateText, ExpectedText);
            Console.WriteLine("Test execution completed");
        }

        
        [TearDown]
        public void Close()
        {
            Program.driver.Close();
        }
    }
}
