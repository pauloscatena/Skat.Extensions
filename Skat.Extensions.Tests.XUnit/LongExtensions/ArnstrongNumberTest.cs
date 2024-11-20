using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests.XUnit.LongExtensions
{
    public class ArnstrongNumberTest
    {
        [Theory]
        [InlineData(12, false)]
        [InlineData(153, true)]
        public void TestArmstrongNumber(long testNumber, bool expectedResult)
        {            
            Assert.Equal(expectedResult, testNumber.IsArmstrongNumber());
        }

        [Theory]
        [InlineData(410, new int[] {0, 1, 153, 370, 371, 407})]
        public void TestArmstrongList(long limit, int[] check)
        {
            var armstrongNumbers = limit.GetArmstrongNumbers();

            Assert.Equal(armstrongNumbers.Count, check.Length);

            for(int i = 0; i < armstrongNumbers.Count; i++)
            {
                Assert.Equal(check[i], armstrongNumbers[i]);
            }
        }
    }
}
