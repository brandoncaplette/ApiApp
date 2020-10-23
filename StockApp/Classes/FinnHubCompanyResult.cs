using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApp.Classes
{
	public class FinnHubCompanyResult : IFinnHubCompanyResult
	{
		public string country { get; set; }
		public string currency { get; set; }
		public string exchange { get; set; }
		public string finnhubIndustry { get; set; }
		public string ipo { get; set; }
		public string logo { get; set; }
		public int marketCapitalization { get; set; }
		public string name { get; set; }
		public string phone { get; set; }
		public float shareOutstanding { get; set; }
		public string ticker { get; set; }
		public string weburl { get; set; }
	}
}