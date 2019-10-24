using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            int rowLength = GetRowLength();
            FibonacciSeries(rowLength);
            Console.ReadKey();
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

        static int GetRowLength()
        {
            bool numberIsPositive;
            int rowLength;

            do
            {
                string message = "Enter the length of the Fibonacci series";
                rowLength = GetNumberFromUser(message);
                numberIsPositive = rowLength > 0;

                if (!numberIsPositive)
                {
                    Console.WriteLine("Sorry, you can enter only a positive number.");
                }
            }
            while (!numberIsPositive);

            return rowLength;
        }

        static void FibonacciSeries(int rowLength)
        {
            int firstFibonacciArg = 0;
            int secondFibonacciArg = 1;

            Console.Write($"Fibonacci series {firstFibonacciArg}");

            for (int i = 0; i < rowLength; i++)
            {
                firstFibonacciArg += secondFibonacciArg;
                firstFibonacciArg = firstFibonacciArg + secondFibonacciArg;
                secondFibonacciArg = firstFibonacciArg - secondFibonacciArg;
                firstFibonacciArg = firstFibonacciArg - secondFibonacciArg;

                Console.Write($" {firstFibonacciArg}");
            }
        }
    }
}
