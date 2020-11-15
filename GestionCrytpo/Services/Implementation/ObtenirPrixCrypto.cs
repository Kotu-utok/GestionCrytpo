using GestionCrytpo.Services.Interface;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xaml.Permissions;

namespace GestionCrytpo.Services.Implementation
{
    public class ObtenirPrixCrypto : IObtenirPrixCrypto
    {
        public HttpClient HttpClient { get; }
        public ObtenirPrixCrypto(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<string> GetPrixCryptos()
        {
                var response = HttpClient.GetAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd").Result;
            
                string apiResponse = response.Content.ReadAsStringAsync().Result;
            var yourObject = JsonConvert.DeserializeObject<object>(apiResponse);
            return apiResponse;
        }
    }
}
