using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleSolver;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
        {
            int side1 = 5, side2 = 5, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Equilateral triangle", result);
        }
    }
}