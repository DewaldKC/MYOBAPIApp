using MYOBConsoleAPI.DAC;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MYOBConsoleAPI.Requests
{
    public class Auth
    {      
        public static async Task<RestResponse> Login(string url)
        {
            LoginCredentials newLogin = new LoginCredentials
            {
                Name = "",
                Password = "",
                Tenant = "AIAP CLAIMS"
            };


            var client = new RestClient();
            var request = new RestRequest(url + "/auth/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");            
            var body = JsonConvert.SerializeObject(newLogin);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            return response;
        }

        public static async Task Logout(string url)
        {           
            var client = new RestClient();
            var request = new RestRequest(url + "auth/logout", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = await client.ExecuteAsync(request);
        }

        public class LoginCredentials
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("tenant")]
            public string Tenant { get; set; }

        }
    }


}
