using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module4_7.Enums;

namespace Module4_7
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            RandomFillArray(numbers);

            Console.WriteLine("Arrays were filled automatically \n");

            ShowArrayNumbers(numbers, "This array is filled with such numbers:");

            Console.ReadKey();
        }

        static void RandomFillArray(int[] numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
            }
        }

        static void ShowArrayNumbers(int[] numbers, string message)
        {
            Console.Write(message);

            foreach (int currentNumber in numbers)
            {
              Console.Write($" {currentNumber}");
            }

            Console.WriteLine("\n");
        }

        private static int[] SortArray(int[] array, SortOrder order)
        {
          return order == SortOrder.Asc ? AscendingSort(array) : DescendingSort(array);
        }

        private static int[] AscendingSort(int[] array)
        {
          return null;
        }

        private static int[] DescendingSort(int[] array)
        {
          return null;
        }
    }
}
