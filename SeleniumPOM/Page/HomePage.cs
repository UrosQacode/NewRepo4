using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver _driver = WebDriver.Instance;

    public IWebElement Initial => _driver.FindElement(By.Id("Initial"));
    public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
    public IWebElement MiddleName => _driver.FindElement(By.Id("MiddleName"));
    public IWebElement Female => _driver.FindElement(By.Name("Female"));
    public IWebElement Hindi => _driver.FindElement(By.Name("Hindi"));
    public IWebElement SaveButton => _driver.FindElement(By.Name("Save"));
    public IWebElement HtmlPopup => _driver.FindElement(By.CssSelector(".detail_box a"));
    public IWebElement Generate => _driver.FindElement(By.Name("generate"));




    public void Title(string option)
    {
        SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
    }

    public void Alert()
    {
        _driver.SwitchTo().Alert();

        Generate.Click();
        _driver.SwitchTo().Alert().Accept();
        _driver.SwitchTo().Alert().Accept();
    }
}
