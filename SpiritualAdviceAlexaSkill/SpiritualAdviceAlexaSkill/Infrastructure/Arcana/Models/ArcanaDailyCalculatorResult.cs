using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;

public class ArcanaDailyCalculatorResult
{
    public ArcanaDailyCalculatorResult(Arcanum arcanum, DateOnly evaluatedDate, string speech)
    {
        Arcanum = arcanum;
        EvaluatedDate = evaluatedDate;
        Speech = speech;
    }

    public Arcanum Arcanum { get; private set; }
    public DateOnly EvaluatedDate { get; private set; }
    public string Speech { get; set; }
}
