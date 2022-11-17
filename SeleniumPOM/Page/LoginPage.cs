using OpenQA.Selenium;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page
{
    public class LoginPage
    {

        private IWebDriver _driver = WebDriver.Instance;
        public IWebElement UserName => _driver.FindElement(By.XPath("//*[@id=\"userName\"]/p[1]/input"));
        public IWebElement Password => _driver.FindElement(By.XPath("//*[@id=\"userName\"]/p[2]/input"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//*[@id=\"userName\"]/p[3]/input"));

        
            
        public void LoginOnPage(string name, string password)
        {
           
           UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Submit();
        }
    }
}
