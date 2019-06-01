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
        public void Add_SimpleValuesShouldCalculate()
        {
            double expected = 5;

            double actual = Calculator.Add(3, 5);

            Assert.Equal(expected, actual);
        }
    }
}
