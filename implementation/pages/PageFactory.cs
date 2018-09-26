using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;
using Gauge.CSharp.Lib.Attribute;


namespace netcore.template.Pages
{
    public class PageFactory
    {
        //public static IWebDriver driver;

        public static LoginPage LoginPage;
        public static ReservationPage ReservationPage;

        [BeforeSuite]
        public void init()
        {
            //driver          = DriverFactory.GetDriver();

            LoginPage =  new LoginPage();
            ReservationPage = new ReservationPage();
          
        }

    }
}