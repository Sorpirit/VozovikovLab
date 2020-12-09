using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] inputArr = GenerateRandomMassive(10,0,100);
            
            Console.WriteLine("Input array: ");
            foreach (var i in inputArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            int result = CountMaxMinDifference(inputArr);
            
            Console.WriteLine("Max Min difference: " + result);
            Console.WriteLine("Switched array: ");
            
            foreach (var i in inputArr)
            {
                Console.Write(i + " ");
            }
        }

        private static int CountMaxMinDifference(int[] arr)
        {
            int minNumIndex = 0;
            int maxNumIndex = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxNumIndex])
                    maxNumIndex = i;
                else if (arr[i] < arr[minNumIndex])
                    minNumIndex = i;
            }

            int difference = arr[maxNumIndex] - arr[minNumIndex];

            arr[minNumIndex] += difference;
            arr[maxNumIndex] += -difference;

            return difference;
        }
        
        private static int[] GenerateRandomMassive(int size, int minValue, int maxValue)
        {
            int[] result = new int[size];
            Random rand = new Random();
            
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rand.Next(minValue, maxValue);
            }

            return result;
        }
    }
}