using System;

namespace Module4_3
{
    class Program
    {
        static void Main()
        {
            // Task A

            (int firstNumber, int secondNumber, int thirdNumber) numbersFromUser = GetTupleOfIncreasedNumbers();
            Console.WriteLine($"Your numbers are increased by ten {numbersFromUser}");

            // Tsk B

            (int radius, double circumference, double area) = GetCircleValues();

            Console.WriteLine($"Circumference is {circumference} \n" +
                              $"Area of the circle is {area} \n" +
                              $"Radius of the circle is {radius}");

            // Task C

            int[] numbers = new int[5];
            RandomFillArray(numbers);
            (int maxArrayNumber, int minArrayNumber, int sum) = CalculateArrayValues(numbers);

            ShowArrayNumbers(numbers, "Array is filled with such numbers :");

            Console.WriteLine($"Maximum array element - {maxArrayNumber} \n" +
                              $"Minimum array element - {minArrayNumber} \n" +
                              $"Sum of all array elements - {sum} \n");
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Enter the number of the required operation: \n" +
                              "1. Increase the value of three variables by 10. \n" +
                              "2. Find the circumference and area of the circle. \n" +
                              "3. Find the minimum and maximum element of the array and sum of all elements of the array. \n");
        }

        private static int GetOperationNumberFromUser(string messageToUser)
        {
            bool numberIsValid;
            bool permissibleValue;
            int operationNumber;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out operationNumber);
                permissibleValue = operationNumber >= 1 && operationNumber <= 3;

                if (!numberIsValid || !permissibleValue)
                {
                    Console.WriteLine("Sorry, you can enter only a number from 1 to 5.");
                }
            }
            while (!numberIsValid || !permissibleValue);

            return operationNumber;
        }

        private static int GetNumberFromUser(string messageToUser)
        {
            bool numberIsValid;
            int number;

            do
            {
                Console.Write($"{messageToUser} ");
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out number);

                if (!numberIsValid)
                {
                    Console.WriteLine("Sorry, you can only enter a number");
                }
            }
            while (!numberIsValid);

            return number;
        }

        private static void RandomFillArray(int[] numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
            }
        }

        private static void ShowArrayNumbers(int[] numbers, string message)
        {
            Console.Write(message);

            foreach (int currentNumber in numbers)
            {
                Console.Write($" {currentNumber}");
            }

            Console.WriteLine("\n");
        }

        private static (int firstNumber, int secondNumber, int thirdNumber) GetTupleOfIncreasedNumbers()
        {
            int firstNumber = GetNumberFromUser("Enter the first number:");
            int secondNumber = GetNumberFromUser("Enter the second number:");
            int thirdNumber = GetNumberFromUser("Enter the third number:");

            return (IncreaseNumber(firstNumber), IncreaseNumber(secondNumber), IncreaseNumber(thirdNumber));
        }

        private static int IncreaseNumber(int target, int increaseCount = 10)
        {
            return target + increaseCount;
        }

        private static (int maxNumber, int minNumber, int sum) CalculateArrayValues(int[] numbers)
        {
            int minNumber = numbers[0];
            int maxNumber = numbers[0];
            int sum = 0;

            foreach (int currentNumber in numbers)
            {
                sum += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                else if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            return (maxNumber, minNumber, sum);
        }

        private static (int radius, double circumference, double area) GetCircleValues()
        {
            int radius = GetNumberFromUser("Enter the first number:");
            double circumference = CalculateCircumference(radius);
            double area = CalculateArea(radius);

            return (radius, circumference, area);
        }

        private static double CalculateCircumference(int radius)
        {
            return 2 * Math.PI * radius;
        }

        private static double CalculateArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
