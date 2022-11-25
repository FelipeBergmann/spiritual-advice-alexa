using System;
using Xunit;

namespace SpiritualAdvice.Test.UnitTests.ArcanaCalculatorTest;

public partial class ArcanaUnitTest
{
    [Trait("Category", "unit")]
    [Fact(DisplayName = "ArcanaCalculator - TodaysArcanum - Should calculate today's arcane using the current utc date time")]
    public void ShouldProvideTheCurrentDateTimeUTC()
    {
        //arrange
        DateOnly expectedDate = DateOnly.FromDateTime(DateTime.UtcNow);
        _mockDateProvider.Setup(p => p.GetUtcNow()).Returns(DateTime.UtcNow);

        //act
        var result = _arcanaCalculator.TodaysArcanum();

        //assert
        Assert.Equal(expectedDate, result.EvaluatedDate);
    }
}
