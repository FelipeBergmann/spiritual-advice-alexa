using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Factories;
public static class ArcaneFactory
{
    public static Arcane CreateArcane(Arcanum arcanum, params string[] speach)
    {
        return new Arcane(arcanum, (byte)arcanum, new List<string>()
        {
            "01-Mage-advice-01-converted.mp3"
        });
    }
}
