using NUnit.Framework;

namespace Skat.Extensions.Tests
{
    public class StringExtensionTests
    {
        [Test]
        [TestCase("cavalo", "alcova")]
        [TestCase("casa", "saca")]
        [TestCase("maca", "cama")]
        public void MustBeAnagram(string word, string check)
        {
            Assert.IsTrue(word.IsExactAnagram(check));
        }
    }
}
