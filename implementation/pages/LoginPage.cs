using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;

namespace netcore.template.Pages
{
    public class LoginPage : BasePage
    {
        public static string LoginUrl = string.Concat(BaseUrl,"/");
        By USRNAME_TEXT = By.Name("userName");
        By PASSWORD_TEXT = By.Name("password");
        By LOGIN_BUTTON = By.XPath("//input[@name='login']");

        public void Visit()
        {
            Driver.WebDriver.Navigate().GoToUrl(LoginPage.LoginUrl);
        }
               

        public void FillLoginForm(string username, string password)
        {
            
            //IWebDriver webDriver = Driver.WebDriver;
            // WebDriverWaitWrapper.WaitForElement(USRNAME_TEXT);
            //webDriver.FindElement(By.Name("userName")).SendKeys(username);
            //webDriver.FindElement(By.Name("password")).SendKeys(password);
            //webDriver.FindElement(By.Name("login")).Click();
            
            SendKeys(USRNAME_TEXT, username);
            SendKeys(PASSWORD_TEXT, password);
            Click(LOGIN_BUTTON);

        }


    }
}