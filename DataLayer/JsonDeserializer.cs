using DataLayer.DTO;
using System.Text.Json;

namespace DataLayer
{
    public class JsonDeserializer
    {
        private readonly HttpClient _httpClient;

        public JsonDeserializer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T[]> DeserializeFromAPI<T>(string requestUri)
        {
            using HttpResponseMessage responseMessage = await _httpClient.GetAsync(requestUri);


            if (responseMessage.IsSuccessStatusCode)
            {
                T[]? arr = await JsonSerializer.DeserializeAsync<T[]>(await responseMessage.Content.ReadAsStreamAsync());
                return arr;
            }
            else
            {
                MessageBox.Show($"Bad API call. Failed to fetch data.");
                return Array.Empty<T>();
            }
        }
    }
}
