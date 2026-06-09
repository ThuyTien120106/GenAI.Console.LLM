
using System;
using Xunit;
using DemoUnitTest_ConsoleApp;
namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_GivenTwoNumbers_ReturnsTheirSum()
        {
            // Arrange: Two numbers to add
            int a = 1;
            int b = 2;

            // Act: Call the method and store the result
            int sum = _calculator.Add(a, b);

            // Assert: The result is what we expect
            Assert.Equal(3, sum);
        }
    }
}