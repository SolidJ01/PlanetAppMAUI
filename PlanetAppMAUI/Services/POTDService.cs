using PlanetAppMAUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

#nullable enable
namespace PlanetAppMAUI.Services
{
    public class POTDService
    {
        HttpClient httpClient;
        public POTDService()
        {
            httpClient = new HttpClient();
        }



        public async Task<POTD> GetPOTD()
        {
            var url = "https://api.nasa.gov/planetary/apod?api_key=6xI2ACWdJCs5MiuVxHj1XCqOEgLOSUxcAdhC3gfU";
            var response = await httpClient.GetAsync(url);
            POTD potd = new POTD();

            if (response.IsSuccessStatusCode)
            {
                potd = await response.Content.ReadFromJsonAsync<POTD>();
            }
            return potd;
        }





        //private HttpClient httpClient;
        //private string url;

        //private POTD? potd = null;
        //public string ImageLink
        //{
        //    get
        //    {
        //        if (potd != null)
        //        {
        //            return potd.Url;
        //        }
        //        else
        //        {
        //            return "https://www.rymdstyrelsen.se/contentassets/7aa2644205cd4ae3895bb2c315b3e456/pluto_fotonasa.jpg";
        //        }
        //    }
        //}

        //public POTDService()
        //{
        //    httpClient = new HttpClient();
        //    url = "https://api.nasa.gov/planetary/apod?api_key=6xI2ACWdJCs5MiuVxHj1XCqOEgLOSUxcAdhC3gfU";
        //}

        //public async Task Get()
        //{
        //    //if (potd != null) return potd;

        //    var response = await httpClient.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var content = await response.Content.ReadAsStringAsync();
        //        potd = JsonSerializer.Deserialize<POTD>(content);
        //    }
        //}
    }
}
