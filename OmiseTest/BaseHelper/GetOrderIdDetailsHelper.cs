using NUnit.Framework;
using OmiseTest.Utill;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static OmiseTest.Model.OrderDetailObject;

namespace OmiseTest
{
    public class GetOrderIdDetailsHelper
    {
        public void GetOrderIdTest(string testName,
            string description,
            long orderId,
            double amount)
        {
            HttpResponseHelper orderResult = new HtttpRequestHelper().requestGetMethod(orderId);
            if (orderResult.ResponseStatusCode == HttpStatusCode.OK)
            {
                verifyOrderDetails(orderId, orderResult.Response, amount);
            }
            else {
                Assert.AreEqual(orderResult.ResponseStatusCode, HttpStatusCode.OK, "HTTP return :" + orderResult.ResponseStatusCode);
                WriteLine("Order statusCode:" + orderResult.ResponseStatusCode);
                WriteLine("Order status:" + orderResult.Response);
            }
          


        }

        public void verifyOrderDetails(long orderId,string response,double sellingAmount)
        {
            OrderDetail jsonRes = JsonConvert.DeserializeObject<OrderDetail>(response);
            WriteLine("Verify orderId :" + orderId);
            Assert.AreEqual(jsonRes.orderId, orderId,"API return orderId correctly");
            WriteLine("Verify order amount : " + sellingAmount);
            Assert.AreEqual(jsonRes.amount, sellingAmount,"Amount mismatch");
            
            
        }
        public void WriteLine(string message)
        {
            Trace.WriteLine(message);
        }

    }
}
