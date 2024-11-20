using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests
{
    public class PerfectNumberTests
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(28, true)]
        [InlineData(16, false)]
        [InlineData(8, false)]
        [InlineData(8128, true)]
        public void TestPerfectNumbers(long number, bool expectedResult)
        {
            Assert.Equal(number.IsPerfectNumber(), expectedResult);
        }


        [Theory]
        [InlineData(10, new long[] { 6 })]
        [InlineData(30, new long[] { 6, 28 })]
        public void TestPerfectNumbersRange(long number, long[] expectedResult)
        {
            var perfects = number.GetPerfectNumbers();
            Assert.Equal(perfects.Count, expectedResult.Length);
            for(int i = 0; i < perfects.Count; i++)
            {
                Assert.Equal(perfects[i], expectedResult[i]);
            }
        }
    }
}
