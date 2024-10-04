using System;

namespace TaskNamespace
{
    public class Task3
    {
        public void Execute()
        {
            Console.WriteLine("Enter your serial number:");
            int num = Convert.ToInt32(Console.ReadLine())% 10;
            int n = 10 + num;

            int[] array = new int[n];
            Console.WriteLine("Enter " + n + " array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
                if (item < min) min = item;
                if (item > max) max = item;
            }

            Console.WriteLine("\nMin value: " + min);
            Console.WriteLine("Max value: " + max);
        }
    }
}
