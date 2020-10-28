using StockApp.Interfaces;

namespace StockApp.Classes
{
	public class FinnHubQuoteResult : IFinnHubQuoteResult
	{
		public float c { get; set; }
		public float h { get; set; }
		public float l { get; set; }
		public float o { get; set; }
		public float pc { get; set; }
		public float t { get; set; }
	}
}