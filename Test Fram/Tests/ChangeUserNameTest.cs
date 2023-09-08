using NUnit.Framework;
using Test_Fram.Pages;
using Test_Fram.TestModel;

namespace Test_Fram.Tests
{

    public class ChangeUserNameTest : BaseTest
    {


        [Test]
        public void ChangeUserNameAndSaveChanges()
        {

            HeaderSection headerSection = new HeaderSection(driver);
            headerSection.ClickButtonAndNavigate<GeneralPage>(HeaderSectionElements.general);
            GeneralPage generalPage = new GeneralPage(driver);
            generalPage.ChangeUserNameAndSaveChangesTest();


        }



    }
}

