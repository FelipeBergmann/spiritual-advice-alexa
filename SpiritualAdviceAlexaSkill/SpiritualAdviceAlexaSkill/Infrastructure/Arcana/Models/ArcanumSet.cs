using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Factories;
using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
public class ArcanumSet
{
    private static readonly Arcane[] Arcanums = new Arcane[]
    {
        ArcaneFactory.CreateArcane(Arcanum.The_Magician, $"{Arcanum.The_Magician}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Popess, $"{Arcanum.The_Popess}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Empress, $"{Arcanum.The_Empress}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Emperor, $"{Arcanum.The_Emperor}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Pope, $"{Arcanum.The_Pope}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Lovers, $"{Arcanum.The_Lovers}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Chariot, $"{Arcanum.The_Chariot}"),
        ArcaneFactory.CreateArcane(Arcanum.Justice, $"{Arcanum.Justice}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Hermit, $"{Arcanum.The_Hermit}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Wheel_of_Fortune, $"{Arcanum.The_Wheel_of_Fortune}"),
        ArcaneFactory.CreateArcane(Arcanum.Strength, $"{Arcanum.Strength}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Hanged_Man, $"{Arcanum.The_Hanged_Man}"),
        ArcaneFactory.CreateArcane(Arcanum.Death, $"{Arcanum.Death}"),
        ArcaneFactory.CreateArcane(Arcanum.Temperance, $"{Arcanum.Temperance}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Devil, $"{Arcanum.The_Devil}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Tower, $"{Arcanum.The_Tower}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Star, $"{Arcanum.The_Star}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Moon, $"{Arcanum.The_Moon}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Sun, $"{Arcanum.The_Sun}"),
        ArcaneFactory.CreateArcane(Arcanum.Judgement, $"{Arcanum.Judgement}"),
        ArcaneFactory.CreateArcane(Arcanum.The_World, $"{Arcanum.The_World}"),
        ArcaneFactory.CreateArcane(Arcanum.The_Fool, $"{Arcanum.The_Fool}")
    };

    public static Arcane GetByHouse(byte house) => Arcanums.Where(a => a.HousePosition == house).Single();
    public static int Count() => Arcanums.Length;
}
