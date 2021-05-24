using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Calculations;


namespace Calculations_Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntegers_ReturnsSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 1);
            Assert.Equal(2,result);
        }

        [Fact]
        public void Add_GivenTwoDoubles_ReturnsSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1.5, 2.5);
            Assert.Equal(4.0, result);
        }
    }
}
