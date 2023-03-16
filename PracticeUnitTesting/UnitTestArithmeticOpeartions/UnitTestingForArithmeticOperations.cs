using ArithmeticOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestArithmeticOpeartions
{
    [TestClass]
    public class UnitTestingForArithmeticOperations
    {
        public int i = 10, j = 20;

        [TestMethod]
        public void TestAdd()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(30, ar.Add(i,j));
        }

        [TestMethod]
        [Ignore("Not to be implemented!")]
        public void TestSub()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(-10, ar.Sub(i,j));
        }

        [TestMethod]
        public void TestMul()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(200, ar.Mul(i, j));
        }

        [TestMethod]
        public void TestDiv()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(0, ar.Div(i, j));
        }
    }
}
