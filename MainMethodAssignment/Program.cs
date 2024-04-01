using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer Calculation
            int intResult = MathOpearators.exampleMethod(1, 2);
            Console.WriteLine("the int result is: " + intResult);
            Console.WriteLine("Press enter");
            Console.ReadLine();

            // Decimal Calculation
            decimal decimalResult = MathOpearators.exampleMethod(1.33m, 1.32m);
            Console.WriteLine("The decimal result is: " + decimalResult);
            Console.WriteLine("Press enter");
            Console.ReadLine();

            // String Calculation
            string stringDecimalResult = MathOpearators.exampleMethod("4", "8");
            Console.WriteLine("The string result in: " + stringDecimalResult);
            Console.ReadLine();
        }
    }

}
