﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSucessfulltLogin
    {
        [TestMethod]
        public void RunTest()
        {
            //Creates a new instance of ChromeDriver
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.qtptutorial.net/wp-login.php/");

            //Finds the user entry field and sen the username
            var user = driver.FindElement(By.Id("user_login"));
            user.SendKeys("PietroBraga");

            //Finds the password entry field and sends the password
            var pass = driver.FindElement(By.Id("user_pass"));
            pass.SendKeys("@Aa685492");

            //Finds the submit button and submitt the form
            var submit = driver.FindElement(By.Id("wp-submit"));
            submit.Submit();

            var loginSuccessHeader = driver.FindElement(By.XPath("//h1[text()='My Membership']"));
            Assert.IsTrue(loginSuccessHeader.Displayed, "User was able to sucessfully log in.");
        }
    }
}
