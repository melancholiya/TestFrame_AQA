using OpenQA.Selenium;

namespace Test_Fram.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }
        private const string USER_NAME = "//*[@name='username']";
        private const string USER_PASS = "//*[@name='password']";
        private const string LOGIN_BTN = "//*[@type='submit']";
        public override LoginPage NavigeteToUrl()
        {
            driver.Navigate().GoToUrl(configData.LoginUrl);
            return this;
        }
        public HomePage LoginUser()
        {
            EnterText(USER_NAME, configData.UserManagement.Username);
            EnterText(USER_PASS, configData.UserManagement.Password);

            ClickElement(LOGIN_BTN);

            return new HomePage(driver);
        }
    }
}
