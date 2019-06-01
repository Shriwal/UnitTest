using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 8, 12)]
        [InlineData(21, 5, 26)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            double expected = 0;

            double actual = Calculator.Divide(15, 0);

            Assert.Equal(expected, actual);
        }

    }
}
