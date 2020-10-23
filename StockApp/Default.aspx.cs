using StockApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace StockApp
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Submit_Click(object sender, EventArgs e)
		{
			var companySymbol = ListingCompany.Text;
			var serviceRequest = new ServiceRequest(companySymbol);
			var company = JsonConvert.DeserializeObject<FinnHubCompanyResult>(serviceRequest.GetCompanyInformation());
			var results = JsonConvert.DeserializeObject<FinnHubQuoteResult>(serviceRequest.GetQuotePrices());
			Quote quote = new Quote(results, company); 

			CurrentPrice.Text = quote.GetCurrentPrice();
			HighPrice.Text = quote.GetHighPrice();
			LowPrice.Text = quote.GetLowPrice();
			NameLabel.Text = quote.GetCompanyName();
		}
	}

	//TODO:
	//add companys to a watch list and update real time.

}