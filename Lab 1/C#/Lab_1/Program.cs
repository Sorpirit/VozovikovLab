using System;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * В-5
             * Дано дiйсне число M виду ссс.ddd
             * Помiняти мiсцями числову та дробову частину мiсцями
             */
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Введiть дiйсне число:");
            
            float M = float.Parse(Console.ReadLine());
            
            int intPart = (int) M;
            int pointPart = (int) (M % 1 * 1000f);
            
            float result = pointPart + intPart * 0.001f;
            
            Console.Write("Результат: " + result);
            
        }
    }
}