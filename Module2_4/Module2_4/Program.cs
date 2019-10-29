using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_4.Enums;

namespace Module2_4
{
    class Program
    {
        static void Main()
        {
            ShapeType typeOfShape = GetTypeOfShape();
            TypeOfOperation typeOfOperation = GetTypeOfOperation(typeOfShape);
            double userValue = GetUserValue(typeOfShape);
            GeometricShape shape = new GeometricShape(typeOfShape, userValue);
            double result = Calculate(shape, typeOfOperation);
            ShowSizesCalculations(result, typeOfOperation, typeOfShape);
            GeometricPatameter hypotheticalResults = GetHypotheticalResults(typeOfShape, typeOfOperation, result);
            ShowSizesHypotheticalCalculations(hypotheticalResults, typeOfOperation, typeOfShape);

            Console.ReadKey();
        }

        static int GetNumberForTypeOfShape(string message)
        {
            int number;
            bool isValid;
            do
            {
                number = GetNumberFromUser(message);
                isValid = number >= 1 && number <= 3;
                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you can enter only numbers 1,2 or 3");
                }

            } while (!isValid);

            return number;
        }

        static int GetNumberForTypeOfOperation(string message)
        {
            int number;
            bool isValid;
            do
            {
                number = GetNumberFromUser(message);
                isValid = number == 1 || number == 2;
                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you can enter only numbers 1 or 2");
                }

            } while (!isValid);

            return number;
        }



        static int GetNumberFromUser(string messageToUser)
        {
            bool parsedValue;
            int value;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                parsedValue = int.TryParse(response, out value);

                if (!parsedValue)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you can enter only numbers");
                }
            } while (!parsedValue);

            return value;
        }

        static ShapeType GetTypeOfShape()
        {
            string message = "Select a type of figure: \n" +
                             "Press 1 to select a triangle.\n" +
                             "Press 2 to select a quadrangle.\n" +
                             "Press 3 to select a circle.\n" +
                             "\n" +
                             "please enter the Shape number: ";

            int responseNumber = GetNumberForTypeOfShape(message);

            switch (responseNumber)
            {
                case 1: return ShapeType.Triangle;
                case 2: return ShapeType.Quadrangle;
                case 3: return ShapeType.Circle;
                default: throw new Exception();
            }
        }

        static TypeOfOperation GetTypeOfOperation(ShapeType type)
        {
            Console.Clear();
            string message = $"Ok you chose {type}.\n" +
                             "What do you need to calculate?:\n" +
                             "Press 1 to calculate the perimeter.\n" +
                             "Press 2 to calculate the area.\n" +
                             "\n" +
                             "please enter the number: ";

            int responseNumber = GetNumberForTypeOfOperation(message);

            switch (responseNumber)
            {
                case 1: return TypeOfOperation.Perimeter;
                case 2: return TypeOfOperation.Square;
                default: throw new Exception();
            }
        }

        static double GetUserValue(ShapeType typeOfShape)
        {
            string message = null;
            double userValue;
            Console.Clear();

            switch (typeOfShape)
            {
                case ShapeType.Triangle:
                    message = "Enter the length of the side of\n" +
                              "the equilateral triangle.";
                    break;
                case ShapeType.Quadrangle:
                    message = "Enter the length of the side of the square.";
                    break;
                case ShapeType.Circle:
                    message = "Enter the radius of the circle.\n";
                    break;
            }

            userValue = GetValueOfSideFromUser(message);

            return userValue;

        }

        static double GetValueOfSideFromUser(string messageToUser)
        {
            bool valueIsValid;
            double value;

            do
            {
                Console.WriteLine(messageToUser);
                string response = Console.ReadLine();
                var parsedValue = double.TryParse(response, out value);

                valueIsValid = parsedValue && parsedValue && value > 0;

                if (!valueIsValid)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you can enter numbers > 0");
                }
            }
            while (!valueIsValid);

            return value;
        }

        static double Calculate(GeometricShape shape, TypeOfOperation typeOfOperation)
        {
            double result = 0;

            switch (typeOfOperation)
            {
                case TypeOfOperation.Perimeter:
                    result = shape.GetPerimeterOfShape();
                    break;
                case TypeOfOperation.Square:
                    result = shape.GetSquareOfShape();
                    break;
            }

            return result;
        }

        static void ShowSizesCalculations(double result, TypeOfOperation typeOfOperation, ShapeType typeOfShape)
        {
            Console.Clear();

            switch (typeOfOperation)
            {
                case TypeOfOperation.Perimeter:
                    Console.WriteLine($"the perimeter of this {typeOfShape} is {result}\n" + "");
                    break;

                case TypeOfOperation.Square:
                    Console.WriteLine($"the area of this {typeOfShape} is {result}\n" + "");
                    break;
            }
        }

        static GeometricPatameter GetHypotheticalResults(ShapeType typeOfShape, TypeOfOperation typeOfOperation, double result)
        {
            GeometricPatameter hypotheticalResultParam = new GeometricPatameter();
            switch (typeOfShape)
            {
                case ShapeType.Triangle:

                    switch (typeOfOperation)
                    {
                        case TypeOfOperation.Perimeter:
                            hypotheticalResultParam.Radius = result / 2 * Math.PI;
                            hypotheticalResultParam.SideOfQuadrangle = result / 4;
                            break;

                        case TypeOfOperation.Square:
                            hypotheticalResultParam.Radius = Math.Sqrt(result / Math.PI);
                            hypotheticalResultParam.SideOfQuadrangle = Math.Sqrt(result);
                            break;
                    }
                    break;
                case ShapeType.Quadrangle:

                    switch (typeOfOperation)
                    {
                        case TypeOfOperation.Perimeter:
                            hypotheticalResultParam.Radius = result / 2 * Math.PI;
                            hypotheticalResultParam.SideOfTriangle = result / 3;
                            break;

                        case TypeOfOperation.Square:
                            hypotheticalResultParam.Radius = Math.Sqrt(result / Math.PI);
                            hypotheticalResultParam.SideOfTriangle = Math.Sqrt(4 * result / Math.Sqrt(3));
                            break;
                    }
                    break;
                case ShapeType.Circle:
                    switch (typeOfOperation)
                    {
                        case TypeOfOperation.Perimeter:
                            hypotheticalResultParam.SideOfQuadrangle = result / 4;
                            hypotheticalResultParam.SideOfTriangle = result / 3;
                            break;

                        case TypeOfOperation.Square:
                            hypotheticalResultParam.SideOfTriangle = Math.Sqrt(4 * result / Math.Sqrt(3));
                            hypotheticalResultParam.SideOfQuadrangle = Math.Sqrt(result);
                            break;
                    }
                    break;
            }

            return hypotheticalResultParam;
        }

        static void ShowSizesHypotheticalCalculations(GeometricPatameter hypotheticalResultParam, TypeOfOperation typeOfOperation, ShapeType typeOfShape)
        {

            switch (typeOfShape)
            {
                case ShapeType.Triangle:

                    Console.WriteLine($"Hypothetical radius of {ShapeType.Circle} is {hypotheticalResultParam.Radius}");
                    Console.WriteLine($"the side of this {ShapeType.Quadrangle} is {hypotheticalResultParam.SideOfQuadrangle}");
                    break;

                case ShapeType.Quadrangle:

                    Console.WriteLine($"Hypothetical radius of {ShapeType.Circle} is {hypotheticalResultParam.Radius}");
                    Console.WriteLine($"Hypothetical side of {ShapeType.Triangle} is {hypotheticalResultParam.SideOfTriangle}");
                    break;

                case ShapeType.Circle:

                    Console.WriteLine($"Hypothetical side of {ShapeType.Quadrangle} is {hypotheticalResultParam.SideOfQuadrangle}");
                    Console.WriteLine($"Hypothetical side of {ShapeType.Triangle} is {hypotheticalResultParam.SideOfTriangle}");
                    break;
            }
        }
    }
}