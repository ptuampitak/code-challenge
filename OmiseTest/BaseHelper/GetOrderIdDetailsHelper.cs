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
            string status)
        {
            Console.WriteLine("Testname : "+ testName);
            Console.WriteLine("Test Description : " + description);
            var orderResult = new HtttpRequestHelper().requestGetMethod(orderId).Result;
            verifyOrderDetails(orderId, orderResult, status);
          


        }

        public void verifyOrderDetails(long expectedOrderId,string response,string expectedStatus)
        {
            OrderDetail jsonRes = JsonConvert.DeserializeObject<OrderDetail>(response);
            Console.WriteLine("Verify orderId :" + expectedOrderId);
            Assert.AreEqual(jsonRes.orderId, expectedOrderId, "API return orderId correctly");
            Console.WriteLine("Verify order status : " + expectedStatus);
            Assert.AreEqual(jsonRes.status, expectedStatus, "Order status:"+ jsonRes.status);
            
            
        }
     

    }
}
