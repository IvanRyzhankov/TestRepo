using System;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            double a = 0;
            double b = 0;
            bool isParsedA = false;
            bool isParsedB = false;
            do
            {
                Console.Write("Enter the first value to swap:");

                string firstMessage = Console.ReadLine();
                if (!String.IsNullOrEmpty(firstMessage))
                {
                    isParsedA = double.TryParse(firstMessage.Replace('.', ','), out a);
                }

                Console.Write("Enter the second value to swap:");

                string secondMess = Console.ReadLine();
                if (!String.IsNullOrEmpty(firstMessage))
                {
                    isParsedB = double.TryParse(secondMess.Replace('.', ','), out b);
                }
                if (isParsedA && isParsedB)
                {
                    isValid = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("First or second value is not valid. Please, enter only numbers");
                }
            } while (!isValid);

            Variable variable = new Variable(a, b);
            variable.SwapValues();
            Console.WriteLine($"The values were swapped. The first value - {variable.VariableA}. The second variable - {variable.VariableB}");
            Console.ReadLine();
        }

    }
}