using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMethodDesignPattern
{
    public class BitcoinPayment: IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of { amount} dollars.");
        }
    }
}
