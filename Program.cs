using System;

namespace Homework
{
    class Program
    {
        // good stuff
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int arrSize = 3; // TODO update to get user input

            int[,] numbers = new int[,] {  // generate actual random numbers and length
                { 4, 2, 1, 7 },
                { 5, 6, 0, 3 },
                { 7, 1, 8, 5 }
            };

            // sorting
            sortArrayDesc(numbers);
            // { 7, 4, 2, 1 }, 
            // { 6, 5, 3, 0 }, 
            // { 8, 7, 5, 1 }  

            // printAvgForEachArray(numbers)
            float[] avg = new float[arrSize];
            avg[0] = 4.2f;
            avg[1] = 3.2f;
            avg[2] = 3.8f;

            
            // swap elements
            float f = avg[0];
            avg[0] = avg[2];
            avg[2] = f;


            


        }

        private static void sortArrayDesc(int[,] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int tmp = numbers[i, 0];
                Console.WriteLine($"tmp: {tmp}");
            }
        }
    }
}
