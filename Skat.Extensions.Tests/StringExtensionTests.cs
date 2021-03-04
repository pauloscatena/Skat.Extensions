using NUnit.Framework;

namespace Skat.Extensions.Tests
{
    public class StringExtensionTests
    {
        [Test]
        [TestCase("cavalo", "alcova")]
        [TestCase("cava-lo", "alcova")]
        [TestCase("casa", "saca")]
        [TestCase("maca", "cama")]
        public void MustBeAnagram(string word, string check)
        {
            Assert.IsTrue(word.IsExactAnagram(check));
        }

        [Test]
        [TestCase("cav alo", "cavalo")]
        [TestCase("cava-lo", "cavalo")]
        [TestCase("casa ", "casa")]
        [TestCase("m-a.c@a", "maca")]
        public void MustRemovePunctuation(string word, string check)
        {
            Assert.AreEqual(check, word.RemoveSpacesAndPunctuation());
        }


        [Test]
        [TestCase("otto")]
        [TestCase("Otto")]
        [TestCase("Oto come mocoto")]
        public void MustBePalindrome(string word)
        {
            Assert.IsTrue(word.IsPalindrome());
        }

        [Test]
        [TestCase("oito")]
        [TestCase("banana")]
        [TestCase("May the force be with you")]
        public void CannotBePalindrome(string word)
        {
            Assert.IsFalse(word.IsPalindrome());
        }

    }
}
