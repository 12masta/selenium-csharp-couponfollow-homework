using System;
using OpenQA.Selenium;

namespace TestFramework.Waits
{
    public interface IWait
    {
        IWait UntilElementIsDisplayed(IWebElement searchList);
        IWait UntilElementIsDisplayed(IWebElement searchList, TimeSpan timeSpan);
        IWait UntilWindowsCountIsHigherThan(int v);
    }
}