using OpenQA.Selenium;

namespace TestFramework.Element
{
    public interface IWebElementComposer
    {
        IWebElementComposer Click(IWebElement webElement);
        bool IsDisplayed(IWebElement webElement);
        bool IsDisplayed(By by);
        bool Selected(IWebElement webElement);
        IWebElementComposer SendKeys(IWebElement webElement, string text);
        string GetAttribute(IWebElement webElement, string attribute);
        string GetText(IWebElement webElement);
    }
}