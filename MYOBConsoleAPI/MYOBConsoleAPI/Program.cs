using MYOBConsoleAPI.DAC;
using MYOBConsoleAPI.Requests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using static System.Net.WebRequestMethods;

namespace MYOBConsoleAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string uri = "https://gowgates.myobadvanced.com/entity";
            try
            {
                RestResponse response = await Auth.Login(uri);
                if (!response.IsSuccessful)
                {
                    throw new Exception($"Login Failed - {response.StatusCode}");
                }

                // Set Cookies
                CookieContainer cookieJar = new CookieContainer();                
                foreach (Cookie cookie in response.Cookies)
                {
                    cookieJar.Add(cookie);
                }

                /**
                 *  Loop through the data (Employsure/Aramex)
                 * foreach (var item in CSV Data)
                 * {
                 *  // assign values
                 * }
                 * 
                 * Convert ot Json
                 */

                string supplierJson = DAC.Supplier.SupplierExampleJSON();
                RestResponse supplierResponse = await Requests.Suppliers.Create(supplierJson, cookieJar, uri);

                string billJson = DAC.Bill.BillExampleJSON();
                RestResponse billResponse = await Requests.Bill.Create(billJson, cookieJar, uri);

            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                await Auth.Logout(uri);
            }  
        }
    }
}
