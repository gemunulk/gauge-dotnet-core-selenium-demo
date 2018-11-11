using System;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.Pages;
using netcore.template.util;
using Gauge.CSharp.Lib;


namespace netcore.template
{
    public class RegistrationSpec
    {

		[Step("On Registration Page")]
		public void OnRegistrationPage()
		{
			PageFactory.RegistrationPage.Visit();
		}


		[Step("Fill Contact Information section <table>")]
		public void FillContactInformationSection(Table table)
		{
			var tableRows = table.GetTableRows();
            foreach (var row in tableRows)
            {
				PageFactory.RegistrationPage.FillContactInformationSection(row.GetCell("First Name"), row.GetCell("Last Name"), row.GetCell("Phone"),row.GetCell("Email"));
            }
	
		}



    }
}