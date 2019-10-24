using System;

namespace Module3_2
{
    class Program
    {
        static void Main()
        {
            int naturalNumberFromUser = GetNumber();
            int amountOfNaturalEvenNumbers = GetAmountOfNaturalEvenNumbers();

            calculateAListOfNaturalNumbers(naturalNumberFromUser, amountOfNaturalEvenNumbers);
            Console.ReadKey();
        }

        static int GetNaturalNumberFromUser(string messageToUser)
        {
            bool numberIsValid;
            bool numberIsPositive;
            int naturalNumber;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out naturalNumber);
                numberIsPositive = naturalNumber > 0;
                if (!numberIsPositive)
                {
                    Console.WriteLine("Sorry, you can enter only a positive number.");
                }
            }

            while (!numberIsPositive || !numberIsValid);

            return naturalNumber;
        }

        static int GetNumber()
        {
            string message = "Enter a positive number:";
            int naturalNumber = GetNaturalNumberFromUser(message);

            return naturalNumber;
        }


        static int GetAmountOfNaturalEvenNumbers()
        {
            string message = "Enter amount of natural even numbers";
            int amountNaturalNumber = GetNaturalNumberFromUser(message);

            return amountNaturalNumber;
        }

        static void calculateAListOfNaturalNumbers(int naturalNumberFromUser, int amountOfNaturalEvenNumbers)
        {
            Console.Write("list of natural even numbers ");

            for (int i = naturalNumberFromUser - 1; i > 0; i--)
            {
                if (i % 2 == 0 && 0 < amountOfNaturalEvenNumbers)
                {
                    Console.Write($" {i}");
                }
            }
        }
    }
}
