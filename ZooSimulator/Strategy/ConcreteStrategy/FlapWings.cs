using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Strategy.ConcreteStrategy
{
    internal class FlapWings : IFlight
    {
        public void PerformFly()
        {
            Console.WriteLine("*FLIES BY FLAPS WINGS*");
        }
    }
}
