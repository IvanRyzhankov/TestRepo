using System;

namespace Modele4_2
{
    class Program
    {
        static void Main()
        {
            //Task A
            int firstValue = Convert.ToInt32(GetNumberFromUser("Enter the first integer"));
            int secondValue = Convert.ToInt32(GetNumberFromUser("Enter the second integer"));
            int thirdValue = Convert.ToInt32(GetNumberFromUser("Enter the third integer"));
            int sum = GetSum(firstValue, secondValue, thirdValue);
            Console.WriteLine($"Result: {sum}");

            //Task B

            firstValue = Convert.ToInt32(GetNumberFromUser("Enter the first integer"));
            secondValue = Convert.ToInt32(GetNumberFromUser("Enter the second integer"));
            sum = GetSum(firstValue, secondValue);
            Console.WriteLine($"Result: {sum}");

            //Task C

            double firstFractionalValue = GetNumberFromUser("Enter the first fractional value ");
            double secondFractionalValue = GetNumberFromUser("Enter the second fractional value ");
            double result = GetSum(firstFractionalValue, secondFractionalValue);
            Console.WriteLine($"Result: {result}");

            // task D

            string firstStringFromUser = GetStringFromUser("Fill in the first string");
            string secondStringFromUser = GetStringFromUser("Fill in the second string");
            string concatedString = GetSum(firstStringFromUser, secondStringFromUser);
            Console.WriteLine($"Result: {concatedString}");

            // Task E

            int lengthOfFirstArray = Convert.ToInt32(GetNumberFromUser("Enter the length of the first array"));
            int lengthOfSecondArray = Convert.ToInt32(GetNumberFromUser("Enter the length of the second array"));

            int[] firstArray = new int[lengthOfFirstArray];
            int[] secondArray = new int[lengthOfSecondArray];



            RandomFillArray(firstArray);
            RandomFillArray(secondArray);

            Console.WriteLine("Arrays were filled automatically \n");

            ShowArrayNumbers(firstArray, "The first array is filled with such numbers :");
            ShowArrayNumbers(secondArray, "The first array is filled with such numbers :");

            var resultArray = GetSum(firstArray, secondArray);

            ShowArrayNumbers(resultArray, "The Third array is filled with such numbers: ");

            Console.ReadKey();
        }

        private static string GetStringFromUser(string messageToUser)
        {
            bool isNullOrEmpty;
            string stringFromUser;

            do
            {
                Console.WriteLine(messageToUser);
                stringFromUser = Console.ReadLine();
                isNullOrEmpty = !string.IsNullOrWhiteSpace(stringFromUser);

                if (!isNullOrEmpty)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, enter at least something.");
                }

            }
            while (!isNullOrEmpty);

            return stringFromUser;
        }

        private static double GetNumberFromUser(string messageToUser)
        {
            bool isNumberValid;
            double number;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                isNumberValid = double.TryParse(response, out number);

                if (!isNumberValid)
                {
                    Console.WriteLine("Sorry, you can only enter a number");
                }
            }
            while (!isNumberValid);

            return number;
        }

        private static int GetSum(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        private static int GetSum(int firstValue, int secondValue, int thirdValue)
        {
            return GetSum(firstValue, secondValue) + thirdValue;
        }

        private static double GetSum(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        private static string GetSum(string firstStringFromUser, string secondStringFromUser)
        {
            return string.Concat(firstStringFromUser, secondStringFromUser);
        }

        private static int[] GetSum(int[] firstArray, int[] secondArray)
        {
            int targetLength = firstArray.Length >= secondArray.Length ? firstArray.Length : secondArray.Length;
            int[] resultArray = new int[targetLength];

            if (targetLength == firstArray.Length)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstArray[i];
                }
                for (int i = 0; i < secondArray.Length; i++)
                {
                    resultArray[i] += secondArray[i];
                }
            }
            else
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = secondArray[i];
                }
                for (int i = 0; i < firstArray.Length; i++)
                {
                    resultArray[i] += firstArray[i];
                }
            }

            return resultArray;
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
                Console.Write($" {currentNumber}");

            Console.WriteLine("\n");
        }
    }
}
