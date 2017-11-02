using System;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] bigArray = new int[,]
                         {
                {8, 9, 7},
                {4, 7, 8},
                {4, 7, 8},
                {4, 7, 8},
                {4, 1, 5}
                         };
            int r = bigArray.Rank;
            int numDim = bigArray.Length / (r+1);

            Console.WriteLine($"Enter a number between 0 and {r}");
            int Dimension = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter another number between 0 and {numDim}");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a number to set as new value");
            int val = Convert.ToInt32(Console.ReadLine());

            bigArray[position, Dimension] = val;

            int n = 0;
            while (n < r)
            {
                // now littleArray at position 0 throgh 2 = 0
                bigArray[Dimension, n] = val;
                // now each littleArray at user's position changed to 0
                bigArray[position, n] = val;
                n++;
            }

            foreach (int d in bigArray)
            {
                
                Console.Write($"{d} ");
            }
            //Console.WriteLine();
            //Console.Write(bigArray[0, 0] + " ");
            //Console.Write(bigArray[0, 1] + " ");
            //Console.Write(bigArray[0, 2] + " \n");
            //Console.Write(bigArray[1, 0] + " ");
            //Console.Write(bigArray[1, 1] + " ");
            //Console.Write(bigArray[1, 2] + " \n");
            //Console.Write(bigArray[2, 0] + " ");
            //Console.Write(bigArray[2, 1] + " ");
            //Console.Write(bigArray[2, 2] + " ");
            Console.Read();
        }
    }
}
