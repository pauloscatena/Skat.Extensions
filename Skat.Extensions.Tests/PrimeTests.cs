using NUnit.Framework;


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
    }
}