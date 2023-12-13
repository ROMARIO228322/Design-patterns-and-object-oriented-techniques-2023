using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlling_IoT_devices
{
    /// <summary>
    /// This class is implemented as the invoker to execute the commands.
    /// </summary>
    internal class RemoteController
    {
        ICommand command;
        public RemoteController()
        {

        }
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void ButtonPressed()
        {
            {
                command.Execute();
            }
        }
    }
}
