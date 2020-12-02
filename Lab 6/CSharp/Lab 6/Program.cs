using System;
using System.Linq;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 nums and separate them using spaces: ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

             if (arr.Length != 3)
             {
                 Console.WriteLine("You should input 3 arguments.");
                 return;
             }
            
             int result = Nod(arr[0], arr[1], arr[2]);
             Console.WriteLine("Result: " + result);
        }
        
        private static int Nod(int a, int b, int c)
        {
            return Nod(Nod(a, b), c);
        }
        private static int Nod(int a, int b)
        {
            int mod = a % b;
            if (mod == 0)
                return b;

            return Nod(b, mod);
        }
    }
}