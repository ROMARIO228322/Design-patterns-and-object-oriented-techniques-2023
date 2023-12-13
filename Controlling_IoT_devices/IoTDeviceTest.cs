using Controlling_IoT_devices.IoTDevices;
using System;


namespace Controlling_IoT_devices
{
    public class IoTDeviceTest
    {
        public static void Main(String[] args)
        {
            

            //Initiating the light object and ThermoStatObject.
            Light light = new Light();
            Thermostat thermostat = new Thermostat();

            //All of the Commands.
            LightTurningOn lightOn = new LightTurningOn(light);
            LightTurningOff lightOff = new LightTurningOff(light);
            IncreaseThermoStatTemp increaseTemp = new IncreaseThermoStatTemp(thermostat);
            DecreaseThermoStatTemp decreaseTemp = new DecreaseThermoStatTemp(thermostat);

           
            //Displaying the default status of the light and thermostat in the console.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Default Status of Light and thermostat:");
            Console.WriteLine(light.GetStatus() + "\n" + thermostat.GetStatus() + "\n");
            Console.ResetColor();
            RemoteController remote = new RemoteController();

            Dictionary<int, ICommand> remoteKeysMap = new Dictionary<int, ICommand>
            {
                {1,lightOn },
                {2,lightOff },
                {3, increaseTemp },
                {4, decreaseTemp },
                
            };
            Console.WriteLine("Button's are as follow:"+"\n1: Turns Light On" + "\n2: Turns Light Off" 
                + "\n3: Increase Temperature of ThermoStat" + "\n4: Decrease Temperature of Thermostat \n<Enter> or Esc to exit program\n");
           


            while (true)
            {
                Console.Write("Press button (1-4): ");
                // Reads the key pressed by user and returns object containg info on key pressed, including character representation of key.
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                //Prevents program from ending if Ctrl+C is pressed.
                Console.TreatControlCAsInput = true;

                

                //Handles the key . If pressed <Enter> or Esc it exits the program.
                if (keyInfo.Key == ConsoleKey.Escape || keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }

                // Parse the Keychar to string and tries to parse it into integer. If true, parsed integer is stored in key or if false then else condition runs.
                if (int.TryParse(keyInfo.KeyChar.ToString(),out int key))
                {
                    // Retrives the command from remoteKeysMap directory based on parsed key.
                    // If key exists in directory, associated command is retrived and stored in key and if false else condition runs.
                    if(remoteKeysMap.TryGetValue(key,out var command))
                    {
                        remote.SetCommand(command);
                        Console.WriteLine("\nYou pressed button {0}.", key);
                        remote.ButtonPressed();
                        //Light and thermostat status after each times going through changes.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CURRENT STATUS:\n"+ light.GetStatus() + "\n" + thermostat.GetStatus() + "\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("\nThe key doesn't exist in remote. Please input a valid key.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease input a valid integer.");
                }
                
            }
           

        }
    }
}
