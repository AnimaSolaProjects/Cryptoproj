using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Cryptoproj.Models
{
    public static class DataFilling
    {
        private static readonly Uri ApiEndPoint = new Uri("https://api.coincap.io/v2/rates");

        public static AssetsList GetAllCurrencies()
        {
            using (var client = new HttpClient())
            {
                var responseMessage = client.GetAsync(ApiEndPoint).Result;
                var json = responseMessage.Content.ReadAsStringAsync().Result;

                var CurrenciesList = (AssetsList)JsonConvert.DeserializeObject(json, typeof(AssetsList));
                return CurrenciesList;
            }
        }
        public static List<Assets> Get10TopCurrencies()
        {
            var kek = GetAllCurrencies();
            List<Assets> currencies = new List<Assets>();
            for (int i = 0; i < 10; i++)
                currencies.Add(kek.data[i]);

            return currencies;
        }
        public static Assets GetAssetsByNameOrID(string Name, string Id)
        {
            Assets FoundAssetsbyName = GetAllCurrencies().data.FirstOrDefault(p => p.Name == Name || p.Id == Id);

            return FoundAssetsbyName;
        }
    }
}
