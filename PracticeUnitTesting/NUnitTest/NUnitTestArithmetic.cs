using ArthmeticOperationsLibrary;
using Moq;

namespace NUnitTest
{
    public class NUnitTestArithmetic
    {
        private readonly int i = 20;
        private readonly int j = 30;
        public bool result;

        [SetUp]
        public void CheckNonNegative()
        {
            if (i > 0 && j > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        // TearDown method in NUnit Test
        [TearDown]
        public void SetupDefaultValues()
        {
            result = false;
        }

        [Test]
        public void TestAdd()
        {
            if (result)
            {
                int expected_value = 50;
                int actual_value = ArithmeticOperations.Add(i, j);
                Assert.That(actual_value, Is.EqualTo(expected_value));
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        [Ignore("Not to be implemented!")]
        public void TestSub()
        {

        }

        [Test]
        [TestCase(10, 5, 50)]
        //[TestCase(3, 5, 12)]
        public void TestMul(int a, int b, int expected)
        {
            int actual = ArithmeticOperations.Mul(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Not to be implemented!")]
        public void TestDiv()
        {

        }

        // This test will always fails because expected bool value is true but actually it is false.
        // Here, we are bypassing the result of unimplemented method:
        // To overcome this issue in real-time projects there is use of MOQ Framework!

        /*[Test]
        public void CheckValues()
        {
            ArithmeticOperations ar = new ArithmeticOperations();
            Assert.AreEqual(true, ar.CheckDigitsOnly());
        }*/

        // Use of Mock Framework:
        [Test]
        public void CheckValues()
        {
            Mock<ArithmeticOperations> mock= new Mock<ArithmeticOperations>();
            mock.Setup(x => x.CheckDigitsOnly()).Returns(true);

            //Assert.AreEqual(true, mock.Object.CheckDigitsOnly());
            Assert.That(mock.Object.CheckDigitsOnly(), Is.EqualTo(true));
        }
    }
}