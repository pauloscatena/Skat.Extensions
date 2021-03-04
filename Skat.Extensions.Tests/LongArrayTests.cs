using NUnit.Framework;
using System.Linq;

namespace Skat.Extensions.Tests
{
    public class LongArrayTests
    {

        [Test]
        [TestCase(new long[] { 3, 18 }, new long[] { 2, 3, 3 })]
        [TestCase(new long[] { 3, 18, 21 }, new long[] { 2, 3, 3, 7 })]
        [TestCase(new long[] { 6, 20 }, new long[] { 2, 2, 3, 5 })]
        public void TestArrayDecomposition(long[] test, long[] check)
        {
            var result = test.Decompose();

            Assert.AreEqual(check.ToList().Count, result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(check[i], result[i]);
            }
        }


        [Test]
        [TestCase(new long[] { 3, 18 }, 18)]
        [TestCase(new long[] { 7, 49 }, 49)]
        [TestCase(new long[] { 3, 18, 21 }, 126)]
        public void TestMinimumCommonMultiple(long[] test, long check)
        {
            var r = test.MinimumCommonMultiple();
            Assert.AreEqual(check, r);
        }

        [Test]
        [TestCase(new long[] { 3, 18 }, 3)]
        [TestCase(new long[] { 7, 49 }, 7)]
        [TestCase(new long[] { 3, 18, 21 }, 3)]
        [TestCase(new long[] { 6, 20 }, 2)]
        [TestCase(new long[] { 6, 35, 20 }, 420)]

        public void TestMaximumCommonDivider(long[] test, long check)
        {
            var r = test.MaximumCommonDivider();
            Assert.AreEqual(check, r);
        }

    }
}
