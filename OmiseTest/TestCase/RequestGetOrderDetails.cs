using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace OmiseTest.TestCase
{

    [Category("GET_Method")]
    public class RequestGetOrderDetails
    {
        public static IEnumerable<TestCaseData> GetOrderIdTestCases()
        {
            yield return new TestCaseData("GetOrderId001","Request valid orderId", 38, "Transaction success");
            yield return new TestCaseData("GetOrderId002", "Request invalid orderId", 300,"OrderId not found");
        }

        [TestCaseSource("GetOrderIdTestCases")]
        public void GetOrderId(
            string testName,
            string description,
            long orderId,
            string status
            )
        {
            GetOrderIdDetailsHelper obj = new GetOrderIdDetailsHelper();
            obj.GetOrderIdTest(testName, description, orderId, status);
            
        }
    }
}
