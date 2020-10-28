

namespace StockApp.Classes
{
	public class Company
	{
		private readonly FinnHubCompanyResult companyResult;
		public readonly Quote quote;

		public Company(FinnHubCompanyResult companyResult, Quote quote)
		{
			this.companyResult = companyResult;
			this.quote = quote;
		}

		public string GetCompanyName()
		{
			return companyResult.name;
		}
	}
}