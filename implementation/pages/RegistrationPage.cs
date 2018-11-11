using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;
using NUnit.Framework;

namespace netcore.template.Pages
{
    public class RegistrationPage : BasePage
    {
        public static string RegistrationUrl = string.Concat(BaseUrl,"/mercuryregister.php");
        By FIRST_NAME = By.Name("firstName");
        By LAST_ANME = By.Name("lastName");
        By PHONE = By.Name("phone");
        By EMAIL = By.Name("userName");


        public void Visit()
        {
            Driver.WebDriver.Navigate().GoToUrl(RegistrationUrl);
        }

        public void FillContactInformationSection(string firstName, string lastName, string phone, string email)
        {
            SendKeys(FIRST_NAME, firstName);
            SendKeys(LAST_ANME, lastName);
            SendKeys(PHONE, phone);
            SendKeys(EMAIL, email);
            
        }


    }
}