using NUnit.Framework;
using System.Collections.Generic;

namespace Skat.Extensions.Tests
{
    public class PrimeTests
    {
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(23)]
        [TestCase(31)]
        [TestCase(67)]
        [TestCase(17180131327)]
        public void MustBePrime(long number)
        {
            bool pass = number.IsPrime();
            Assert.IsTrue(pass);
        }


        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(21)]
        [TestCase(24)]
        [TestCase(66)]
        [TestCase(144)]
        [TestCase(17180131321)]
        public void CannotBePrime(long number)
        {
            bool pass = number.IsPrime();
            Assert.IsFalse(pass);
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(7, 11)]
        [TestCase(15, 17)]
        [TestCase(72, 73)]
        [TestCase(100, 101)]
        [TestCase(39, 41)]
        public void TestNextPrime(long number, long check)
        {
            long next = number.NextPrime();
            Assert.AreEqual(check, next);
        }

        [Test]
        [TestCase(4, new long[] { 2, 3 })]
        [TestCase(7, new long[] { 2, 3, 5 })]
        [TestCase(23, new long[] { 2, 3, 5, 7, 11, 13, 17, 19})]
        [TestCase(31, new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29})]
        public void TestListPrimes(long number, long[] check)
        {
            List<long> primes = number.GetLowerPrimes();
            for(int i = 0; i < check.Length; i++)
            {
                Assert.AreEqual(check[i], primes[i]);
            }

        }
    }
}