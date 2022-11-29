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
        byte squashedResult = SquashNumeric(today, ArcanumSet.Count());
        Arcane arcane = ArcanumSet.GetByHouse(squashedResult);

        return new ArcanaDailyCalculatorResult(arcane.Arcanum, date, arcane.GetSpeech());
    }

    private byte SquashNumeric(string value, int resultLimit, byte digitLimit = 2)
    {
        byte accumulator = 0;
        for (byte i = 0; i < value.Length; i++)
        {
            accumulator += byte.Parse(value[i].ToString());
        }

        if (accumulator > resultLimit || accumulator.ToString().Length > digitLimit)
            accumulator = SquashNumeric(accumulator.ToString(), resultLimit, 1);

        return accumulator;
    }

    public ArcanaDailyCalculatorResult TodaysArcanum() => CalculateArcanum(DateOnly.FromDateTime(_dateProvider.GetUtcNow()));
}
