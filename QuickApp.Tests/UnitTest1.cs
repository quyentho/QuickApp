using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.IO;

namespace QuickApp.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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
    }
}