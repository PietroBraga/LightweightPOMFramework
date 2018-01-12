using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtpTests
{
    public class TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Browser.Initialize();
        }
    }

    public static class Browser
    {
        public static IWebDriver _webDriver = new ChromeDriver();
        public static void Initialize()
        {
            _webDriver.Navigate().GoToUrl("");
        }       
    }
 }
