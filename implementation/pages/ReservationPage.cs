using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;
using NUnit.Framework;

namespace netcore.template.Pages
{
    public class ReservationPage : BasePage
    {
        public static string ReservationUrl = string.Concat(BaseUrl,"/mercuryreservation.php");
        By PROFILE_LINK = By.LinkText("PROFILE");
        By COOKIE_ACCEPT_BUTTON = By.XPath("//a[text()='Agree and proceed']");

        public void Visit()
        {
            Driver.WebDriver.Navigate().GoToUrl(ReservationPage.ReservationUrl);
        }

        public void AcceptCookies()
        {
        }

        public void ValidateUserIsLoggedIn(string username)
        {

        }

        public void ValidateLogoIsDispalyed()
        {

        }

    }
}