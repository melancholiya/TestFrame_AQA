using OpenQA.Selenium;

namespace Test_Fram.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public override HomePage NavigeteToUrl()
        {
            driver.Navigate().GoToUrl(configData.BaseUrl);
            return this;
        }
    }
}
