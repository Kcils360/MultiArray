using System;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] BigArray = new int[,]
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };

            Console.WriteLine($"Enter number from 0 to {BigArray.Length}");


            Console.ReadKey();
        }
    }
}
