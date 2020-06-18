using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace OmiseTest.TestCase
{
    [TestFixture]
    [Category("GET_Method")]
    public class RequestGetOrderDetails
    {
        public static IEnumerable<TestCaseData> GetOrderIdTestCases()
        {
            yield return new TestCaseData("GetOrderId001","Request valid orderId", 5,235.2);
            yield return new TestCaseData("GetOrderId002", "Request invalid orderId", 9999,400);
        }

        [TestCaseSource("GetOrderIdTestCases")]
        public void GetOrderId(
            string testName,
            string description,
            long orderId,
            double amount
            )
        {
            GetOrderIdDetailsHelper obj = new GetOrderIdDetailsHelper();
            obj.GetOrderIdTest(testName, description, orderId, amount);
            
        }
    }
}
