using Skat.Extensions.DateExtensions;
namespace Skat.Extensions.Tests.XUnit.DateExtensions;

public class DateExtensionsTests
{
    [Theory]
    [InlineData(2021, 2021, 4, 4)]
    [InlineData(2020, 2020, 4, 12)]
    [InlineData(2019, 2019, 4, 21)]
    public void TheoryEaster(int year, int expectedYear, int expectedMonth, int expectedDay)
    {
        var easter = DateExtension.GetEaster(year);

        Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), easter);
    }

    [Theory]
    [InlineData(2021, 2021, 2, 16)]
    [InlineData(2020, 2020, 2, 25)]
    public void TheoryCarnival(int year, int expectedYear, int expectedMonth, int expectedDay)
    {
        var carnival = DateExtension.GetBrazilianCarnival(year);

        Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), carnival);
    }

    [Theory]
    [InlineData(2021, 2021, 6, 3)]
    [InlineData(2020, 2020, 6, 11)]
    public void TheoryCorpusChristi(int year, int expectedYear, int expectedMonth, int expectedDay)
    {
        var corpusChristi = DateExtension.GetCorpusChristi(year);

        Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), corpusChristi);
    }


    [Theory]
    [InlineData(2021, 2021, 4, 2)]
    [InlineData(2020, 2020, 4, 10)]
    public void TheoryGoodFriday(int year, int expectedYear, int expectedMonth, int expectedDay)
    {
        var goodFriday = DateExtension.GetGoodFriday(year);

        Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), goodFriday);
    }


    [Theory]
    [InlineData(2021, 2021, 4, 5)]
    [InlineData(2020, 2020, 4, 13)]
    public void TheoryEasterMonday(int year, int expectedYear, int expectedMonth, int expectedDay)
    {
        var easterMonday = DateExtension.GetEasterMonday(year);

        Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), easterMonday);
    }

}