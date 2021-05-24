using System;
using System.Collections.Generic;
using System.Text;
using  Xunit;
using Calculations;

namespace Calculations_Tests
{
    public class CalculationTest
    {
        [Theory]
        [InlineData(1,true)]
        [InlineData(200,false)]
        public void IsOdd_TestOddAndEven_Inline(int value, bool expected)
        {
            var calc = new Calculation();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestDataSharer.IsOddOrEvenData), MemberType = typeof(TestDataSharer))]
        public void IsOdd_TestOddAndEven_Property(int value, bool expected)
        {
            var calc = new Calculation();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [TestDataSharerData]
        public void IsOdd_TestOddAndEven_Method(int value, bool expected)
        {
            var calc = new Calculation();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
