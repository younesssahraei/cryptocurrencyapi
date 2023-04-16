using currency1;
using currency2;
using currency3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace currency4
{
    internal class currencyApi
    {
        public static async Task<currencymodel> currencyinformation()
        {
            string url = "https://api.kucoin.com/api/v1/market/stats?symbol=ETH-USDT";
            using (HttpResponseMessage response = await ApiClient1.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CurrencyData result = await response.Content.ReadAsAsync<CurrencyData>();
                    return result.data;
                }
                else
                    throw new Exception(response.ReasonPhrase);

            }
        }
    }
}
