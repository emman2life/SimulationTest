using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimulationTest
{
    public static class Validator
    {
        public static bool IsValidCommand(String strNumber)
        {
            string pattern = @"^[0-4](,[0-4]{1})*,0$";
            Match match = Regex.Match(strNumber, pattern);

            return match.Success;
        }
        public static bool IsValidInput(String strNumber)
        {


            string pattern = @"^[0-9]+,[0-9]+,[0-9]+,[0-9]+$";
            Match match = Regex.Match(strNumber, pattern);


            return match.Success;
        }
        public static bool IsValidPosition(String input)
        {

            bool isValid = false;
            if (IsValidInput(input))
            {
                isValid = true;
                int[] numsArray = Array.ConvertAll(input.Split(','), int.Parse);
                if (numsArray[0] <= numsArray[2] || numsArray[0] <= numsArray[3])
                {
                    isValid = false;
                }
            }
            

            return isValid;
        }
    }
}
