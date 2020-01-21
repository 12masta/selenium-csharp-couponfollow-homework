using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.HomePage;

namespace Tests.Search
{
    public class SearchTests : BaseTest
    {
        [Test]
        public void IsLinkToTheSiteAvailableOnTheDropdown()
        {
            //when
            var homePage = new HomePageFactory(driverWrapper, wait, webElementComposer)
                .Create("")
                .SearchStore("Domino's");

            //then
            homePage.GetDropdownHref(0).Should().Be(driverWrapper.BaseUrl + "/site/dominos.com");
        }
    }
}