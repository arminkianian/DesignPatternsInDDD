using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryOnAggregate.Model
{
    internal class Payment
    {
        public Guid Id { get; private set; }
        public long Amount { get; private set; }

        private Payment(long amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
        }

        public static Payment ForPayingOrder(Order order)
        {
            if (order.IsExpired) throw new Exception("Can't pay for expired order");

            return new Payment(order.TotalPrice);
        }

        public static Payment ForChargingWallet(long amount)
        {
            return new Payment(amount);
        }
    }
}
