using System.Text.Json;
using UseCaseOne.Interfaces;
using UseCaseOne.Models;

namespace UseCaseOne.Services
{
	public class CountryService : ICountryService
	{
		private readonly HttpClient _httpClient;
		private const string endpointUrl = "v3.1/all";
		public CountryService(HttpClient httpClient)
		{
			this._httpClient = httpClient;
		}

		public async Task<IEnumerable<CountryInfo>> GetAllAsync()
		{
			var response = await _httpClient.GetAsync(endpointUrl);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				var options = new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true
				};
				var countries = JsonSerializer.Deserialize<IEnumerable<CountryInfo>>(content, options);
				return countries;
			}
			else
			{
				// Handle the error accordingly
				throw new HttpRequestException($"Unable to get countries. Status code: {response.StatusCode}");
			}

		}
	}
}
