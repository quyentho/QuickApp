using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace QuickApp.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class Tests
    {
        IWebDriver _driver;
        string driverPath = Directory.GetCurrentDirectory();
        [SetUp]
        public void Setup()
        {

            

            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = Path.Combine(driverPath, "chromedriver.exe");

            _driver =  new ChromeDriver(driverPath);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestSelenium()
        {
            _driver.Url = "https://google.com";
            var txtSearch = _driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            txtSearch.SendKeys("Hello World!");
            //var btnEnter = _driver.FindElement(By.XPath("(//input[@class='gNO89b'])[2]"));
            //btnEnter.Click();
            txtSearch.Submit();
            Assert.Pass();
        }
    }
}

