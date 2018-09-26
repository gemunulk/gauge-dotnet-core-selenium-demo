using System;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.Pages;
using netcore.template.util;

namespace netcore.template
{
    public class LoginSpec
    {
        [Step("On Login page")]
        public void OnLoginPage()
        {   
            PageFactory.LoginPage.Visit();
        }

        [Step("Login as <username> using <password>")]
        public void LoginAs(string username, string password)
        {
            //var LoginPage = new LoginPage();
            //LoginPage.FillLoginForm(username, password);

            PageFactory.LoginPage.FillLoginForm(username, password);
            
        }
		[Step("Validate user <username> is logged in")]
		public void ValidateUserIsLoggedIn(string username)
		{
            PageFactory.ReservationPage.ValidateUserIsLoggedIn(username);
		}


    }
}