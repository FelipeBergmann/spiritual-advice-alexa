using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
public class Arcane
{
    public Arcane(Arcanum arcanum, byte housePosition, List<string> speaches)
    {
        Arcanum = arcanum;
        HousePosition = housePosition;
        Speaches = speaches;
    }

    public Arcanum Arcanum { get; set; }
    public byte HousePosition { get; set; }
    private List<string> Speaches { get; set; }
    public string GetSpeech() => Speaches.Single();
}
