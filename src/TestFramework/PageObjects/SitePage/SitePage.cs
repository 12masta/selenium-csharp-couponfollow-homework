using System.Collections.Generic;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.PageObjects.ExternalSitePage;
using TestFramework.Waits;
using System.Linq;
using System;

namespace TestFramework.PageObjects.SitePage
{
    public class SitePage : BasePageObject, ISitePage
    {
        private IList<IWebElement> Coupons
        {
            get
            {
                return driverWrapper.FindElements(By.TagName("article"));
            }
        }

        private IWebElement Modal
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//div[@class='popup-cont']"));
            }
        }

        private IWebElement CopyButton
        {
            get
            {
                return driverWrapper.FindElement(By.Id("copy-button"));
            }
        }

        private IWebElement CouponCode
        {
            get
            {
                return driverWrapper.FindElement(By.Id("coupon-code"));
            }
        }

        private IWait wait;
        private IWebElementComposer webElementComposer;

        public SitePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public SitePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, string path) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public ISitePage ClickShowCouponCode(int v)
        {
            webElementComposer.Click(Coupons.ElementAtOrDefault(v).FindElement(By.XPath(".//a[@data-func='showCode']")));
            wait.UntilWindowsCountIsHigherThan(1);
            driverWrapper.SwitchToCouponFollowWindow();
            return this;
        }

        public bool IsModalDisplayed()
        {
            wait.UntilElementIsDisplayed(Modal, TimeSpan.FromSeconds(5));
            return webElementComposer.IsDisplayed(Modal);
        }

        public IExternalSitePage SwitchToLinkedSiteTab()
        {
            driverWrapper.SwitchToWindow(0);
            return new ExternalSitePageFactory(driverWrapper, wait, webElementComposer).Create();
        }

        public ISitePage ClickCopyButton()
        {
            webElementComposer.Click(CopyButton);
            return this;
        }

        public string GetCouponCodeText()
        {
            return webElementComposer.GetText(CouponCode);
        }
    }
}