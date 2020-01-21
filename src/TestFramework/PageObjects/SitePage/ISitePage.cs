using TestFramework.PageObjects.ExternalSitePage;

namespace TestFramework.PageObjects.SitePage
{
    public interface ISitePage
    {
        string Url();
        ISitePage ClickShowCouponCode(int v);
        bool IsModalDisplayed();
        IExternalSitePage SwitchToLinkedSiteTab();
    }
}