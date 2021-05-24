using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using  Xunit.Sdk;

namespace Calculations_Tests
{
    public class TestDataSharerDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var allLines = System.IO.File.ReadAllLines("ExternalData.txt");
            return allLines.Select(x =>
            {
                var lineSplit = x.Split(',');
                return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
            });
        }
    }
}
