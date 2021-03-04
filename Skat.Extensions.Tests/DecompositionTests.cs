using NUnit.Framework;
using System.Collections.Generic;

namespace Skat.Extensions.Tests
{
    public class DecompositionTests
    {
        public class CheckDecomposition
        {
            public CheckDecomposition()
            {
                Decomposed = new List<long>();
            }

            public long Number { get; set; }
            public List<long> Decomposed { get; set; }
        }

        public static List<CheckDecomposition> testSources;

        [SetUp]
        public void Setup()
        {
            testSources = new List<CheckDecomposition>();
            testSources.Add(new CheckDecomposition
            {
                Number = 10,
                Decomposed = new List<long> { 2, 5 }
            });

            testSources.Add(new CheckDecomposition
            {
                Number = 80,
                Decomposed = new List<long> { 2, 2, 2, 2, 5 }
            });

            testSources.Add(new CheckDecomposition
            {
                Number = 793,
                Decomposed = new List<long> { 13, 61 }
            });

        }

        [Test]
        public void TestDecomposition()
        {
            foreach(var tc in testSources)
            {
                List<long> check = tc.Number.Decompose();
                Assert.AreEqual(check.Count, tc.Decomposed.Count);
                for(int i = 0; i < tc.Decomposed.Count; i++)
                {
                    Assert.AreEqual(tc.Decomposed[i], check[i]);
                }
            }
        }       
    }
}
