using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Strategy.ConcreteStrategy
{
    internal class Floats : IFlight
    {
        public void PerformFly()
        {
            Console.WriteLine("*FLOATS IN WATER*");
        }
    }
}
