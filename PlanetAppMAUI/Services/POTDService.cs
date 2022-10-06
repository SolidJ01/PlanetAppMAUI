using PlanetAppMAUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

#nullable enable
namespace PlanetAppMAUI.Services
{
    public class POTDService
    {
        private HttpClient httpClient;
        private string url;

        private POTD? potd = null;

        public POTDService()
        {
            httpClient = new HttpClient();
            url = "https://api.nasa.gov/planetary/apod?api_key=6xI2ACWdJCs5MiuVxHj1XCqOEgLOSUxcAdhC3gfU";
        }

        public async Task<POTD?> Get()
        {
            if (potd != null) return potd;
            
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                potd = JsonSerializer.Deserialize<POTD>(content);
                return potd;
            }

            return null;
        }
    }
}
