using Skat.Extensions.StringExtensions;

namespace Skat.Extensions.Tests.XUnit.StringExtensions
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("cavalo", "alcova")]
        [InlineData("cava-lo", "alcova")]
        [InlineData("casa", "saca")]
        [InlineData("maca", "cama")]
        public void MustBeAnagram(string word, string check)
        {
            Assert.True(word.IsExactAnagram(check));
        }

        [Theory]
        [InlineData("cav alo", "cavalo")]
        [InlineData("cava-lo", "cavalo")]
        [InlineData("casa ", "casa")]
        [InlineData("m-a.c@a", "maca")]
        public void MustRemovePunctuation(string word, string check)
        {
            Assert.Equal(check, word.RemoveSpacesAndPunctuation());
        }


        [Theory]
        [InlineData("otto")]
        [InlineData("Otto")]
        [InlineData("Oto come mocoto")]
        public void MustBePalindrome(string word)
        {
            Assert.True(word.IsPalindrome());
        }

        [Theory]
        [InlineData("oito")]
        [InlineData("banana")]
        [InlineData("May the force be with you")]
        public void CannotBePalindrome(string word)
        {
            Assert.False(word.IsPalindrome());
        }
    }
}
