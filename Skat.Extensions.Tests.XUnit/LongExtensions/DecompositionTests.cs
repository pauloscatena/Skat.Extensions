using Skat.Extensions.LongExtensions;

namespace Skat.Extensions.Tests.XUnit.LongExtensions
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

        private static List<CheckDecomposition> testSources;
        
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

        [Fact]
        public void TestDecomposition()
        {
            Setup();
            foreach(var tc in testSources)
            {
                List<long> check = tc.Number.CanonicalDecompose();
                Assert.Equal(check.Count, tc.Decomposed.Count);
                for(int i = 0; i < tc.Decomposed.Count; i++)
                {
                    Assert.Equal(tc.Decomposed[i], check[i]);
                }
            }
        }       
    }
}
