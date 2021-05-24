using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculations_Tests
{
    public static class TestDataSharer
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {

                yield return new object[] { 1, true };
                yield return new object[] { 200, false };

                //var allLines = System.IO.File.ReadAllLines("ExternalData.txt");
                //return allLines.Select(x =>
                //{
                //    var lineSplit = x.Split(',');
                //    return new object[] {int.Parse(lineSplit[0]), bool.Parse(lineSplit[1])};
                //});
            }
        }
    }
}
