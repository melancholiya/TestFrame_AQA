using FluentAssertions;
using NUnit.Framework;
using Test_Fram.Pages;

namespace Test_Fram.Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void TestLoginSuccess()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.NavigeteToUrl();
            loginPage.WaitUntilPageIsLoaded();
            loginPage.LoginUser();

            driver.Url.ToLowerInvariant().Contains("/fictadvisor").Should().BeTrue();
        }
    }
}
