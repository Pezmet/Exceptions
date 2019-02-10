using NUnit.Framework;
using ConsoleCalculator;

namespace Tests
{
    public class CalculatorTests
    {
        //[SetUp]
        //public void Setup()
        //{
               
        //}

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(1,1,"+"),
                Throws.TypeOf< CalculatorOperationNotSupportedException > ());

            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculatorOperationNotSupportedException>()
                .With
                .Property("Operation").EqualTo("+"));

            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.InstanceOf<CalculatorException>());

            Assert.Throws<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculatorOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));
            Assert.That(ex.Operation, Is.EqualTo("+"));
        }
    }
}