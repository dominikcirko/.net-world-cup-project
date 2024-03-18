using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DataLayer.SelectGenderLanguageUtils;

namespace DataLayer
{
    public class ChampionshipUtils : Championship
    {
        private readonly HttpClient _httpClient;

        public ChampionshipUtils(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Championship[]> Deserialize(string requestUri)
        {

            HttpResponseMessage responseMessage = await _httpClient.GetAsync(requestUri);


            if (responseMessage.IsSuccessStatusCode)
            {
                Championship[]? arr = await JsonSerializer.DeserializeAsync<Championship[]>(await responseMessage.Content.ReadAsStreamAsync());
                return arr;
            }
            else
            {
                MessageBox.Show($"Bad API call. Failed to fetch data.");
                return Array.Empty<Championship>();
            }
            
        }

        public void SaveChampionshipToTxt(ComboBox comboBox) {
            string relativePath = "gender-language.txt";

            using (StreamWriter sw = new StreamWriter(relativePath, true))
            {
                if (File.Exists(relativePath))
                {
                    sw.WriteLine("Championship: " + comboBox.SelectedItem.ToString());
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }

        }
    }
}
