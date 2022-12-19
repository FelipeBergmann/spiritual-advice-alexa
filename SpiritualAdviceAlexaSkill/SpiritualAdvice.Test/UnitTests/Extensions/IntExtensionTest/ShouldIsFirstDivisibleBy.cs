using Xunit;

namespace SpiritualAdvice.Test.UnitTests.Extensions.IntExtensionTest
{
    public class ShouldIsFirstDivisibleBy
    {
        [Trait("Category", "unit")]
        [Theory(DisplayName = "IntExtension - ShouldIsFirstDivisibleBy")]
        [InlineData(10, 3, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(8, 3, 2)]
        [InlineData(7, 3, 1)]
        [InlineData(6, 3, 3)]
        [InlineData(5, 3, 1)]
        [InlineData(4, 3, 2)]
        [InlineData(3, 3, 3)]
        [InlineData(2, 3, 2)]
        [InlineData(1, 3, 1)]
        public void ShouldIsFirstDivisibleByDefaultTheory(int number, int divider, int expectedResult)
        {
            //arrange
            //act
            var result = IntExtensionWrapper.IsFirstDivisibleBy(number, divider);

            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}
