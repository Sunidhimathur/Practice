using AdditionTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAddition
{
    [TestClass]
    public class UnitTestingForAdding
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            int expected_value = 11;
            int num1 = 5;
            int num2 = 6;

            // Act
            int actual_value = Addition.AddTwoNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected_value, actual_value);
        }
    }
}
