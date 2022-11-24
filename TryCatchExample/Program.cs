using System;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());
                var result = drinks / shelves;
                Console.WriteLine(result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("At least 1 shelf");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}
