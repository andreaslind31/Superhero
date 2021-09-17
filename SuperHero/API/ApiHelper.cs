using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SuperHero.API
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitClient()
        {
            ApiClient = new HttpClient();
            string key = "0a26e6e542f11ad100fa22d5db09821c";
            ApiClient.BaseAddress = 
                new Uri("http://gateway.marvel.com/v1/public/characters?apikey="+key+"&callback=callback_param");

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
