using System;

namespace Module3_1
{
    class Program
    {
        static void Main()
        {
            int firstMultiplier = GetMultiplier("Enter the first multiplier.");
            int secondMultiplier = GetMultiplier("Enter the second multiplier.");
            int resultOfTheMultiplication = GetResultOfMultiplication(firstMultiplier, secondMultiplier);

            Console.WriteLine($"Искомое значение {resultOfTheMultiplication}");
            Console.ReadKey();

        }

        static int GetMultiplier(string messageToUser)
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
        static int GetResultOfMultiplication(int firstMultiplier, int secondMultiplier)
        {
            int firstNumber = Math.Abs(firstMultiplier);
            int secondNumber = Math.Abs(secondMultiplier);
            int result = 0;

            for (int i = 0; i < firstNumber; i++)
                result += secondNumber;

            if (firstMultiplier < 0 && secondMultiplier < 0)
            {
                return result;
            }

            else if (firstMultiplier < 0)
            {
                return -result;
            }
            else if (secondMultiplier < 0)
            {
                return -result;
            }
            else
            {
                return result;
            }
        }
    }
}
