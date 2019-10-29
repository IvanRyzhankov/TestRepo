using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_4.Enums;

namespace Module2_4
{
    public class GeometricShape
    {
        private readonly ShapeType typeOfShape;
        private readonly double userValue;

        public GeometricShape(ShapeType typeOfShape, double userValue)
        {
            this.typeOfShape = typeOfShape;
            this.userValue = userValue;
        }

        public double GetPerimeterOfShape()
        {
            double perimeter = 0;
            switch (typeOfShape)
            {
                case ShapeType.Triangle:
                    perimeter = userValue * 3;
                    break;
                case ShapeType.Quadrangle:
                    perimeter = userValue * 4;
                    break;
                case ShapeType.Circle:
                    perimeter = 2 * Math.PI * userValue;
                    break;
            }
            return perimeter;
        }

        public double GetSquareOfShape()
        {
            double area = 0;
            switch (typeOfShape)
            {
                case ShapeType.Triangle:
                    double triangleHeight = userValue * 3 / 2;
                    area = Math.Sqrt(triangleHeight * Math.Pow((triangleHeight - userValue), 3));
                    break;
                case ShapeType.Quadrangle:
                    area = Math.Pow(userValue, 2);
                    break;
                case ShapeType.Circle:
                    area = Math.Pow(userValue, 2) * Math.PI;
                    break;
            }

            return area;
        }
    }
}
