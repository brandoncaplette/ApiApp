using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApp.Classes
{
	interface IFinnHubCompanyResult
	{
		string country { get; set; }
		string currency { get; set; }
		string exchange { get; set; }
		string finnhubIndustry { get; set; }
		string ipo { get; set; }
		string logo { get; set; }
		int marketCapitalization { get; set; }
		string name { get; set; }
		string phone { get; set; }
		float shareOutstanding { get; set; }
		string ticker { get; set; }
		string weburl { get; set; }
	}
}