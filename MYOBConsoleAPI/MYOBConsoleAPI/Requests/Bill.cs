using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MYOBConsoleAPI.Requests
{
    public class Bill
    {
        public static async Task<RestResponse> Create(string json, CookieContainer cookiejar, string uri)
        {

            RestClientOptions options = new RestClientOptions();
            options.CookieContainer = cookiejar;
            var client = new RestClient(options);

            string url = uri + "/Default/22.200.001/Bill";
            var request = new RestRequest();
            request = new RestRequest(url, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(json, DataFormat.Json);

            RestResponse response = await client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                Console.WriteLine(response.Content);
            }
            return response;
        }
    }
}
