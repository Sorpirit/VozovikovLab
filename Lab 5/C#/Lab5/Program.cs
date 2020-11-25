using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Results:");
            
            for (int counter = 100; counter < 1000; counter++)
            {
                int sum = counter/100 + (counter / 10) % 10 + counter % 10;
                if (sum == n)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}