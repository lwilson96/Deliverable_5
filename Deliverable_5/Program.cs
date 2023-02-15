/*
Author: Lee Wilson
Date: 02/14/2023
Description: A system that will collect the user's integer entry 
and populate a list of numbers equal to the user's input. 
Each of these numbers will be between 10 and 50 and will provide 
a sum of those numbers at the end
*/
using System;

namespace Deliverable_5
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i< array_len; i++)
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer between 5 and 15");
            int input = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            int[] sampleArray = random_array(input);

            try
            {
                if ((input >= 5) && (input <= 15))
                {
                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.WriteLine(element + "");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));

                }

                else
                {
                    Console.WriteLine("Please only enter an integer between 5 and 15");
                    Console.WriteLine("Please select any key to exit and try again later.");
                }

            }
            catch
            {
                Console.WriteLine("You must only enter an integer between 5 and 15.");
                Console.WriteLine("Please select any key to exit and try again later.");

            }
        }
    }
}