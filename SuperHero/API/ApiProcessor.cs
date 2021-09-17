using SuperHero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperHero.API
{
    public class ApiProcessor
    {
        public static async Task<ApiModel> LoadData()
        {

            string url = ApiHelper.ApiClient.BaseAddress.ToString();


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiModel data = await response.Content.ReadAsAsync<ApiModel>();

                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }
    }
}
