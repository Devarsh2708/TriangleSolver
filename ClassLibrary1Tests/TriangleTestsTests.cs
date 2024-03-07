using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleSolver;

namespace Tests
{
    [TestClass()]
    public class TriangleTestsTests
    {
        [TestMethod]
        public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_ValidIsoscelesTriangle_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        // Add two more similar tests for ValidIsoscelesTriangle

        [TestMethod]
        public void AnalyzeTriangle_ValidScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 3, side2 = 4, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        // Add four more similar tests for ValidScaleneTriangle

        [TestMethod]
        public void AnalyzeTriangle_InvalidZeroLengthSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = 0, side2 = 4, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        // Add two more similar tests for InvalidZeroLengthSide

        [TestMethod]
        public void AnalyzeTriangle_InvalidResponse_ReturnsInvalid()
        {
            // Arrange
            int side1 = 1, side2 = 1, side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

    }
}