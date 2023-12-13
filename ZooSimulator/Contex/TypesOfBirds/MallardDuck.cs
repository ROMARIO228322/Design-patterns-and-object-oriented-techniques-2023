using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.TypesOfBirds
{
    // This is the class for the different types of birds in the Simulator. 
    /// <summary>
    /// It inherits the abstract class references which connects the rest of the behaviour with the concrete behaviours.
    /// </summary>
    internal class MallardDuck : Bird
    {
        //Extracting the  IFlight from the parent class using base keyword.
        public MallardDuck(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Quack()
        {
            Console.WriteLine("It does quack");
        }
        public static void Swim()
        {
            Console.WriteLine("It swims in water.");
        }
    }
}
