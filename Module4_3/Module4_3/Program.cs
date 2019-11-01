using System;

namespace Module4_3
{
    class Program
    {
        static void Main()
        {
            // Task A

            int firstNumberFromUser = GetNumberFromUser("Enter the first number:");
            int secondNumberFromUser = GetNumberFromUser("Enter the second number:");
            int thirdNumberFromUser = GetNumberFromUser("Enter the third number:");

            IncreaseValueByTen(ref firstNumberFromUser, ref secondNumberFromUser, ref thirdNumberFromUser);
            Console.WriteLine("Your numbers are increased by ten: \n" +
                              $"First number - {firstNumberFromUser} \n" +
                              $"Second number - {secondNumberFromUser} \n" +
                              $"Third number - {thirdNumberFromUser} \n");

            // Task B

            int circleRadius = GetNumberFromUser("Enter circle radius:");
            double circumference;
            double areaOfCircle;

            CalculateCircumference(circleRadius, out circumference);
            CalculateAreaOfCircle(circleRadius, out areaOfCircle);

            Console.WriteLine($"Circumference is {circumference} \n" +
                              $"area of the circle is {areaOfCircle} \n");

            // Task C

            int[] numbers = new int[5];
            int maxNumberInarray;
            int minNumberInarray;
            int sumAllNumbersInArray;

            RandomFillArray(numbers);
            ShowArrayNumbers(numbers, "Array is filled with such numbers:");
            CalculatingArrayValues(numbers, out maxNumberInarray, out minNumberInarray, out sumAllNumbersInArray);

            Console.WriteLine($"Maximum array element - {maxNumberInarray} \n" +
                              $"Minimum array element - {minNumberInarray} \n" +
                              $"Sum of all array elements - {sumAllNumbersInArray} \n");
            Console.ReadKey();
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

        private static void IncreaseValueByTen(ref int firstValue, ref int secondValue, ref int thirdValue, int increaseCount = 10)
        {
            firstValue += increaseCount;
            secondValue += increaseCount;
            thirdValue += increaseCount;
        }

        private static void CalculateCircumference(double radius, out double circumference)
        {
            circumference = 2 * Math.PI * radius;
        }

        private static void CalculateAreaOfCircle(double radius, out double areaOfCircle)
        {
            areaOfCircle = Math.Pow(radius, 2) * Math.PI;
        }

        private static void CalculatingArrayValues(int[] numbers, out int maxNumber, out int minNumber, out int sumAllNumber)
        {
            maxNumber = numbers[0];
            minNumber = numbers[0];
            sumAllNumber = 0;

            foreach (int currentNumber in numbers)
            {
                sumAllNumber += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                else if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
        }
    }
}
