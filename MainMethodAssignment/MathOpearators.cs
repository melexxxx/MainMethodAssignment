using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // Defines a class to perform various mathematical operations
    class MathOpearators
    {
        // Method 1: Adds two integers and returns the result
        public static int exampleMethod(int inputOne, int inputTwo)
        {
            return inputOne + inputTwo;
        }

        // Method 2: Subtracts two decimals and returns the result 
        public static decimal exampleMethod(decimal inputOne, decimal inputTwo)
        {
            return inputOne - inputTwo;
        }

        // Method 3: Attempts to convert two strings to integers. 
        // If successful, multiplies them and returns the result as a string. 
        // If not, returns an error message.
        public static string exampleMethod(string inputOne, string inputTwo)
        {
            if (int.TryParse(inputOne, out int num1) && int.TryParse(inputTwo, out int num2))
            {
                int result = num1 * num2;
                return result.ToString();
            }
            else
            {
                return "Invalid input: Strings could not be converted to integers";
            }
        }
    }
}
