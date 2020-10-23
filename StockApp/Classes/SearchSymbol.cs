using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApp.Classes
{
	public class SearchSymbol
	{
	}


	public class Rootobject
	{
		public Class1[] Property1 { get; set; }
	}

	public class Class1
	{
		public string currency { get; set; }
		public string description { get; set; }
		public string displaySymbol { get; set; }
		public string symbol { get; set; }
		public string type { get; set; }
	}

}