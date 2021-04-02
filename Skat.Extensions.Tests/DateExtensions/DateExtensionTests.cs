using NUnit.Framework;
using System;

namespace Skat.Extensions.Tests
{
    public class DateExtensionTests
    {
        [Test]
        [TestCase(2021, 2021, 4, 4)]
        [TestCase(2020, 2020, 4, 12)]
        [TestCase(2019, 2019, 4, 21)]
        public void TestEaster(int year, int expectedYear, int expectedMonth, int expectedDay)
        {
            var easter = DateExtensions.DateExtension.GetEaster(year);

            Assert.AreEqual(new DateTime(expectedYear, expectedMonth, expectedDay), easter);            
        }

        [Test]
        [TestCase(2021, 2021, 2, 16)]
        [TestCase(2020, 2020, 2, 25)]
        public void TestCarnival(int year, int expectedYear, int expectedMonth, int expectedDay)
        {
            var carnival = DateExtensions.DateExtension.GetBrazilianCarnival(year);

            Assert.AreEqual(new DateTime(expectedYear, expectedMonth, expectedDay), carnival);
        }

        [Test]
        [TestCase(2021, 2021, 6, 3)]
        [TestCase(2020, 2020, 6, 11)]
        public void TestCorpusChristi(int year, int expectedYear, int expectedMonth, int expectedDay)
        {
            var corpusChristi = DateExtensions.DateExtension.GetCorpusChristi(year);

            Assert.AreEqual(new DateTime(expectedYear, expectedMonth, expectedDay), corpusChristi);
        }


        [Test]
        [TestCase(2021, 2021, 4, 2)]
        [TestCase(2020, 2020, 4, 10)]
        public void TestGoodFriday(int year, int expectedYear, int expectedMonth, int expectedDay)
        {
            var goodFriday = DateExtensions.DateExtension.GetGoodFriday(year);

            Assert.AreEqual(new DateTime(expectedYear, expectedMonth, expectedDay), goodFriday);
        }


        [Test]
        [TestCase(2021, 2021, 4, 5)]
        [TestCase(2020, 2020, 4, 13)]
        public void TestEasterMonday(int year, int expectedYear, int expectedMonth, int expectedDay)
        {
            var easterMonday = DateExtensions.DateExtension.GetEasterMonday(year);

            Assert.AreEqual(new DateTime(expectedYear, expectedMonth, expectedDay), easterMonday);
        }

    }
}
