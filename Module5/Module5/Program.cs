using System;
using System.Collections.Generic;

namespace Module5
{
    class Program
    {
        static void Main()
        {
            int userResponse;
            ShowInstructionsForGame();
            do
            {
                string[] playground = new string[100];
                List<int> trapCoordinates = new List<int>();
                int playerCoordinates = 0;
                int playerHealth = 10;
                bool isPplayerAlive = true;

                SetTraps(trapCoordinates);
                do
                {
                    Console.WriteLine($"Your health: {playerHealth};   Traps left on the field: {trapCoordinates.Count}; \n");

                    ShowPlayground(playground, playerCoordinates);
                    playerCoordinates = PlayerMove(playerCoordinates);
                    TrapCheck(trapCoordinates, playerCoordinates, ref playerHealth);

                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("Sorry but you dead. Someone else will save the princess.");
                        isPplayerAlive = false;
                    }
                }
                while (playerCoordinates != 99 && isPplayerAlive);

                if (!isPplayerAlive)
                {
                    Console.WriteLine("Do you want to become this 'someone else' and try to save the princess again? \n");
                }

                else
                {
                    Console.WriteLine("Congratulations, you won!!! Do you like this princess or will you save another? \n");
                }

                userResponse = GetResponseFromUser("Enter 1 to play again or 2 to exit the program.");
                Console.Clear();
            }

            while (userResponse == 1);
        }

        private static void ShowInstructionsForGame()
        {
            Console.WriteLine("It is you - ^, this is a princess - *. You need to save the princess. \n" +
                "Use arrows to move. May be a trap in the cell. If you fall into the trap \n" +
                "you will  take 1 to 10 damage. \n" +
                "Press any key to start playing...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void SetTraps(List<int> trapCoordinates)
        {
            int numberOfTraps = 10;

            for (int i = 0; i < numberOfTraps; i++)
            {
                trapCoordinates.Insert(i, GetRandomValue(98));
                for (int j = 0; j < trapCoordinates.Count - 1; j++)
                {
                    if (i != 0 && trapCoordinates[i] == trapCoordinates[j])
                    {
                        trapCoordinates.RemoveAt(i);
                        i -= 1;
                    }
                }
            }
        }

        private static void ShowPlayground(string[] playground, int playerCoordinates)
        {
            string princessCell = "(*)";
            string cellWithPlayer = "(^)";
            string emptyCell = "( )";
            int i = 0;

            do
            {
                playground[i] = emptyCell;
                playground[99] = princessCell;

                if (i != 1 && i % 10 == 0)
                {
                    Console.WriteLine();
                }

                if (i == playerCoordinates)
                {
                    playground[i] = cellWithPlayer;
                }

                Console.Write(playground[i]);

                i++;
            }
            while (i < playground.Length);
        }

        private static int PlayerMove(int playerCoordinates)
        {
            var playerAction = Console.ReadKey().Key;

            if (playerCoordinates == 0)
            {
                switch (playerAction)
                {
                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates == 9)
            {
                switch (playerAction)
                {
                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.LeftArrow:
                        playerCoordinates -= 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates == 90)
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates == 99)
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates > 0 && playerCoordinates < 9)
            {
                switch (playerAction)
                {
                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.LeftArrow:
                        playerCoordinates -= 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates % 10 == 9 && playerCoordinates > 9)
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.LeftArrow:
                        playerCoordinates -= 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates > 90 && playerCoordinates < 99)
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    case ConsoleKey.LeftArrow:
                        playerCoordinates -= 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else if (playerCoordinates % 10 == 0 && playerCoordinates < 90 && playerCoordinates > 0)
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }

            else
            {
                switch (playerAction)
                {
                    case ConsoleKey.UpArrow:
                        playerCoordinates -= 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        playerCoordinates += 1;
                        Console.Clear();
                        break;

                    case ConsoleKey.DownArrow:
                        playerCoordinates += 10;
                        Console.Clear();
                        break;

                    case ConsoleKey.LeftArrow:
                        playerCoordinates -= 1;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
            return playerCoordinates;
        }

        private static void TrapCheck(List<int> trapCoordinates, int playerCoordinates, ref int playerHealth)
        {
            for (int i = 0; i < trapCoordinates.Count; i++)
            {
                if (playerCoordinates == trapCoordinates[i])
                {
                    int TrapDamage = GetRandomValue(10);
                    playerHealth -= TrapDamage;
                    trapCoordinates.RemoveAt(i);
                    Console.WriteLine($"You are trapped and lost {TrapDamage} health. \n");
                }
            }
        }

        private static int GetRandomValue(int coefficient)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, coefficient);

            return value;
        }

        private static int GetResponseFromUser(string messageToUser)
        {
            bool numberIsValid;
            int number;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out number) && number == 1 || number == 2;

                if (!numberIsValid)
                {
                    Console.WriteLine("Sorry, you can enter only number 1 or 2.");
                }
            }
            while (!numberIsValid);

            return number;
        }
    }
}
