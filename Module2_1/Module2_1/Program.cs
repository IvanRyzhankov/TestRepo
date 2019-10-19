using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double numberOfTaxPayers = GetNumberOfTaxPayers();
                double taxPercentage = GetTax();
                double countOfCustomers = 500;
                double calculatedTax = CalculateTax(numberOfTaxPayers, taxPercentage, countOfCustomers);
                Console.WriteLine($"Tax amount {calculatedTax}");
                Console.ReadKey();
            }

            double GetNumberFromUser(string messageToUser)
            {
                bool numberIsValid;
                bool numberIsPositive;
                double number;

                do
                {
                    Console.WriteLine(messageToUser);
                    string response = Console.ReadLine();
                    numberIsValid = double.TryParse(response, out number);
                    numberIsPositive = number > 0;
                    if (!numberIsPositive)
                    {
                        Console.WriteLine("Sorry, you can enter only a positive number.");
                    }
                }
                while (!numberIsPositive || !numberIsValid);

                return number;
            }

            double GetNumberOfTaxPayers()
            {
                string message = "Enter number of taxpayers:";
                double countOfTaxPayers = GetNumberFromUser(message);

                return countOfTaxPayers;
            }

            double GetTax()
            {
                string message = "Enter tax percentage:";
                double taxPercentage = GetNumberFromUser(message);

                return taxPercentage;
            }
            double CalculateTax(double countOfTaxPayers, double taxPercentage, double countOfCustomers)
            {
                return countOfTaxPayers * countOfCustomers / 100 * taxPercentage;
            }
        }
    }
}

