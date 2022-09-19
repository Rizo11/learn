using Xunit;
using DemoLibrary;
namespace DemoLibrary.xTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            // Arrange
            double expected = 5;

            // Act fase
            double actual = Calculator.Add(3, 2);

            // Assert = comparing result
            Assert.Equal(expected, actual);
        }
    }
}