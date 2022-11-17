using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage _homePage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        _homePage = new HomePage();

    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
    {

        Login("execute", "automation");
        _homePage.Initial.SendKeys("UZ");
        _homePage.Title("Mr.");
        _homePage.FirstName.SendKeys("Uros");
        _homePage.MiddleName.SendKeys("Zivadinovic");
        _homePage.Female.Click();
        _homePage.Hindi.Click();
        _homePage.SaveButton.Click();
    }

    [Test]
    public void TC02_OpenPopUp_ShouldDisplayed()
    {
        Login("execute", "automation");
        _homePage.HtmlPopup.Click();

    
    }


    [Test]
    public void TC03_OpenAlert_ShouldDisplayed()
    {
        Login("execute", "automation");
        _homePage.Generate.Click();

     
    }


    public void Login(string name, string pass)
    {
        _loginPage.LoginOnPage(name, pass);
    }
}
