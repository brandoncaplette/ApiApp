using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using StockApp.Classes;
using Newtonsoft.Json.Linq;

namespace StockApp.Classes
{

	//Calls API and returns Data.

	public partial class ServiceRequest
	{

		private string tokenId = "bu7044748v6rghl7nkng";
		private string companySymbol;
		private string baseUrl = "https://finnhub.io/api/v1/";

		public ServiceRequest(string companySymbol)
		{
			this.companySymbol = companySymbol;
		}

		public string GetQuotePrices()
		{
			string url = String.Format("{0}quote?symbol={1}&token={2}", baseUrl, companySymbol, tokenId);
			return FinnHubSubmitRequest(url);
		}

		public string GetCompanyInformation()
		{
			string url = String.Format("{0}stock/profile2?symbol={1}&token={2}", baseUrl, companySymbol, tokenId);
			return FinnHubSubmitRequest(url);
		}

		private string FinnHubSubmitRequest(string url)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				var webResponse = request.GetResponse();
				var webStream = webResponse.GetResponseStream();
				var responseReader = new StreamReader(webStream);
				var response = responseReader.ReadToEnd();
				string data = JObject.Parse(response).ToString();
				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}