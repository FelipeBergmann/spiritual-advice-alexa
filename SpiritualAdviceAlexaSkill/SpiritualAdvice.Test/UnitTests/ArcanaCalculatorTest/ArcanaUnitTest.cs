using Moq;
using SpiritualAdviceAlexaSkill.Infrastructure.Arcana;
using SpiritualAdviceAlexaSkill.Infrastructure.Provider;

namespace SpiritualAdvice.Test.UnitTests.ArcanaCalculatorTest;

public partial class ArcanaUnitTest
{
    protected readonly ArcanaCalculator _arcanaCalculator;
    protected readonly Mock<IDateProvider> _mockDateProvider;

    public ArcanaUnitTest()
    {
        _mockDateProvider = new Mock<IDateProvider>();
        _arcanaCalculator = new(_mockDateProvider.Object);
    }
}