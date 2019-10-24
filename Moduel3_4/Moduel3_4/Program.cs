using System;

namespace Moduel3_4
{
    class Program
    {
        static void Main()
        {
            int numberFromUser = GetNumberFromUser("Enter the number:");
            int reversedNumber = ReversNumbers(numberFromUser);
            Console.WriteLine($"Number in reverse order {reversedNumber}");
            Console.ReadKey();
        }

        static int ReversNumbers(int numberFromUser)
        {
            string stringInReverse = string.Empty;
            string stringFromUser = numberFromUser.ToString();

            for (int i = stringFromUser.Length - 1; i >= 0; i--)
            {
                stringInReverse += stringFromUser[i];
            }

            return int.Parse(stringInReverse);
        }

        static int GetNumberFromUser(string messageToUser)
        {
            bool numberIsValid;
            int number;

            do
            {
                Console.WriteLine(messageToUser);
                string stringFromUser = Console.ReadLine();
                numberIsValid = int.TryParse(stringFromUser, out number);

                if (!numberIsValid)
                {
                    Console.WriteLine("Sorry, you can enter only a number.");
                }
            }
            while (!numberIsValid);

            return number;
        }
    }
}
