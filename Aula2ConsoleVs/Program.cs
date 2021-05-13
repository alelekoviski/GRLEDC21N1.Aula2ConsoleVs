using System;

namespace Aula2ConsoleVs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started!");

            Console.Write("Enter a number: ");

            var numberText : string = Console.ReadLine();

            var parseDidntWork : bool = !Int32.TryParse(numberText, out var number :int);

            if (parseDidntWork)
            {
                Console.WriteLine("NaN!");
                Console.ReadKey();
                return;

            }
            if (number == 1)
            {
                Console.WriteLine("Number is one!");

            }
            else
            {
                Console.WriteLine("Not one!");
            }
            Console.ReadKey();
        }
    }
}
