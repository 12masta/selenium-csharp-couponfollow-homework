using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using System.Linq;
using TestFramework.Element;
using TestFramework.Waits;
using System;

namespace TestFramework.PageObjects.HomePage
{
    public class HomePage : BasePageObject, IHomePage
    {
        private IWebElement SearchField
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//input[@name='q']"));
            }
        }

        private IWebElement SearchList
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//ul[@class='sug']"));
            }
        }

        private IWait wait;
        private IWebElementComposer webElementComposer;

        public HomePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public HomePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, string path) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IHomePage SearchStore(string site)
        {
            webElementComposer.SendKeys(SearchField, site);
            return this;
        }

        public string GetDropdownHref(int v)
        {
            wait.UntilElementIsDisplayed(SearchList);
            return webElementComposer.GetAttribute(SearchList.FindElements(By.TagName("li"))
                .ElementAtOrDefault(v)
                .FindElement(By.TagName("a")), "href");                
        }
    }
}