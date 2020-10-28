

namespace StockApp.Classes
{
	public class Quote
	{
		private FinnHubQuoteResult quoteResult;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteResult">FinnHub Quote Result</param>
		public Quote(FinnHubQuoteResult quoteResult)
		{
			this.quoteResult = quoteResult;
		}

		public float GetCurrentPrice()
		{
			return quoteResult.c;
		}

		public float GetHighPrice()
		{
			return quoteResult.h;
		}

		public float GetLowPrice()
		{
			return quoteResult.l;
		}
	}
}