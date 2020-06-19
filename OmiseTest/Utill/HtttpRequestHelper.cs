using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;

namespace OmiseTest.Utill
{
    class HtttpRequestHelper
    {  
        public async Task<string> requestPostMethod(string requestFile)
        {
            
            HttpClient httpClient = new HttpClient();
            var todoItemJson = new StringContent(
                requestFile,
                Encoding.UTF8,
                "application/json");
            string url = ConfigurationManager.AppSettings["post_order_url"];
            var httpResponse = await httpClient.PostAsync(url, todoItemJson);
            string output = await httpResponse.Content.ReadAsStringAsync();

            return output;


        }

         public async Task<string> requestGetMethod(long orderId)
        {
            
            HttpClient httpClient = new HttpClient();
            string url = ConfigurationManager.AppSettings["get_order_url"] + orderId;
            var httpResponse = await httpClient.GetAsync(url);
            string output = await httpResponse.Content.ReadAsStringAsync();

            return output;


        }






    }
}
