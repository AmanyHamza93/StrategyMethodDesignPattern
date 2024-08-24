using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMethodDesignPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void ProcessPayment(float amount)
        {
            paymentStrategy.ProcessPayment(amount);
        }
    }
}
