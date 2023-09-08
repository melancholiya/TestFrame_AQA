using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Test_Fram.TestModel;

namespace Test_Fram.Pages
{
    public class BasePage
    {
        protected static IWebDriver? driver { get; private set; }

        protected static WebDriverWait? wait { get; private set; }
        protected static ConfigData configData { get; private set; }

        public BasePage(IWebDriver _driver)
        {
            driver = _driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            configData = ConfigReader.ReadDataFromJson("D:/testing/Test Fram/Test Fram/data.json");
        }

        public void WaitUntilPageIsLoaded()
        {
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public virtual BasePage NavigeteToUrl()
        {
            return this;
        }


        public IWebElement WaitForElementToBeCliclable(string xpath)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
        }

        public IWebElement WaitForElementToBeVisible(string xpath)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        public string GetText(string xpath)
        {
            return WaitForElementToBeVisible(xpath).Text;
        }
        public void ClickElement(string xpath)
        {
            WaitForElementToBeCliclable(xpath).Click();


        }
        public BasePage EnterText(string xpath, string text)
        {
            var element = WaitForElementToBeVisible(xpath);
            element.Clear();
            element.SendKeys(text);
            return this;
        }
    }
}
