using System;

namespace OperationsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars with hardcoded values for a and b
            int a = 17;
            int b = 4;

            // vars toe store results from different math operation
            int intSum = a + b;
            int intDiff = a - b;
            int intProduct = a * b;
            int intQuotient = a / b;
            int intRemainder = a % b;


            // prints out results to CMD window
            Console.WriteLine($"17+4 is {intSum}");
            Console.WriteLine($"17-4 is {intDiff}");
            Console.WriteLine($"17*4 is {intProduct}");
            Console.WriteLine($"17/4 is {intQuotient} remainder {intRemainder}");
        }
    }
}
