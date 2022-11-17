using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver _driver = WebDriver.Instance;
    public IWebElement Title => _driver.FindElement(By.Id("TitleId"));
    public IWebElement Initial => _driver.FindElement(By.Id("Initial"));
    public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
    public IWebElement MiddleName => _driver.FindElement(By.Id("MiddleName"));
    public IWebElement Gender => _driver.FindElement(By.Name("Male"));
    public IWebElement LanguagesKnown => _driver.FindElement(By.Name("english"));




    public void SelectOption(string option)
    {
        SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
    }


}
