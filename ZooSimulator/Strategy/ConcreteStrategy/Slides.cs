using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Strategy.ConcreteStrategy
{
    internal class Slides : IFlight
    {
        public void PerformFly()
        {
            Console.WriteLine("*SLIDES BY ITS BELLY*");
        }
    }
}
