//package <set your test package>;
using System;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;

namespace appium
{
    [TestFixture]
    //[NUnit.Framework.Ignore("Android")]
    public class Android
    {
        protected NewAndroidDriver driver = null;

        DesiredCapabilities dc = new DesiredCapabilities();

        [SetUp()]
        public void SetupTest()
        {

            dc.SetCapability("platform", "android");
            dc.SetCapability(MobileCapabilityType.DeviceName, "andropid");
            dc.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.experitest.ExperiBank");
            dc.SetCapability(AndroidMobileCapabilityType.AppActivity, ".LoginActivity");
            driver = new NewAndroidDriver(new Uri("http://localhost:4723/wd/hub"), dc);

        }

        [Test()]
        public void TestUntitled()
        {
            
            TestContext.WriteLine("----- Last  -----");
            TestContext.WriteLine(driver.Manage().Logs.AvailableLogTypes);
            System.Collections.ObjectModel.ReadOnlyCollection<String> avLogs = driver.Manage().Logs.AvailableLogTypes;
            System.Collections.ObjectModel.ReadOnlyCollection<LogEntry> logs = driver.Manage().Logs.GetLog("logcat");

            foreach (String log in driver.Manage().Logs.AvailableLogTypes)
            {
                TestContext.WriteLine(log);
            }

            //TestContext.WriteLine("----- TEST -----");
            
        }

        [TearDown()]
        public void TearDown()
        {

            driver.Quit();
        }
    }
}