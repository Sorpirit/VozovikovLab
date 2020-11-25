using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int n = int.Parse(Console.ReadLine());
            
            int ricghtCounter = 1;
            int leftCounter = 1;
            Console.Write($" ({Convert.ToString(n, 2)})\n");
            while (n >> leftCounter > 0)
            {
                leftCounter ++;
            }
            
            int result = 0;
            
            while (leftCounter > 0)
            {
                if ((n & 1 << (leftCounter - 1)) > 0)
                {
                    result += 1<<(ricghtCounter - 1);
                    
                }

                ricghtCounter ++;
                leftCounter --;

            }
            Console.WriteLine("n = " + result + $"(00{Convert.ToString(result, 2)})");
        }
    }
}
