using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
public class Arcane
{
    public Arcane(Arcanum arcanum, byte housePosition, string fileName, int version)
    {
        Arcanum = arcanum;
        HousePosition = housePosition;
        FileName = fileName;
        Version = version;
    }

    public Arcanum Arcanum { get; set; }
    public byte HousePosition { get; set; }
    public string FileName { get; set; }
    public int Version { get; set; }
    public List<string> Speaches { get; set; }
    public string GetSpeech() => Speaches.Single();
    public string AudioFileName() => $"{FileName}_{Version}";
}
