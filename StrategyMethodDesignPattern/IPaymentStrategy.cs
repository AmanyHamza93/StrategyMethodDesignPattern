using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMethodDesignPattern
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(float amount);
    }
}
