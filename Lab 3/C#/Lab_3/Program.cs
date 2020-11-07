using System;

namespace Lab_3
{
    class Program
    {
        /*
         * В-31
         * Задане дійсне число x. 
         * Обчислити натуральний логарифм: (ln(x+1))/x , розкладеный за рядом Меркатора.
         */
        
        
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            
            double e = 0.000001f;
            int nCounter = 2;
            double prevResult = 0;
            double result = 1;

            while (Math.Abs(result - prevResult) > e)
            {
                prevResult = result;
                
                result += Math.Pow(-1,nCounter + 1) * Math.Pow(x,nCounter - 1)/nCounter;
                
                nCounter++;
            }
            
            Console.WriteLine("Result: " + result);
        }
    }
}