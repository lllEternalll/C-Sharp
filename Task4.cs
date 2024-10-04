using System;

namespace TaskNamespace
{
    public class Task4
    {
        public void Execute()
        {
            Console.WriteLine("Enter your serial number:");
            int num = Convert.ToInt32(Console.ReadLine()) % 10;
            int n = 10 + num;

            int[] array = new int[n];
            Console.WriteLine("Enter " + n + " array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter M number:");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("M: " + M);
            Console.WriteLine("Array:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nArray Y (elements of X whose modulus is greater than M):");

            foreach (var item in array)
            {
                if (Math.Abs(item) > M)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
