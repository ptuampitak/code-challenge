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
        public HttpResponseHelper requestGetMethod(long orderId) {
            HttpWebResponse response = null;
            string url = ConfigurationManager.AppSettings["get_booking_url"]+orderId;
            Uri MoodysWebAddress = new Uri(url);
            HttpWebRequest request = System.Net.WebRequest.Create(MoodysWebAddress) as HttpWebRequest;
            response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseStr = reader.ReadToEnd();

            return new HttpResponseHelper()
            {
                Response = responseStr,
                ResponseStatusCode = response.StatusCode
            }; ;
        }

        public HttpResponseHelper requestPostMethod(string requestFile)
        {
            HttpWebResponse response = null;
            string url = ConfigurationManager.AppSettings["post_order_url"];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json; encoding='utf-8'";
            request.Method = "POST";
            byte[] bytes;
            bytes = System.Text.Encoding.UTF8.GetBytes(requestFile);
            request.ContentLength = bytes.Length;
            response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseStr = reader.ReadToEnd();

            return new HttpResponseHelper()
            {
                Response = responseStr,
                ResponseStatusCode = response.StatusCode
            }; ;
        }

        public async Task<string> CreateItemAsync(string requestFile)
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






    }
}
