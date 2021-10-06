using System;

namespace Loops___Oddsum_Updated_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            Console.WriteLine("Enter a NUMBER!!");
            if (Int32.TryParse(Console.ReadLine(), out input))
            {
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(Convert.ToString(i));
                }



            }
            else
            {
                Console.WriteLine("That's not a number.");
            }

            Console.ReadLine();
        }
    }
}
