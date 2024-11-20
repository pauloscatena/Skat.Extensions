using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests.XUnit.LongExtensions
{
    public class NumberDigitTests
    {
        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(12, new int[] { 2, 1 })]
        [InlineData(123, new int[] { 3, 2, 1 })]
        [InlineData(1234, new int[] { 4, 3, 2, 1 })]
        [InlineData(12345, new int[] { 5, 4, 3, 2, 1 })]
        [InlineData(999999, new int[] { 9, 9, 9, 9, 9, 9 })]
        [InlineData(-1, new int[] { 1 })]
        [InlineData(-12, new int[] { 2, 1 })]
        [InlineData(-123, new int[] { 3, 2, 1 })]
        [InlineData(-1234, new int[] { 4, 3, 2, 1 })]
        [InlineData(-12345, new int[] { 5, 4, 3, 2, 1 })]
        [InlineData(-999999, new int[] { 9, 9, 9, 9, 9, 9 })]
        public void ExtractDigitTest(long number, int[] result)
        {
            var check = number.ExtractDigits();
            for (int i = 0; i < check.Count; i++)
            {
                Assert.Equal(check[i], result[i]);
            }
        }
    }
}
