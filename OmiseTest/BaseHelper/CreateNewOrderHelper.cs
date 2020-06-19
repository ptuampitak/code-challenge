using Newtonsoft.Json;
using NUnit.Framework;
using OmiseTest.Utill;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OmiseTest.Model.OrderDetailObject;

namespace OmiseTest.BaseHelper
{
    public class CreateNewOrderHelper
    {
        private string ORDER_REQUEST_JSON_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\");
        public void CreateNewOrderTest(string testName,
           string description,
           string filename,
           string status)
        {
            string content = ReadCreateOrderRequestFile(filename);
            var orderResult = new HtttpRequestHelper().requestPostMethod(content).Result;
            verifyCreateNewOrder(orderResult, status);
        }

        public void verifyCreateNewOrder(string response, string expectedStatus)
        {
            CreateOrder jsonRes = JsonConvert.DeserializeObject<CreateOrder>(response);
            Assert.AreEqual(jsonRes.status, expectedStatus, "Status mismatch");

        }

        protected string ReadCreateOrderRequestFile(string filename)
        {
            string toReturnPath = ORDER_REQUEST_JSON_PATH + filename;
            Assert.True(File.Exists(toReturnPath), string.Format("File not found on path '{0}'", toReturnPath));
            return File.ReadAllText(toReturnPath);
        }

    }
}
