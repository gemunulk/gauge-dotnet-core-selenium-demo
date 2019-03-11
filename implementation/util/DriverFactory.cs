using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace netcore.template.util
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER");
            var webDriverPath = Environment.GetEnvironmentVariable("WEB_DRIVER_PATH");
            Console.WriteLine(browser);
           
            switch (browser)
            {
                case "chrome":
                    //return new ChromeDriver(@"/Users/gemunu/Documents/WebDriver");
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    return new ChromeDriver();
                case "ie":
                    return new InternetExplorerDriver();
                default:
                    return new FirefoxDriver();
            }
        }
    }
}
