using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Fram.Pages;
using Test_Fram.TestModel;

namespace Test_Fram.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected ConfigData configData = ConfigReader.ReadDataFromJson("D:/testing/Test Fram/Test Fram/data.json");

        protected void LoginMethod()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.NavigeteToUrl();
            loginPage.WaitUntilPageIsLoaded();
            loginPage.LoginUser();
        }
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            LoginMethod();
        }
        [TearDown]
        public void TeardownTest()
        {
            driver.Close();
        }
    }
}
