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
                {6, 5, 4},
                {3, 2, 1}

             };
            //Console.WriteLine(bigArray.Rank);
            Console.WriteLine("Enter another number between 0 and 2");
            int littleArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number between 0 and 2");
            int position = Convert.ToInt32(Console.ReadLine());
            bigArray[littleArray, position] = 0;
            int r = bigArray.Rank + 1;
            int n = 0;
            while (n < r)
            {
                // now littleArray at position 0 throgh 2 = 0
                bigArray[littleArray, n] = 0;
                // now each littleArray at user's position changed to 0
                bigArray[n, position] = 0;
                n++;
            }
            int dimensions = bigArray.Length / bigArray.Rank;
            int c = 0;
            foreach (int d in bigArray)
            {
                Console.Write($"{d} ");
                c++;
                if (c % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.Read();


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //int[,] bigArray = new int[,]
            // {
            //    {8, 9, 7, 13},
            //    {5, 7, 21, 34},
            //    {4, 3, 8, 18},
            //    {12, 3, 86, 9},
            //    {4, 1, 29, 17}
            // };
            //int numDims = /*bigArray.Rank*/ 5;
            //int dimWidth = bigArray.Length / (numDims);

            //Console.WriteLine($"Enter a number between 0 and {numDims}");
            //int dimension = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Enter another number between 0 and {dimWidth}");
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Pick a number to set as new value");
            //int val = Convert.ToInt32(Console.ReadLine());

            //bigArray[dimension, position] = val;

            //int n = 0;
            //while (n < (numDims))
            //{
            //    // now littleArray at position 0 throgh end = val
            //    bigArray[dimension, n] = val;
            //    // now each littleArray at user's position changed to val
            //    bigArray[n, position] = val;
            //    n++;
            //}
            //int c = 0;
            //foreach (int d in bigArray)
            //{
            //    Console.Write($"{d} ");
            //    c++;
            //    if(c % 3 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            ////Console.WriteLine();
            ////Console.Write(bigArray[0, 0] + " ");
            ////Console.Write(bigArray[0, 1] + " ");
            ////Console.Write(bigArray[0, 2] + " \n");
            ////Console.Write(bigArray[1, 0] + " ");
            ////Console.Write(bigArray[1, 1] + " ");
            ////Console.Write(bigArray[1, 2] + " \n");
            ////Console.Write(bigArray[2, 0] + " ");
            ////Console.Write(bigArray[2, 1] + " ");
            ////Console.Write(bigArray[2, 2] + " ");
            //Console.Read();
        }
    }
}
