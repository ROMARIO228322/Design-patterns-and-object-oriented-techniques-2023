using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Strategy.ConcreteStrategy
{
    internal class NoFly : IFlight
    {
        public void PerformFly()
        {
            Console.WriteLine("*HIDES HEAD IN SAND AS IT CANNOT FLY*");
        }
    }
}
