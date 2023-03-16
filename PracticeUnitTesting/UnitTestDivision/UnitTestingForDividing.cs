using DivisionTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDivision
{
    [TestClass]
    public class UnitTestingForDividing
    {
        [TestMethod]
        public void TestDivide()
        {
            // Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
