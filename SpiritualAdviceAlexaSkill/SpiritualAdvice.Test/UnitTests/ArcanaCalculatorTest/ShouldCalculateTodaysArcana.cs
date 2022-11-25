using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SpiritualAdvice.Test.UnitTests.ArcanaCalculatorTest;

public partial class ArcanaUnitTest
{
    [Trait("Category", "unit")]
    [Theory(DisplayName = "ArcanaCalculator - TodaysArcanum - Should calculate today's arcane correctly using the provided date")]
    [InlineData("09/29/2024", Arcanum.The_Magician)]
    [InlineData("09/29/2025", Arcanum.The_Popess)]
    [InlineData("09/29/2026", Arcanum.The_Empress)]
    [InlineData("09/29/2027", Arcanum.The_Emperor)]
    [InlineData("06/29/2022", Arcanum.The_Pope)]
    [InlineData("07/29/2022", Arcanum.The_Lovers)]
    [InlineData("08/29/2022", Arcanum.The_Chariot)]
    [InlineData("01/01/2022", Arcanum.Justice)]
    [InlineData("01/02/2022", Arcanum.The_Hermit)]
    [InlineData("01/03/2022", Arcanum.The_Wheel_of_Fortune)]
    [InlineData("01/04/2022", Arcanum.Strength)]
    [InlineData("01/05/2022", Arcanum.The_Hanged_Man)]
    [InlineData("01/06/2022", Arcanum.Death)]
    [InlineData("01/07/2022", Arcanum.Temperance)]
    [InlineData("01/08/2022", Arcanum.The_Devil)]
    [InlineData("01/09/2022", Arcanum.The_Tower)]
    [InlineData("01/19/2022", Arcanum.The_Star)]
    [InlineData("01/29/2022", Arcanum.The_Moon)]
    [InlineData("03/19/2022", Arcanum.The_Sun)]
    [InlineData("03/29/2022", Arcanum.Judgement)]
    [InlineData("04/29/2022", Arcanum.The_World)]
    [InlineData("05/29/2022", Arcanum.The_Fool)]

    public void ShouldCalculateTodaysArcaneCorrectly(DateTime fakeDate, Arcanum arcanum)
    {
        //arrange
        _mockDateProvider.Setup(x => x.GetUtcNow()).Returns(fakeDate);

        //act
        var result = _arcanaCalculator.TodaysArcanum();

        //assert
        Assert.Equal(arcanum, result.Arcanum);
    }

    [Trait("Category", "helpers")]
    [Fact(DisplayName = "Should find a date for each Arcanum in 10 years")]
    public void CheckTenYearsPossibility()
    {
        var calculate = (int year) =>
        {
            var startDate = new DateTime(year, 1, 1);
            var accumulatedResult = new List<GroupedArcanum>();

            for (int i = 0; i < 365; i++)
            {
                var currentDate = startDate.AddDays(i);
                _mockDateProvider.Setup(x => x.GetUtcNow()).Returns(currentDate);

                accumulatedResult.Add(new GroupedArcanum()
                {
                    Arcanum = _arcanaCalculator.TodaysArcanum().Arcanum,
                    AppearsAt = DateOnly.FromDateTime(currentDate)
                });
            }

            return accumulatedResult;
        };

        List<GroupedArcanum> result = new();

        for (int i = 0; i < 10; i++)
        {
            var tempResult = calculate(2022 + i);
            foreach (var item in tempResult)
            {
                result.Add(new GroupedArcanum()
                {
                    Arcanum = item.Arcanum,
                    AppearsAt = item.AppearsAt
                });
            }
        }

        var groupedResult = result.GroupBy(x => x.Arcanum).Select(x => x.FirstOrDefault()).OrderBy(x => x.Arcanum);

        Assert.Equal(22, groupedResult.Count());
    }

    public class GroupedArcanum
    {
        public Arcanum Arcanum { get; set; }
        public DateOnly AppearsAt { get; set; }

        public override string? ToString()
        {
            return $"{Arcanum} - {AppearsAt}";
        }
    }
}

