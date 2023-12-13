using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context
{
    //This is superclass of all types of birds also known as context. Here the Instance variable hold reference to the Strategy Behaviour(i.e,IFlight) at runtime.
    abstract class Bird
    {
        //Instance variable.
        IFlight flighttype;

        public Bird(IFlight flighttype)
        {
            this.flighttype = flighttype;
        }

        public string? Name { get; set; }
        public string? Color { get; set; }

     
        public void PerformFly()
        {
            //delegate to performFly behaviour
            flighttype.PerformFly();
        }
        
        // Making setters for perfomfly.
        public void SetPerformFly(IFlight flighttype)
        {
            this.flighttype = flighttype;
        }
    }
}
