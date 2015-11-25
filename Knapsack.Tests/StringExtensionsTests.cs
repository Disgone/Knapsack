using Xunit;

namespace Knapsack.Tests
{
    public static class StringExtensionsTests
    {
        public class Matches
        {
            [Fact]
            public void ExactMatch_IsTrue()
            {
                string myValue = "Abc123";
                Assert.True(myValue.Matches(myValue));
            }

            [Fact]
            public void SameValueWithDifferentCase_IsTrue()
            {
                string myValue = "abcABC";
                string yourValue = "ABCabc";
                Assert.True(myValue.Matches(yourValue));
            }

            [Fact]
            public void DifferentStrings_IsFalse()
            {
                string myValue = "niner";
                string yourValue = "several";
                Assert.False(myValue.Matches(yourValue));
            }
        }
    }
}
