using Newtonsoft.Json;
using PruebasAPI.Models;

namespace PruebasAPI.Repositories
{
    public class CountriesRepository
    {
        private HttpClient _httpClient;

        public CountriesRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Country>> GetCountryListAsync()
        {
            string url = "https://restcountries.com/v3.1/all";
            string response_json = await _httpClient.GetStringAsync(url);
            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(response_json);
            return countries;
        }
    }
}
