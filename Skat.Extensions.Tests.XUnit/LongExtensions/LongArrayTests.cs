using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests.XUnit.LongExtensions
{
    public class LongArrayTests
    {

        [Theory]
        [InlineData(new long[] { 3, 18 }, new long[] { 2, 3, 3 })]
        [InlineData(new long[] { 3, 18, 21 }, new long[] { 2, 3, 3, 7 })]
        [InlineData(new long[] { 6, 20 }, new long[] { 2, 2, 3, 5 })]
        public void TestArrayDecomposition(long[] test, long[] check)
        {
            var result = test.Decompose();

            Assert.Equal(check.ToList().Count, result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.Equal(check[i], result[i]);
            }
        }


        [Theory]
        [InlineData(new long[] { 3, 18 }, 18)]
        [InlineData(new long[] { 7, 49 }, 49)]
        [InlineData(new long[] { 3, 18, 21 }, 126)]
        public void TestMinimumCommonMultiple(long[] test, long check)
        {
            var r = test.MinimumCommonMultiple();
            Assert.Equal(check, r);
        }

        [Theory]
        [InlineData(new long[] { 3, 18 }, 3)]
        [InlineData(new long[] { 7, 49 }, 7)]
        [InlineData(new long[] { 3, 18, 21 }, 3)]
        [InlineData(new long[] { 6, 20 }, 2)]
        [InlineData(new long[] { 6, 35, 20 }, 420)]

        public void TestMaximumCommonDivider(long[] test, long check)
        {
            var r = test.MaximumCommonDivider();
            Assert.Equal(check, r);
        }

    }
}
