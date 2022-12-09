using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch
{
    class ArrayConcept
    {
        public static void TestArray()
        {
            Console.WriteLine("Please enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Reading input from user and storing into an array");
            for (int i = 0; i < size; i++)
            {
                numbers[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Displaying array elements");
            IterateOverArray(numbers);
            Console.WriteLine("\nUpdating value of 3rd element please enter number");

            numbers[2] = Convert.ToInt32(Console.ReadLine());
            IterateOverArray(numbers);
        }

        public static void IterateOverArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
