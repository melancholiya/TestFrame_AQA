using OpenQA.Selenium;
using Test_Fram.TestModel;

namespace Test_Fram.Pages
{
    public class HeaderSection : BasePage
    {
        private const string BUTTON_GENERAL = "//span[text()='Гаврильчик Яна Вікторівна']";
        private const string BUTTON_LOGIN = "//button[contains(., 'Увійти')]";
        private const string BUTTON_POLL = "//a[contains(@class, 'MuiLink-root') and @href='/poll']/button[contains(@class, 'css-p4kng1')]";
        private const string BUTTON_TEACHERS = "//a[contains(@class, 'MuiLink-root') and @href='/teachers']/button[contains(@class, 'css-p4kng1')]";

        private Dictionary<HeaderSectionElements, string> HeaderSectionEnum { get; set; }
        private Dictionary<HeaderSectionElements, Func<IWebDriver, BasePage>> HeaderSectionNavigation { get; set; }
        public HeaderSection(IWebDriver driver) : base(driver)
        {
            HeaderSectionEnum = new Dictionary<HeaderSectionElements, string>
            {
                {HeaderSectionElements.general,BUTTON_GENERAL},
                {HeaderSectionElements.poll, BUTTON_POLL},
                {HeaderSectionElements.teachers, BUTTON_TEACHERS},
                {HeaderSectionElements.login,BUTTON_LOGIN}
            };

            HeaderSectionNavigation = new Dictionary<HeaderSectionElements, Func<IWebDriver, BasePage>>
            {
                {HeaderSectionElements.general, driver=>new GeneralPage(driver)},
                {HeaderSectionElements.poll, driver=>new PollPage(driver)},
                {HeaderSectionElements.teachers, driver=>new TeachersPage(driver)},
                {HeaderSectionElements.login, driver=>new LoginPage(driver)}
            };
        }

        public override HeaderSection NavigeteToUrl()
        {
            driver.Navigate().GoToUrl(configData.BaseUrl);
            return this;
        }

        public T ClickButtonAndNavigate<T>(HeaderSectionElements headerSectionElements) where T : BasePage
        {
            if (!HeaderSectionEnum.ContainsKey(headerSectionElements))
            {
                throw new ArgumentException($"Invalid button type: {headerSectionElements}");
            }

            string btnXpath = HeaderSectionEnum[headerSectionElements];
            WaitForElementToBeCliclable(btnXpath).Click();

            if (HeaderSectionNavigation.TryGetValue(headerSectionElements, out var navigation))
            {
                return (T)navigation(driver);
            }
            throw new ArgumentException($"Unhandled button type: {headerSectionElements}");
        }

    }
}
