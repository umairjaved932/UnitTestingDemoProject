using System;
using System.Collections.Generic;
using System.Text;
using Calculations;
using Xunit;
namespace Calculations_Tests
{
    public class NamesTest
    {
        [Fact]
        [Trait("Strings","Names")]
        public void Check_GivenTwoStrings_ReturnsFullName()
        {
            var names = new Names();
            var result = names.FullName("Umair", "Javed");
            Assert.Equal("Umair Javed", result);
        }

        [Fact]
        [Trait("Strings", "Names")]
        public void Check_GivenTwoStrings_ContainsWord()
        {
            var names = new Names();
            var result = names.FullName("Umair", "Javed");
            Assert.Contains("Umair", result, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
