using System;
using Xunit;

namespace Knapsack.Tests
{
    public static class ErrorCheckingExtensionsTests
    {
        public class ThrowIfNull
        {
            [Fact]
            public void ArgumentIsNull_ThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => ((string)null).ThrowIfNull("argument"));
            }

            [Fact]
            public void ArgumentIsNotNullNull()
            {
                "argument".ThrowIfNull("argument");
            }
        }
    }
}
