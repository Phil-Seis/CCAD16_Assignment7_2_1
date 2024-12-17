using System;
using System.Linq;

namespace CCAD16_Assignment7_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of your choice using numbers followed by a space between each:");
            string userInput = Console.ReadLine();
            string[] userArray = userInput.Split(' ');
            int[] inputArray = userArray.Select(int.Parse).ToArray();

            //Display original array
            Console.WriteLine($"Your original array is: [{string.Join(", ", inputArray)}]");

            //Calling the Sort method
            Sort(inputArray);

            //Display new sorted array
            Console.WriteLine($"Your sorted array is: [{string.Join(", ", inputArray)}]");
        }

        static void Sort(int[] a)
        {        

            // Start with half the array size, reduce by half each time
            for (int h = a.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < a.Length; i++)  //Iterate over elements starting from 'h'
                {                    
                    int j = i;
                    int ai = a[i];
                    
                    while (j >= h && a[j - h] > ai)
                    {
                        a[j] = a[j - h];
                        j -= h;  //Reduce index by h
                    }

                    a[j] = ai; //Place the temp value in its correct position
                }
            }
        }
    }
}
