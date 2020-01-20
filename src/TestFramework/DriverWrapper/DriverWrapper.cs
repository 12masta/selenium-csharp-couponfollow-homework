using System;
using TestFramework.Dto;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestFramework.DriverWrapper
{
    public class DriverWrapper : IDriverWrapper, IDisposable
    {
        private IWebDriver webDriver;
        private DriverConfiguration driverConfiguration;

        public string BaseUrl => driverConfiguration.Url;

        public IWebDriver Driver => webDriver;

        public DriverWrapper(IWebDriver webDriver, DriverConfiguration driverConfiguration)
        {
            this.webDriver = webDriver;
            this.driverConfiguration = driverConfiguration;
        }

        public IDriverWrapper Load()
        {
            webDriver.Url = BaseUrl;
            return this;
        }

        public IDriverWrapper Load(string path)
        {
            webDriver.Url = BaseUrl + path;
            return this;
        }

        public void Dispose()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
            }
        }

        public string Url()
        {
            return webDriver.Url;
        }

        public IWebElement FindElement(By by)
        {
            return webDriver.FindElement(by);
        }

        public IList<IWebElement> FindElements(By by)
        {
            return webDriver.FindElements(by);
        }
    }
}