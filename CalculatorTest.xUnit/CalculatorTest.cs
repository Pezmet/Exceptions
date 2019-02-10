using ConsoleCalculator;
using Xunit;

namespace CalculatorTest.xUnit
{
    public class CalculatorTest
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.Throws<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.ThrowsAny<CalculatorException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));
            // Assert.Equal(ex.Operation, "+");
            Assert.Equal("+", ex.Operation);
        }
    }
}
