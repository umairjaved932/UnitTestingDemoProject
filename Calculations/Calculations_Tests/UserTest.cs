using System;
using System.Collections.Generic;
using System.Text;
using Calculations;
using Xunit;

namespace Calculations_Tests
{
    public class UserTest
    {
        [Fact]
        public void CheckUserExists()
        {
            var users = new User();
            Assert.Contains(users.Employees, n => n == 1015);
        }
    }
}
