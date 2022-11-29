using SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Factories;
using SpiritualAdviceAlexaSkill.Infrastructure.Enumeration;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Arcana.Models;
public class ArcanumSet
{
    private static readonly Arcane[] Arcanums = new Arcane[]
    {
        ArcaneFactory.CreateArcane(Arcanum.The_Magician, "Este é o mago!"),
        ArcaneFactory.CreateArcane(Arcanum.The_Popess, "Esta é a sacerdotisa!"),
        ArcaneFactory.CreateArcane(Arcanum.The_Empress, "Esta é a imperatriz!"),
        ArcaneFactory.CreateArcane(Arcanum.The_Emperor, "Este é o imperador!"),
        ArcaneFactory.CreateArcane(Arcanum.The_Pope, "Este é o papa"),
        ArcaneFactory.CreateArcane(Arcanum.The_Lovers, "Estes são os amantes"),
        ArcaneFactory.CreateArcane(Arcanum.The_Chariot, "Esta é o carro"),
        ArcaneFactory.CreateArcane(Arcanum.Justice, "Esta é a justiça"),
        ArcaneFactory.CreateArcane(Arcanum.The_Hermit, "Este é o heremita"),
        ArcaneFactory.CreateArcane(Arcanum.The_Wheel_of_Fortune, "Esta é a roda da fortuna"),
        ArcaneFactory.CreateArcane(Arcanum.Strength, "Esta é a força"),
        ArcaneFactory.CreateArcane(Arcanum.The_Hanged_Man, "Este é o enforcado"),
        ArcaneFactory.CreateArcane(Arcanum.Death, "Esta é a morte"),
        ArcaneFactory.CreateArcane(Arcanum.Temperance, "Esta é a temperança"),
        ArcaneFactory.CreateArcane(Arcanum.The_Devil, "Este é o diabo"),
        ArcaneFactory.CreateArcane(Arcanum.The_Tower, "Esta é a torre"),
        ArcaneFactory.CreateArcane(Arcanum.The_Star, "Esta é a estrela"),
        ArcaneFactory.CreateArcane(Arcanum.The_Moon, "Esta é a lua"),
        ArcaneFactory.CreateArcane(Arcanum.The_Sun, "Este é o sol"),
        ArcaneFactory.CreateArcane(Arcanum.Judgement, "Este é o julgamento"),
        ArcaneFactory.CreateArcane(Arcanum.The_World, "Este é o mundo"),
        ArcaneFactory.CreateArcane(Arcanum.The_Fool, "Este é o louco")
    };

    public static Arcane GetByHouse(byte house) => Arcanums.Where(a => a.HousePosition == house).Single();
    public static int Count() => Arcanums.Length;
    
}
