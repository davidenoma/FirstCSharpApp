using System;

namespace MyCalculator
{
    class Program
    {
        private const double _MIN_VALUE_Double = -1000;
        private const double _MAX_VALUE_Double = 1000;  
        static void Main(string[] args)
        {
            double firstDouble = 0;
            double secondDouble = 0;
            double totalDouble = 0;
            bool OKBool      = true;
            Console.WriteLine("My Calculator");
            
            Console.WriteLine("Enter first Number");

            firstDouble =   double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            secondDouble = double.Parse(Console.ReadLine());
            totalDouble = firstDouble  + secondDouble;
            Console.WriteLine("\n{0} + {1} = {2}", firstDouble, secondDouble, totalDouble);
            Console.Write("press enter to exit");
            Console.ReadLine();
        }
    }
}
