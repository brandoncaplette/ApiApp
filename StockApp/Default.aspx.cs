using StockApp.Classes;
using System;
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
			string companySymbol = ListingCompany.Text;
			ServiceRequest serviceRequest = new ServiceRequest(companySymbol);
			FinnHubCompanyResult companyRes = JsonConvert.DeserializeObject<FinnHubCompanyResult>(serviceRequest.GetCompanyInformation());
			FinnHubQuoteResult quoteRes = JsonConvert.DeserializeObject<FinnHubQuoteResult>(serviceRequest.GetQuotePrices());
			Quote quote = new Quote(quoteRes, companyRes); 

			CurrentPrice.Text = quote.GetCurrentPrice();
			HighPrice.Text = quote.GetHighPrice();
			LowPrice.Text = quote.GetLowPrice();
			NameLabel.Text = quote.GetCompanyName();
		}
	}

	//TODO:
	//add companys to a watch list and update real time.
}