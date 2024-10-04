using System;
using TaskNamespace;

namespace TaskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose task (1-4) or exit (0):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Task1 task1 = new Task1();
                        task1.Execute();
                        break;

                    case 2:
                        Task2 task2 = new Task2();
                        task2.Execute();
                        break;

                    case 3:
                        Task3 task3 = new Task3();
                        task3.Execute();
                        break;

                    case 4:
                        Task4 task4 = new Task4();
                        task4.Execute();
                        break;

                    case 0:
                        running = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}
