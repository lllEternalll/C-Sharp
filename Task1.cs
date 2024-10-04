using System;

namespace TaskNamespace
{
    public class Task1
    {
        public void Execute()
        {
            Console.WriteLine("Enter your serial number:");
            int num = Convert.ToInt32(Console.ReadLine()) % 10;

            int min = 1;
            int max = 10 + num;

            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers that belong to the interval [" + min + "," + max + "]:");
            if (IsInRange(a, min, max)) Console.WriteLine(a);
            if (IsInRange(b, min, max)) Console.WriteLine(b);
            if (IsInRange(c, min, max)) Console.WriteLine(c);
        }

        private bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}
