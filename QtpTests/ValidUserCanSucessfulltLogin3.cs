using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QtpTests
{

    [TestClass]
    public class ValidUserCanSucessfulltLogin3
    {
        static IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void RunTest()
        {
            GoTo("https://www.qtptutorial.net/wp-login.php/");
            Login("PietroBraga", "@Aa685492");
            var loginSuccessHeader = driver.FindElement(By.XPath("//h1[text()='My Membership']"));
            Assert.IsTrue(loginSuccessHeader.Displayed, "User was able to sucessfully log in.");
        }

        public void Login(string username, string password)
        {
            SendKeys("user_login", username);
            SendKeys("user_pass", password);
            ClickButton("wp-submit");
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
