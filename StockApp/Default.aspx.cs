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
			FinnHubCompanyResult companyResult = JsonConvert.DeserializeObject<FinnHubCompanyResult>(serviceRequest.GetCompanyInformation());
			FinnHubQuoteResult quoteResult = JsonConvert.DeserializeObject<FinnHubQuoteResult>(serviceRequest.GetQuotePrices());
			// FinnHubNewsResult newsResult = JsonConvert.DeserializeObject<FinnHubNewsResult>(serviceRequest.GetCompanyNews());
			Quote quote = new Quote(quoteResult);
			// News news = new News(newsResult);
			Company company = new Company(companyResult, quote);
			// Company company = new Company(companyResult, quote, news);

			CurrentPrice.Text = company.quote.GetCurrentPrice().ToString();
			HighPrice.Text = company.quote.GetHighPrice().ToString();
			LowPrice.Text = company.quote.GetLowPrice().ToString();
			NameLabel.Text = company.GetCompanyName();
			// TODO: display the selected companys news.
		}
	}

	// TODO: add companies to a watch list and update real time.
}