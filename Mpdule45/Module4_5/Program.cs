using Module4_5.Enums;
using System;

namespace Module4_5
{
    class Program
    {
        static void Main()
        {
            // Task A

            int year = ValidationOffYear("enter the year (example - 1992)");
            int month = ValidationOffMonth("enter the month number(only numbers from 1 to 12 please");
            int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

            Console.WriteLine($"In the specified month {numberOfDaysInMonth} days \n");
            Console.WriteLine("Press any key to continue.)");
            Console.ReadKey();
            Console.Clear();

            //Task B

            MathOperationEnum typeOfOperation = GetTypeOfOperation();

            int firstOperand = GetNumberFromUser("Enter first operand:");
            int secondOperand = GetNumberFromUser("Enter second operand:");
            int result = Calculate(typeOfOperation, firstOperand, secondOperand);

            Console.WriteLine($"The result of {typeOfOperation} is {result}");
            Console.ReadKey();
        }

        private static int ValidationOffYear(string message)
        {
            bool isValid;
            int year;
            do
            {
                year = GetNumberFromUser(message);
                isValid = year > 0 && year < 10000;
                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine("check the correct year (from 0001 A.D through 9999 A.D.)");
                }
            }
            while (!isValid);

            return year;
        }

        private static int ValidationOffMonth(string message)
        {
            bool isValid;
            int month;
            do
            {
                month = GetNumberFromUser(message);
                isValid = month > 0 && month < 13;
                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine("check the correct month (from 1 through 12)");
                }
            }
            while (!isValid);

            return month;
        }

        private static int GetNumberForTypeOfOperation(string message)
        {
            int number;
            bool isValid;

            do
            {
                number = GetNumberFromUser(message);
                isValid = number >= 1 && number <= 3;
                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you can enter only integers from 1 to 3");
                }

            }
            while (!isValid);

            return number;
        }

        private static int GetNumberFromUser(string messageToUser)
        {
            bool isParsedValue;
            int value;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                isParsedValue = int.TryParse(response, out value);

                if (!isParsedValue)
                {
                    Console.WriteLine("Sorry, you can enter only integers");
                }
            }
            while (!isParsedValue);

            return value;
        }

        private static MathOperationEnum GetTypeOfOperation()
        {
            MathOperationEnum result = default;

            string message = "What type of mathematical operation do you want execute?\n" +
                             "Press 1 to add.\n" +
                             "Press 2 to multiply.\n" +
                             "Press 3 to subtraction.\n" +
                             "\n" +
                             "Please enter the number: ";

            int responseNumber = GetNumberForTypeOfOperation(message);

            switch (responseNumber)
            {
                case 1:
                    {
                        result = MathOperationEnum.Addition;
                        break;
                    }
                case 2:
                    {
                        result = MathOperationEnum.Multiplication;
                        break;
                    }
                case 3:
                    {
                        result = MathOperationEnum.Subtraction;
                        break;
                    }
            }
            return result;
        }

        private static int Calculate(MathOperationEnum typeOfOperation, int firstOperand, int secondOperand)
        {
            int result = 0;
            switch (typeOfOperation)
            {
                case MathOperationEnum.Addition:
                    {
                        result = firstOperand + secondOperand;
                        break;
                    }
                case MathOperationEnum.Multiplication:
                    {
                        result = firstOperand * secondOperand;
                        break;
                    }
                case MathOperationEnum.Subtraction:
                    {
                        result = firstOperand - secondOperand;
                        break;
                    }
            }
            return result;
        }
    }
}
