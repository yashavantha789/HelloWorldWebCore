using System;
using Xunit;

namespace HelloTests
{
    public class BaseTests
    {
        [Fact]
        public void ThisIsAGreenTest()
        {

        }

        [Fact]
        public void ThisIsARedTest()
        {
            Assert.False(true, "Failed test message");
        }
    }
}
