using NUnit.Framework;
using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests
{
    public class NumberDigitTests
    {
        [Test]
        [TestCase(1, new int[] { 1 })]
        [TestCase(12, new int[] { 2, 1 })]
        [TestCase(123, new int[] { 3, 2, 1 })]
        [TestCase(1234, new int[] { 4, 3, 2, 1 })]
        [TestCase(12345, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(999999, new int[] { 9, 9, 9, 9, 9, 9 })]
        [TestCase(-1, new int[] { 1 })]
        [TestCase(-12, new int[] { 2, 1 })]
        [TestCase(-123, new int[] { 3, 2, 1 })]
        [TestCase(-1234, new int[] { 4, 3, 2, 1 })]
        [TestCase(-12345, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(-999999, new int[] { 9, 9, 9, 9, 9, 9 })]
        public void ExtractDigitTest(long number, int[] result)
        {
            var check = number.ExtractDigits();
            for (int i = 0; i < check.Count; i++)
            {
                Assert.AreEqual(check[i], result[i]);
            }
        }
    }
}
