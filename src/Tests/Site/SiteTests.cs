using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.SitePage;
using TextCopy;

namespace Tests.Site
{
    public class SiteTests : BaseTest
    {
        [Test]
        public void IsCouponModalOpen()
        {
            //when
            var sitePage = new SitePageFactory(driverWrapper, wait, webElementComposer)
                .Create("/site/dominos.com")
                .ClickShowCouponCode(0);

            //then
            sitePage.IsModalDisplayed().Should().BeTrue();
        }

        [Test]
        public void ProperTabsAreOpen()
        {
            //when
            var sitePage = new SitePageFactory(driverWrapper, wait, webElementComposer)
                .Create("/site/dominos.com")
                .ClickShowCouponCode(0)
                .SwitchToLinkedSiteTab();

            //then
            sitePage.Url().Should().Be("https://www.dominos.com/index.intl.html");
        }

        [Test]
        public void IsUserAbleToCopyCouponCode()
        {
            //when
            var couponCodeText = new SitePageFactory(driverWrapper, wait, webElementComposer)
                .Create("/site/dominos.com")
                .ClickShowCouponCode(0)
                .ClickCopyButton()
                .GetCouponCodeText();

            //then
            Clipboard.GetText().Should().Be(couponCodeText);
        }
    }
}