using System;

namespace SimulationTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleIO consoleIO = new ConsoleIO();
            Console.WriteLine(DisplayInputIntruction());
            string programInput = "";

            bool isValidInput = false;
            bool isValidPosition = false;
            while (!isValidInput || !isValidPosition)
            {
                programInput = consoleIO.ReadInput();
                isValidInput = Validator.IsValidInput(programInput);
                isValidPosition = Validator.IsValidPosition(programInput);
                if (!isValidInput)
                {
                    Console.WriteLine("Please ensure you enter a valid command. Positive whole number 0-9 separated by commas not more than 4 numbers");
                }
                if (!isValidPosition)
                {
                    Console.WriteLine("The entered position is out of the table. Ensure the position is not greater than the table size.");
                }
            }
            Table table = new Table(programInput);
            Console.WriteLine(DisplayCommandIntruction());

            bool isValidCommand = false;
            string commands = "";
            while (!isValidCommand)
            {
                commands = Console.ReadLine();
                isValidCommand = Validator.IsValidCommand(commands);
                if (!isValidCommand)
                {
                    Console.WriteLine("Please ensure you enter a valid command. Positive whole number 0-4 separated by commans ");
                }
            }
            


            Console.WriteLine("");

            Console.WriteLine(table.Simulate(commands));
        }
        public static string DisplayCommandIntruction()
        {
            return "0 = quit simulation and print results to stdout \n" +
                "1 = move forward one step \n" +
                "2 = move backwards one step \n" +
                "3 = rotate clockwise 90 degrees (eg north to east) \n" +
                "4 = rotate counterclockwise 90 degrees (eg west to south) \n" +
                "Please enter commands in single string separated by commans \n" +
                "";
        }

        public static string DisplayInputIntruction()
        {
            return "Please enter the table size as two integers [width, height] followed by the objects starting position as two integers [x, y] Example 4,4,2,2";
        }
    }
}
