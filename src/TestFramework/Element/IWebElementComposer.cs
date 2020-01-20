using OpenQA.Selenium;

namespace TestFramework.Element
{
    public interface IWebElementComposer
    {
        IWebElementComposer Click(IWebElement webElement);
        bool IsDisplayed(IWebElement webElement);
        bool IsDisplayed(By by);
        bool Selected(IWebElement webElement);
    }
}