using System;
using Xunit;

namespace Knapsack.Tests
{
    public static class CollectionExtensionsTests
    {
        public class IsIn
        {
            [Fact]
            public void IsIn_NeedleInHaystack_IsTrue()
            {
                var result = "one".IsIn("one", "two", "three");
                Assert.True(result);
            }

            [Fact]
            public void IsIn_NeedleNotInHaystack_IsFalse()
            {
                var result = "one".IsIn("two", "three");
                Assert.False(result);
            }

            [Fact]
            public void IsIn_EmptyHaystack_IsFalse()
            {
                var result = "one".IsIn();
                Assert.False(result);
            }

            [Fact]
            public void IsIn_HasFlag_IsTrue()
            {
                var result = FlagEnum.Two.IsIn(FlagEnum.One, FlagEnum.Three, FlagEnum.Two);
                Assert.True(result);
            }

            [Flags]
            internal enum FlagEnum : byte
            {
                One = 0,
                Two = 1 << 0,
                Three = 1 << 1
            }
        }
    }
}
