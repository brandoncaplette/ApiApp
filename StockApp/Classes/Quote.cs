

namespace StockApp.Classes
{
	public class Quote
	{
		private FinnHubQuoteResult quote;
		private FinnHubCompanyResult company;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="quote">FinnHub Quote Result</param>
		/// <param name="company">FinnHub Company Result</param>
		public Quote(FinnHubQuoteResult quote, FinnHubCompanyResult company)
		{
			this.quote = quote;
			this.company = company;
		}

		public string GetCompanyName ()
		{
			return company.name;
		}

		public string GetCurrentPrice()
		{
			return quote.c.ToString();
		}

		public string GetHighPrice()
		{
			return quote.h.ToString();
		}

		public string GetLowPrice()
		{
			return quote.l.ToString();
		}
	}
}