using System;

namespace Module4_8
{
    class Program
    {
        static void Main()
        {
            double startOfLine = -2;
            double endOfLine = 7;
            double epsilon = 0.001;
            double x = GetX(startOfLine, endOfLine, epsilon);

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"F(x) = {GetF(x)}\n");
            Console.WriteLine("Press any key\n");
            Console.ReadKey();
        }

        private static double GetX(double startOfLine, double endOfLine, double epsilon)
        {
            double x = (endOfLine + startOfLine) / 2;
            if (Math.Abs(GetF(x)) > epsilon)
            {
                if (GetF(x) > 0)
                {
                    return GetX(startOfLine, endOfLine = x, epsilon);
                }
                else
                {
                    return x = GetX(startOfLine = x, endOfLine, epsilon);
                }
            }

            else
            {
                return x = (startOfLine + endOfLine) / 2;
            }
        }

        private static double GetF(double x)
        {
            double f = Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 12 * x - 8;

            return f;
        }
    }
}