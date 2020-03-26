using System;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace DogTorch.External.YahooFinance.ApiCaller
{
	public class YahooFinanaceApi
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly YahooFinanaceConfiguration _configuration;
		public YahooFinanaceApi(IHttpClientFactory httpClientFactory, IOptions<YahooFinanaceConfiguration> configuration)
		{
			_httpClientFactory = httpClientFactory;
			_configuration = configuration.Value;
		}

		/// <summary>
		/// TODO:
		/// https://rapidapi.com/apidojo/api/yahoo-finance1/endpoints
		/// 
		/// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1
		/// </summary>
		/// <param name="region"></param>
		/// <param name="language"></param>
		/// <returns></returns>
		public MarketSummaryEndpointResponse GetMarketSummary(string region, string language)
		{
			using(var httpClient = _httpClientFactory.CreateClient())
			{
				httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", _configuration.RapidApiHost);
				httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _configuration.RapidApiKey);
			}

			throw new NotImplementedException();
		}
	}
}
