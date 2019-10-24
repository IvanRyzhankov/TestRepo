using System;

namespace Module3_5
{
    class Program
    {
        static void Main()
        {
            int valueFromUser = GetNumberFromUser();
            char characterToDelete = GetCharacterToDelete();
            string result = DeleteCharacter(valueFromUser, characterToDelete);
            Console.WriteLine($"Result {result}");
            Console.ReadKey();

        }

        static int GetNumberFromUser()
        {
            bool valueIsValid;
            int number;

            do
            {
                Console.WriteLine("Enter the number");
                string valueFromUser = Console.ReadLine();
                valueIsValid = int.TryParse(valueFromUser, out number);

                if (!valueIsValid)
                {
                    Console.WriteLine("Sorry, you can enter only a positive number.");
                }
            }
            while (!valueIsValid);

            return number;
        }

        static char GetCharacterToDelete()
        {
            bool valueIsValid;
            char charFromUser; ;

            do
            {
                Console.WriteLine("Enter number to delete");
                string response = Console.ReadLine();
                valueIsValid = char.TryParse(response, out charFromUser);

                if (!valueIsValid)
                {
                    Console.WriteLine("Sorry, you can enter only a symbol.");
                }
            }
            while (!valueIsValid);

            return charFromUser;
        }

        static string DeleteCharacter(int numberFromUser, char characterToDelete)
        {
            string result = string.Empty;
            string valueFromUser = numberFromUser.ToString();

            for (int i = 0; i < valueFromUser.Length; i++)
            {
                if (valueFromUser[i] != characterToDelete)
                {
                    result += valueFromUser[i];
                }
            }

            return result;
        }

    }

}
