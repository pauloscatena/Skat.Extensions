using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests.XUnit.LongExtensions
{
    public class PrimeTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(23)]
        [InlineData(31)]
        [InlineData(67)]
        [InlineData(17180131327)]
        public void MustBePrime(long number)
        {
            bool pass = number.IsPrime();
            Assert.True(pass);
        }


        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(21)]
        [InlineData(24)]
        [InlineData(66)]
        [InlineData(144)]
        [InlineData(17180131321)]
        public void CannotBePrime(long number)
        {
            bool pass = number.IsPrime();
            Assert.False(pass);
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(7, 11)]
        [InlineData(15, 17)]
        [InlineData(72, 73)]
        [InlineData(100, 101)]
        [InlineData(39, 41)]
        public void TestNextPrime(long number, long check)
        {
            long next = number.NextPrime();
            Assert.Equal(check, next);
        }

        [Theory]
        [InlineData(4, new long[] { 2, 3 })]
        [InlineData(7, new long[] { 2, 3, 5 })]
        [InlineData(23, new long[] { 2, 3, 5, 7, 11, 13, 17, 19})]
        [InlineData(31, new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29})]
        public void TestListPrimes(long number, long[] check)
        {
            List<long> primes = number.GetLowerPrimes();
            for(int i = 0; i < check.Length; i++)
            {
                Assert.Equal(check[i], primes[i]);
            }

        }
    }
}