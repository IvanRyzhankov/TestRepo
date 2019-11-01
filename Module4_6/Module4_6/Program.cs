using System;

namespace Module4_6
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            RandomFillArray(numbers);
            ShowArray(numbers, "Source array");
            IncreaseArray(numbers);
            ShowArray(numbers, "Array after increase");

            Console.ReadKey();
        }

        private static void IncreaseArray(int[] numbers, int increaseCount = 5)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += increaseCount;
            }
        }

        private static void ShowArray(int[] numbers, string message)
        {
            Console.Write(message);

            foreach (int currentNumber in numbers)
            {
                Console.Write($" {currentNumber}");
            }

            Console.WriteLine("\n");
        }

        private static void RandomFillArray(int[] numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
            }
        }
    }
}