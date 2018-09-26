using System;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;
using OpenQA.Selenium.Interactions;

namespace netcore.template.Pages
{
    public abstract class BasePage
    {    
        public IWebDriver driver;

        protected static readonly string BaseUrl = Environment.GetEnvironmentVariable("APP_ENDPOINT");
        protected static readonly string AdminUrl = string.Format("{0}admin/", BaseUrl);

        protected BasePage()
        {
            //PageFactory.InitElements(Driver.WebDriver, this);
            this.driver = Driver.WebDriver;
        }

        public IWebElement GetElement(string name)
        {
            var field = GetType().GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
            return field == null ? null : field.GetValue(this) as IWebElement;
        }

        protected static void ClearAndSetValue(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
        protected void SendKeys(By locator, string value)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).Clear();
            Driver.WebDriver.FindElement(locator).SendKeys(value);
        }

        protected void Click(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).Click();
        }

        protected string GetText(By locator)
        {            
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            string text = Driver.WebDriver.FindElement(locator).Text;
            return text;
        }
        
        protected string GetAttribute(By locator, String attributeName)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));

            return Driver.WebDriver.FindElement(locator).GetAttribute(attributeName);
        }
        protected string GetAttributeValue(By locator)
        {
            return GetAttribute(locator, "value");
        }

        protected void MoveTo(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            IWebElement element = Driver.WebDriver.FindElement(locator);

            Actions actions = new Actions(Driver.WebDriver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        protected void SwitchToTopWindow()
        {
            foreach(string handle in Driver.WebDriver.WindowHandles)
            {
                Driver.WebDriver.SwitchTo().Window(handle);
            }

            Driver.WebDriver.Manage().Window.Maximize();
        }

        protected void SwitchToFrame(int index)
        {
            Driver.WebDriver.SwitchTo().Frame(index);
        }

        protected void SwitchToDefaultContent()
        {
            Driver.WebDriver.SwitchTo().DefaultContent();
        }

        protected void Select(By locator, String visibleText)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(locator));

            try
            {
                select.SelectByText(visibleText);
            }
            catch (NoSuchElementException)
            {
                // Wait for 5 seconds and try
                System.Threading.Thread.Sleep(5000);
                select.SelectByText(visibleText);
            }

            catch (StaleElementReferenceException)
            {
                // Wait for 5 seconds and try
                System.Threading.Thread.Sleep(5000);
                select.SelectByText(visibleText);
            }

        }

        
    }
}
