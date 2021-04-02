using NUnit.Framework;
using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests
{
    public class PerfectNumberTests
    {
        [Test]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(6, true)]
        [TestCase(28, true)]
        [TestCase(16, false)]
        [TestCase(8, false)]
        [TestCase(8128, true)]
        public void TestPerfectNumbers(long number, bool expectedResult)
        {
            Assert.AreEqual(number.IsPerfectNumber(), expectedResult);
        }


        [Test]
        [TestCase(10, new long[] { 6 })]
        [TestCase(30, new long[] { 6, 28 })]
        public void TestPerfectNumbers(long number, long[] expectedResult)
        {
            var perfects = number.GetPerfectNumbers();
            Assert.AreEqual(perfects.Count, expectedResult.Length);
            for(int i = 0; i < perfects.Count; i++)
            {
                Assert.AreEqual(perfects[i], expectedResult[i]);
            }
        }


    }
}
