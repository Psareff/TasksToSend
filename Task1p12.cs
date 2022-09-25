using System;
namespace Task1p12
{
    enum operation { add, substract, multiply, divide, power, squareroot }
    class Task1p12
    {
        public static double doOperation(operation op, double a, double b) => op switch
        {
            operation.add => a + b,
            operation.substract => a - b,
            operation.multiply => a * b,
            operation.divide => (b == 0 ? throw new DivideByZeroException() : a/b),
            operation.power => Convert.ToDouble(Math.Pow(a, b)),
            _ => 0
        };
        public static double doOperation(operation op, double a)
        {
            return (a < 0 ? throw new Exception("Square root of a negative number") : Math.Sqrt(a));
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine(doOperation(operation.squareroot, -5));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
