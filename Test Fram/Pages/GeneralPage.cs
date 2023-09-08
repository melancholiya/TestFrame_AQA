using OpenQA.Selenium;

namespace Test_Fram.Pages
{
    public class GeneralPage : BasePage
    {
        private const string INPUT_FIELD_FIRST_NAME = "//input[@name='firstName']";
        public GeneralPage(IWebDriver driver) : base(driver)
        {

        }
        //public override GeneralPage NavigeteToUrl()
        //{
        //    driver.Navigate().GoToUrl(configData.GeneralUrl);
        //    return this;

        //}

        public void ChangeUserNameAndSaveChangesTest()
        {
            List<string> validUserNames = new List<string> { "sunshine", "сонечко", "ЯНА" };
            List<string> invalidUserNames = new List<string> { "777", " " };

            foreach (string userName in validUserNames)
            {
                EnterText(INPUT_FIELD_FIRST_NAME, userName);

            }

            foreach (string userName in invalidUserNames)
            {
                EnterText(INPUT_FIELD_FIRST_NAME, userName);
            }


        }
    }
}
