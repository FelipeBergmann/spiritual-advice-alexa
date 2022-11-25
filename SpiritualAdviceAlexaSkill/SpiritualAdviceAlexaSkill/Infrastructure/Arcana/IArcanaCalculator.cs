using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana;

internal interface IArcanaCalculator
{
    ArcanaDailyCalculatorResult TodaysArcanum();
}
