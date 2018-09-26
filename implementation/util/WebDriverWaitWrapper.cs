using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore.template.util
{
    public class WebDriverWaitWrapper
    {
        public static void WaitForElement(By by)
        {
            IWebDriver webDriver = Driver.WebDriver;

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElement(by));
        }

    }
}
