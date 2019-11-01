using System;
using System.Linq;

namespace Module4_1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[6];

            RandomFillArray(numbers);

            Console.WriteLine("The array was filled with random numbers");

            ShowArrayNumbers(numbers);
            ShowMaximumElementInArray(numbers);
            ShowMinimumElementInArray(numbers);
            ShowSumOfAllArrayElements(numbers);
            ShowDifferenceBetweenMaximumAndMinimumElement(numbers);
            ChangingArrayElements(numbers);

            Console.ReadKey();
        }


        private static void RandomFillArray(int[] numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 15);
            }
        }

        private static void ShowArrayNumbers(int[] numbers)
        {
            Console.Write("The array consists of these numbers: \n");

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                Console.Write($" {currentNumber}");
            }
            Console.WriteLine("\n");
        }



        private static void ShowMaximumElementInArray(int[] numbers)
        {

            /* int maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
            if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            } */

            int maxNumber = numbers.Max();
            Console.WriteLine($"The maximum element in the array is {maxNumber}");
        }

        private static void ShowMinimumElementInArray(int[] numbers)
        {
            /* int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
            if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            } */

            int minNumber = numbers.Min();
            Console.WriteLine($"The minimum element in the array is {minNumber}");
        }

        private static void ShowSumOfAllArrayElements(int[] numbers)
        {
            /* int sumOfNumbers = 0;
            for (int i = 0; i < numbers.Length; i++) {

            sumOfNumbers += numbers[i]; 
            }*/

            int sumOfNumbers = numbers.Sum();
            Console.WriteLine($"The sum of all elements of the array is {sumOfNumbers}");
        }

        private static void ShowDifferenceBetweenMaximumAndMinimumElement(int[] numbers)
        {
            int maxNumber = numbers[0];
            int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                else if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            int differenceBetweenValues = maxNumber - minNumber;
            Console.WriteLine($"The difference between the maximum and minimum element { differenceBetweenValues}");
        }

        private static void ChangingArrayElements(int[] numbers)
        {
            int maxNumber = numbers[0];
            int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                else if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] += maxNumber;
                }
                else if (numbers[i] % 2 != 0)
                {
                    numbers[i] -= minNumber;
                }
            }
            Console.Write("New array after conversions: ");
            ShowArrayNumbers(numbers);
        }
    }
}

