﻿using System;

namespace Reverse
{
	public class Reverse
	{
		public static void Main(string[] args)
		{
			string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            // Try to solve this using ElementAt() first, and optionally anything else after.


			

            Console.WriteLine(StringReverser(reversed));
		}

        private static string StringReverser(string input)
        {
            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            return reverse;

        }
    }
}