using System;

namespace Module3_8
{
    class Program
    {
        static void Main()
        {
            double startOfLine = -2;
            double endOfLine = 7;
            double epsilon = 0.001;
            double x = (endOfLine + startOfLine) / 2;

            while (Math.Abs(F(x)) > epsilon)
            {
                if (F(x) > 0)
                    endOfLine = x;
                else
                    startOfLine = x;
                x = (startOfLine + endOfLine) / 2;
            }

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"F(x) = {F(x)}\n");
            Console.WriteLine("Press any key\n");
            Console.ReadKey();

            // Second part of the task. Array in spiral.

            int size = 4;
            int[,] testArray = new int[size, size];

            FillArrayInSpiral(testArray);
            ShowArrayNumbers(testArray);

            Console.ReadKey();
        }


        static double F(double x)
        {
            return Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 12 * x - 8;
        }

        static void FillArrayInSpiral(int[,] numbers)
        {
            const int dimension = 0;

            int startNumber = 1;
            int size = numbers.GetUpperBound(dimension) + 1;

            for (int i = size - 1, j = 0; i >= 0; i--, j++)
            {
                for (int k = j; k < i; k++)
                    numbers[j, k] = startNumber++;
                for (int k = j; k < i; k++)
                    numbers[k, i] = startNumber++;
                for (int k = i; k > j; k--)
                    numbers[i, k] = startNumber++;
                for (int k = i; k > j; k--)
                    numbers[k, j] = startNumber++;
            }
        }


        static void ShowArrayNumbers(int[,] array)
        {
            const int dimension = 0;

            int rows = array.GetUpperBound(dimension) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int currentNumber = array[i, j];
                    Console.Write($"{currentNumber} ");
                }

                Console.WriteLine();
            }
        }
    }
}