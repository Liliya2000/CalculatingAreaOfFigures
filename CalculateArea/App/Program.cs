using System;
using CalculateArea;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Площадь круга: {circleArea}");

            Shape triangle = new Triangle(3, 4, 5);
            double triangleArea = triangle.CalculateArea();
            Console.WriteLine($"Площадь треугольника: {triangleArea}");

            Triangle rightTriangle = new Triangle(3, 4, 5);
            bool isRightTriangle = rightTriangle.IsRightTriangle();
            Console.WriteLine($"Треугольник является прямоугольным: {isRightTriangle}");

            Console.ReadKey();
        }
    }
}
