using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;


namespace appium
{
    public class NewIOSDriver : IOSDriver<IOSElement>
    {

        public NewIOSDriver(Uri remoteAddress, DesiredCapabilities desiredCapabilities) : base(remoteAddress, desiredCapabilities)
        {
            Console.WriteLine("HELLO");
        }

        protected override Response Execute(string driverCommandToExecute, Dictionary<string, object> parameters)
        {
            String parm = "Execute - " + driverCommandToExecute;
            if (!driverCommandToExecute.Equals("quit"))
            {
                parm = parm + " with: [";
                foreach (KeyValuePair<string, object> kvp in parameters)
                {
                    parm += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value) + ", ";
                }
                parm = parm.Remove(parm.Length - 1) + "]";
            }

            TestContext.Out.WriteLine(parm);
            return base.Execute(driverCommandToExecute, parameters);
        }
    }
}


