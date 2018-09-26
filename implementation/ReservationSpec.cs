using System;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.Pages;
using netcore.template.util;

namespace netcore.template
{
    public class ReservationSpec
    {

		[Step("Agreee and proceed with Cookies")]
		public void AgreeeAndProceedCookes()
		{
            PageFactory.ReservationPage.AcceptCookies();
		}
		[Step("Validate user profile is displayed")]
		public void ValidateUserProfileIsDisplayed()
		{
			//throw new NotImplementedException();
      PageFactory.ReservationPage.ValidateLogoIsDispalyed();
		}



    }
}