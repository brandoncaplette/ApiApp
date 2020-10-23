using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockApp.Classes
{
	interface IFinnHubQuoteResult
	{
		/// <summary>
		/// Current Price
		/// </summary>
		float c { get; set; }
		/// <summary>
		/// High Price of the Day
		/// </summary>
		float h { get; set; }
		/// <summary>
		/// Low Price of the Day
		/// </summary>
		float l { get; set; }
		/// <summary>
		/// Open price of the day
		/// </summary>
		float o { get; set; }
		/// <summary>
		/// Previous close price
		/// </summary>
		float pc { get; set; }
		/// <summary>
		/// ????
		/// </summary>
		float t { get; set; }
	}	
}