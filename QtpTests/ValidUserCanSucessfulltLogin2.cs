using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QtpTests
{

    [TestClass]
    public class ValidUserCanSucessfulltLogin2
    {
        static IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void RunTest()
        {
            //Creates a new instance of ChromeDriver
            GoTo("https://www.qtptutorial.net/wp-login.php/");

            //Find the user entry field and send the username
            SendKeys("user_login", "PietroBraga");

            //Finds the password entry field and sends the password
            SendKeys("user_pass", "@Aa685492");

            //Finds the submit button and submitt the form
            ClickButton("wp-submit");

            var loginSuccessHeader = driver.FindElement(By.XPath("//h1[text()='My Membership']"));
            Assert.IsTrue(loginSuccessHeader.Displayed, "User was able to sucessfully log in.");
        }
        public void GoTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SendKeys(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        public void ClickButton(string id)
        {
            driver.FindElement(By.Id(id)).Submit();
        }
    }
}
