using System;

namespace Lab_4
{
    class Program
    {
        
        /*
         * В-31
         * Задані натуральні числа m та n.
         * Обчислити суму m останніх цифр числа n.
         */
        
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            
            int result = 0;
            for (int i = 1; i <= m; i++)
            {
                result +=(int) (n % Math.Pow(10, i) / Math.Pow(10, i - 1));
            }
            Console.WriteLine("Result: " + result);
        }
    }
}