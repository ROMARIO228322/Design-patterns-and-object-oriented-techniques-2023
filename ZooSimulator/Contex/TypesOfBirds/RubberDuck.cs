using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.TypesOfBirds
{
    internal class RubberDuck : Bird
    {
        //Extracting the  IFlight from the parent class using base keyword.
        public RubberDuck(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Sound()
        {
            Console.WriteLine("It makes sqeak noise ");
        }
    }
}
