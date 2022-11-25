namespace SpiritualAdviceAlexaSkill.Infrastructure.Provider;

public class DateProvider : IDateProvider
{
    public DateTime GetUtcNow() => DateTime.UtcNow;
}
