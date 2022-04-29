using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UltimateApp.Test
{
    [TestClass]
    public class UltimateAppTester
    {
        [TestMethod]
        public void AddTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Add);
            Assert.AreEqual(5, retVal);
        }
        [TestMethod]
        public void SubtractTest()
        {
            int? retVal = Calculator.calculate(5, 3, Operation.Subtract);
            Assert.AreEqual(2, retVal);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Multiply);
            Assert.AreEqual(6, retVal);
        }
        [TestMethod]
        public void DivideTest()
        {
            int? retVal = Calculator.calculate(10, 5, Operation.Divide);
            Assert.AreEqual(2, retVal);
        }
        [TestMethod]
        public void ModuloTest()
        {
            int? retVal = Calculator.calculate(4, 3, Operation.Modulo);
            Assert.AreEqual(1, retVal);
        }
    }
}
