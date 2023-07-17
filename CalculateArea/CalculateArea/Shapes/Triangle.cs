using System;

namespace CalculateArea
{
    public class Triangle: Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");

            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
                throw new ArgumentException("Треугольник с такими сторонами существовать не может.");

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightTriangle()
        {
            double a2 = Math.Pow(side1, 2);
            double b2 = Math.Pow(side2, 2);
            double c2 = Math.Pow(side3, 2);

            return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }
    }
}
