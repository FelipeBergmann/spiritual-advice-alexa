using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;

public class ArcanaDailyCalculatorResult
{
    public ArcanaDailyCalculatorResult(Arcanum arcanum, DateOnly evaluatedDate)
    {
        Arcanum = arcanum;
        EvaluatedDate = evaluatedDate;
    }

    public Arcanum Arcanum { get; private set; }
    public DateOnly EvaluatedDate { get; private set; }
}
