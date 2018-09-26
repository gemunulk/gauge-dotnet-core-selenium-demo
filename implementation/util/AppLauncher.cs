using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.util;
using System.Configuration;


namespace netcore.template
{
    public class AppLauncher
    {
        [Step("Go to the store website")]
        public void LaunchTheApplication()
        {
            Driver.WebDriver.Navigate().GoToUrl(Environment.GetEnvironmentVariable("APP_URL"));
            
        }

    }
}
