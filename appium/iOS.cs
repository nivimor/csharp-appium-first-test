//package <set your test package>;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.Service;
using System.Text.RegularExpressions;

namespace appium
{
    [TestFixture]
    [NUnit.Framework.Ignore("iOS")]
    public class iOS
    {
        private string reportDirectory = "reports";
        private string reportFormat = "xml";
        private string testName = "Untitled";
        protected NewIOSDriver driver = null;
       
        DesiredCapabilities dc = new DesiredCapabilities();
        
        [SetUp()]
        public void SetupTest()
        {
           
            dc.SetCapability("platform", "ios");
            dc.SetCapability("reportDirectory", reportDirectory);
            dc.SetCapability("reportFormat", reportFormat);
            dc.SetCapability("testName", testName);
            
            dc.SetCapability(IOSMobileCapabilityType.BundleId, "com.experitest.ExperiBank");
          
            driver = new NewIOSDriver(new Uri("http://localhost:4722/wd/hub"), dc);
            
        }
        [Test()]
        public void TestUntitled()
        {
            
        }

        [TearDown()]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}