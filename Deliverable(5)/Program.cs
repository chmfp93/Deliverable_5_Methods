/* Author: Carlos M. Figueroa Palomino
   Date: 2/15/2023
   Description: C# console application that populates a random array of elements within 10-50 with a lenght of user's input
                between 5-15. Then, it sums all the elements in the array and returns the value.
*/

using System;

namespace Deliverable_5_
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
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
            Console.WriteLine("Enter an integer between 5 and 15");
            
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] sampleArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                else
                {
                    Console.WriteLine("Please enter an integer number between 5 and 15");
                }     
            }

            catch
            {
                Console.WriteLine("Please enter an integer number between 5 and 15");
            }
        }
    }
}