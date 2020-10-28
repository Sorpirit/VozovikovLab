using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            float y = float.Parse(Console.ReadLine());

            bool result = false;
            
            if (!(x < 0 && y > 0))
            {
                if (Math.Abs(x) <= 3 && Math.Abs(y) <= 3)
                {
                    float outCircle = x * x + y * y;
                    result = outCircle >= 9;
                }
            }
                
            if(result)
                Console.WriteLine("Area contains point.");
            else
                Console.WriteLine("Area does not contain point.");
        }
    }
}