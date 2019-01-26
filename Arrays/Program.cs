/*
    Author: Peter Millet
    Date: 01/25/2019
    Comment: A program that uses an array

 */ 
 
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the program");
            Console.ReadKey(true);
            // A message to let the user know the program will start

            try
            {
                int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                // A manually populated array

                foreach (int i in number)
                {
                    Console.WriteLine("Element = " + i + " ");
                }
                // This code will display each element in the array

                Console.WriteLine("Press any key close the program");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("An error occured please restart the program");
                Console.ReadKey(true);
                // If an error happened this message would appear
            }
        }
    }
}
