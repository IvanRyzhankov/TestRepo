using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = GetAgeFromUser();
            CongratulateUser(userAge);
            Console.ReadKey();
        }
        static int GetAgeFromUser()
        {
            bool numberIsValid;
            bool numberIsPositive;
            int number;
            do
            {
                Console.WriteLine("Enter your age please:");
                string response = Console.ReadLine();
                numberIsValid = int.TryParse(response, out number);
                numberIsPositive = number > 0;
                if (!numberIsPositive)
                {
                    Console.WriteLine("Sorry, you can enter only a positive number.");
                }
            }
            while (!numberIsPositive || !numberIsValid);
            return number;
        }
        static void CongratulateUser(int userAge)
        {
            if (userAge >= 18 && userAge % 2 == 0)
            {
                Console.WriteLine("Congratulations on your eighteenth birthday!!!");
            }
            else if (userAge < 18 && userAge >= 13 && userAge % 2 != 0)
            {
                Console.WriteLine("Congratulations on your transfer to high school!!!");
            }
            else
            {
                Console.WriteLine("Sorry But your age is not in my task!!");
            }
        }
    }
}
