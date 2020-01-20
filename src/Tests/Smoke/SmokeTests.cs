using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.HomePage;

namespace Tests.Smoke
{
    public class SmokeTests : BaseTest
    {
        [Test]
        public void Smoke()
        {
            //when
            var homePage = new HomePageFactory(driverWrapper)
                .Create("");

            //then
            homePage.Url().Should().Be(driverWrapper.BaseUrl + "/");
        }
    }
}