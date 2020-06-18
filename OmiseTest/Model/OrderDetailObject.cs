using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmiseTest.Model
{
    class OrderDetailObject
    {
        public class OrderDetail
        {
            public int orderId { get; set; }
            public string status { get; set; }
            public double amount { get; set; }
            public string currencyCode { get; set; }
            public string side { get; set; }
        }

        public class CreateOrder
        {
            public long symbol { get; set; }
            public int orderId { get; set; }
            public string clientOrderId { get; set; }
            public long transactTime { get; set; }
            public double price { get; set; }
            public string side { get; set; }
            public string status { get; set; }

        }
    }
}