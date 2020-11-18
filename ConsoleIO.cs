using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimulationTest
{
    class ConsoleIO : IInputOutput
    {

        public string ReadCommand()
        {
            string command = Console.ReadLine();
            return command;
        }

        public string ReadInput()
        {
            string input = Console.ReadLine();
            
            return input;
        }
     
    }
}
