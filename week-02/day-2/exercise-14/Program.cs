﻿using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] ag = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < ag.GetLength(0); i++)
            {
                ag[i] *= 2;
            }

            foreach (int item in ag)
            {
                Console.WriteLine(item);
            }

        }
    }
}