using System;

namespace CalculatorApp
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Calculator");

        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
           return x * y; 
        }
        public static double Divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch(DivideByZeroException)
            {
                return 0; 
            }
        }
        public static double Modulus(double x, double y)
        {
            return x % y;
        }
    }
}
