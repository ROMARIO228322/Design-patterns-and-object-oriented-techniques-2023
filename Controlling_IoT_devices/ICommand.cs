using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlling_IoT_devices
{
    //This is the common interface that every receiver classes commands use.
    internal interface ICommand
    {
        public void Execute();
    }
}
