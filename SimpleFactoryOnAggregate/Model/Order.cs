using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryOnAggregate.Model
{
    internal class Order
    {
        public long TotalPrice { get; private set; }
        public bool IsExpired { get; set; }

        public Order(long totalPrice)
        {
            TotalPrice = totalPrice;
        }
    }
}
