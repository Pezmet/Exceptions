using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace CalculatorTest.MSTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.ThrowsException<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+")); //£

            var ex = Assert.ThrowsException<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.AreEqual("+", ex.Operation);
        }
    }
}
