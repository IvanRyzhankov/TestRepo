using System;

namespace Moduel3_6
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[4];

            FillArray(numbers);
            ShowArrayNumbers(numbers);

            Console.WriteLine("\n");

            ShowNumbersLargerThanPrevious(numbers);

            Console.ReadLine();
        }

        static void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int indexToUser = i + 1;
                string message = $"Enter value into {indexToUser} ceil";

                numbers[i] = GetNumberFromUser(message);
            }
        }

        static void ShowArrayNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                Console.Write($" {currentNumber} ");
            }
        }

        static int GetNumberFromUser(string messageToUser)
        {
            bool numberIsValid;
            int number;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out number);

                if (!numberIsValid)
                {
                    Console.WriteLine("Sorry, you can enter only a number.");
                }
            }
            while (!numberIsValid);

            return number;
        }

        static void ShowNumbersLargerThanPrevious(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * -1;
            }
        }
    }
}
