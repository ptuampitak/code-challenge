using NUnit.Framework;
using OmiseTest.BaseHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmiseTest.TestCase
{
    class CreateNewOrder
    {
        public static IEnumerable<TestCaseData> CreateNewOrderTestCases()
        {
            yield return new TestCaseData("CreateOrder001", "Create new order for buying bitcoin", "create_new_order_01.json","SUCCESS");
            yield return new TestCaseData("CreateOrder002", "Create new order for selling bitcoin with invalid quatity", "create_new_order_02.json","FAILED");
        }

        [TestCaseSource("CreateNewOrderTestCases")]
        public void CreateOrder(
            string testName,
            string description,
            string filename,
            string status
            )
        {
            CreateNewOrderHelper obj = new CreateNewOrderHelper();
            obj.CreateNewOrderTest(testName, description,filename, status);

        }
    }
}
