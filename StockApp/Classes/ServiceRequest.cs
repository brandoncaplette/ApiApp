using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace StockApp.Classes
{
	/// <summary>
	/// Service for FinnHub API. See https://finnhub.io/docs/ for details.
	/// </summary>
	public partial class ServiceRequest
	{
		private readonly string companySymbol;
		private readonly string tokenId = ConfigurationManager.AppSettings["FinnHubApiToken"];
		private readonly string baseUrl = ConfigurationManager.AppSettings["FinnHubBaseUrl"];

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
			catch (Exception ex)
			{
				throw new Exception("Error submitting FinnHub HTTP Request", ex);
			}
		}
	}
}