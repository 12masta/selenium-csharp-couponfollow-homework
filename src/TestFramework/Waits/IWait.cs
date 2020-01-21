using System;
using OpenQA.Selenium;

namespace TestFramework.Waits
{
    public interface IWait
    {
        IWait UntilElementIsNotDisplayed(IWebElement WebElement);
        IWait UntilElementIsNotDisplayed(By by);
        IWait UntilElementIsNotDisplayed(By by, TimeSpan timeSpan);
        IWait UntilElementIsDisplayed(IWebElement searchList);
        IWait Until(TimeSpan timeSpan);
    }
}