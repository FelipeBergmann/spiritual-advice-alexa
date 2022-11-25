using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;
using SpiritualAdviceAlexaSkill.Infrastructure.Provider;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana;

public class ArcanaCalculator : IArcanaCalculator
{
    private readonly IDateProvider _dateProvider;

    public ArcanaCalculator(IDateProvider dateProvider)
    {
        _dateProvider = dateProvider;
    }

    private ArcanaDailyCalculatorResult CalculateArcanum(DateOnly date)
    {
        string today = date.ToString("ddMMyyyy");
        int squashedResult = SquashNumeric(today, 22);
        Arcanum arcanum = (Arcanum)squashedResult;

        return new ArcanaDailyCalculatorResult(arcanum, date);
    }

    private int SquashNumeric(string value, int resultLimit, byte digitLimit = 2)
    {
        int accumulator = 0;
        for (int i = 0; i < value.Length; i++)
        {
            accumulator += int.Parse(value[i].ToString());
        }

        if (accumulator > resultLimit || accumulator.ToString().Length > digitLimit)
            accumulator = SquashNumeric(accumulator.ToString(), resultLimit, 1);

        return accumulator;
    }

    public ArcanaDailyCalculatorResult TodaysArcanum() => CalculateArcanum(DateOnly.FromDateTime(_dateProvider.GetUtcNow()));
}
