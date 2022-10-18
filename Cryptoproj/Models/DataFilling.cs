using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace Cryptoproj.Models
{
    public static class DataFilling
    {
        private static readonly Uri ApiEndPoint = new Uri("https://api.coincap.io/v2/assets");

        // filling the data list with all available cryptocurrency
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
        // filling in the data list top 10 most popular cryptocurrencies
        public static ObservableCollection<Assets> Get10TopCurrencies()
        {
            var kek = GetAllCurrencies();
            ObservableCollection<Assets> currencies = new ObservableCollection<Assets>();
            for (int i = 0; i < 10; i++)
                 currencies.Add(kek.data[i]);

            return currencies;
        }
    }
}
