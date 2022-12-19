using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;

public class ArcanaDailyCalculatorResult
{
    public ArcanaDailyCalculatorResult(Arcanum arcanum, DateOnly evaluatedDate, string audioFileName)
    {
        Arcanum = arcanum;
        EvaluatedDate = evaluatedDate;
        AudioFileName = audioFileName;
    }

    public Arcanum Arcanum { get; private set; }
    public DateOnly EvaluatedDate { get; private set; }
    public string AudioFileName { get; private set; }
}
