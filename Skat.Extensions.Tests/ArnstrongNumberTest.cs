using NUnit.Framework;

namespace Skat.Extensions.Tests
{
    public class ArnstrongNumberTest
    {
        [Test]
        [TestCase(12, false)]
        [TestCase(153, true)]
        public void TestArmstrongNumber(long testNumber, bool expectedResult)
        {            
            Assert.AreEqual(expectedResult, testNumber.IsArmstrongNumber());
        }

        [Test]
        [TestCase(410, new int[] {0, 1, 153, 370, 371, 407})]
        public void TestArmstrongList(long limit, int[] check)
        {
            var armstrongNumbers = limit.GetArmstrongNumbers();

            Assert.AreEqual(armstrongNumbers.Count, check.Length);

            for(int i = 0; i < armstrongNumbers.Count; i++)
            {
                Assert.AreEqual(check[i], armstrongNumbers[i]);
            }
        }
    }
}
