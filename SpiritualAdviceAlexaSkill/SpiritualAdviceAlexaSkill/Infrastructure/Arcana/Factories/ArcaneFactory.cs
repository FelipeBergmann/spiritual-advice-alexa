using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Factories;
public static class ArcaneFactory
{
    public static Arcane CreateArcane(Arcanum arcanum, string fileName, params string[] speach)
    {
        var arcane = new Arcane(arcanum, (byte)arcanum, fileName, 0);

        if(speach?.Length > 0)
        {
            arcane.Speaches.AddRange(speach);
        }

        return arcane;        
    }
}
