using System.Collections.Generic;
using OpenQA.Selenium;

namespace TestFramework.DriverWrapper
{
    public interface IDriverWrapper
    {
        string BaseUrl { get; }
        IWebDriver Driver { get; }
        IDriverWrapper Load();
        IDriverWrapper Load(string path);
        string Url();
        void Dispose();
        IWebElement FindElement(By by);
        IList<IWebElement> FindElements(By by);
        IDriverWrapper SwitchToWindow(int v);
        IDriverWrapper SwitchToCouponFollowWindow();
    }
}