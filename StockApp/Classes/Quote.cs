using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using StockApp.Classes;

namespace StockApp.Classes
{
	public class Quote
	{
		private FinnHubQuoteResult result;
		private FinnHubCompanyResult company;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result">FinnHub API Result</param>
		/// <param name="company">FinnHub Company Result</param>
		public Quote(FinnHubQuoteResult result, FinnHubCompanyResult company)
		{
			this.result = result;
			this.company = company;
		}

		public string GetCompanyName ()
		{
			return company.name;
		}

		public string GetCurrentPrice()
		{
			return result.c.ToString();
		}

		public string GetHighPrice()
		{
			return result.h.ToString();
		}

		public string GetLowPrice()
		{
			return result.l.ToString();
		}
	}
}