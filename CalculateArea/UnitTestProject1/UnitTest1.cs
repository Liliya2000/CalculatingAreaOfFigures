using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_CalculateArea_ReturnsExceptionForNegativeRadius()
        {
            // Arrange
            double radius = -5;
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();
        }

        [TestMethod]
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_CalculateArea_ReturnsExceptionForNonexistentTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 8;

            // Act
            Triangle triangle = new Triangle(side1, side2, side3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_CalculateArea_ReturnsExceptionForNegativeSide()
        {
            // Arrange
            double side1 = 3;
            double side2 = -4;
            double side3 = 5;

            // Act
            Triangle triangle = new Triangle(side1, side2, side3);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }


}
