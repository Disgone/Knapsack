using System;
using Xunit;

namespace Knapsack.Tests
{
    public static class DateTimeExtensionTests
    {
        public class IsWeekend
        {
            [Fact]
            public void DateOnWeekend_IsTrue()
            {
                DateTime date = new DateTime(2015, 11, 1); // Sunday
                Assert.True(date.IsWeekend());

                date = new DateTime(2015, 11, 7);
                Assert.True(date.IsWeekend());
            }

            [Fact]
            public void DateOnWeekday_IsFalse()
            {
                DateTime date = new DateTime(2015, 11, 2); // Monday
                for (int i = 0; i < 5; i++)
                {
                    DateTime testDate = date.AddDays(i);
                    Assert.False(testDate.IsWeekend(), $"{testDate:D}");
                }
            }
        }

        public class IsBetween
        {
            [Fact]
            public void IsBetweenTwoDates()
            {
                var date = DateTime.Now;
                Assert.True(date.IsBetween(date.AddDays(-1), date.AddDays(1)));
            }

            [Fact]
            public void IsPrior()
            {
                var date = DateTime.Now;
                Assert.False(date.IsBetween(date.AddDays(1), date.AddDays(2)));
            }

            [Fact]
            public void IsAfter()
            {
                var date = DateTime.Now;
                Assert.False(date.IsBetween(date.AddDays(-2), date.AddDays(-1)));
            }

            [Fact]
            public void DateFallsOnLowerBound()
            {
                var date = DateTime.Now;
                Assert.True(date.IsBetween(date, date.AddDays(1)));
            }

            [Fact]
            public void DateFallsOnUpperBound()
            {
                var date = DateTime.Now;
                Assert.True(date.IsBetween(date.AddDays(-1), date));
            }

            [Fact]
            public void UpperAndLowerAreFlipped()
            {
                var date = DateTime.Now;
                Assert.True(date.IsBetween(date.AddDays(1), date.AddDays(-1)));
            }
        }
    }
}
