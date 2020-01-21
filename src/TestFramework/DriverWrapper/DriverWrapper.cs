using System;
using TestFramework.Dto;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

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

        public IDriverWrapper SwitchToWindow(int v)
        {
            var window = Driver.WindowHandles.ElementAtOrDefault(v);
            Driver.SwitchTo().Window(window);
            return this;
        }

        public IDriverWrapper SwitchToCouponFollowWindow()
        {
            for (int i = 0; i < Driver.WindowHandles.Count; i++)
            {
                Driver.SwitchTo().Window(Driver.WindowHandles.ElementAtOrDefault(i));
                if (Driver.Url.Contains(BaseUrl))
                {
                    break;
                }
            }
            return this;
        }
    }
}