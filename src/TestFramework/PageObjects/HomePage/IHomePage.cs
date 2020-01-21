namespace TestFramework.PageObjects.HomePage
{
    public interface IHomePage
    {
        string Url();
        IHomePage SearchStore(string site);
        string GetDropdownHref(int v);
    }
}