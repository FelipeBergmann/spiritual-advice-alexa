using Xunit;

namespace SpiritualAdvice.Test.UnitTests.Extensions.IntExtensionTest
{
    public class ShouldIsDivisibleBy
    {
        [Trait("Category", "unit")]
        [Theory(DisplayName = "IntExtension - Should Divisible By")]
        [InlineData(10, 3, false)]
        [InlineData(10, 20, false)]
        [InlineData(10, 0, false)]
        [InlineData(0, 1, true)]
        [InlineData(10, 5, true)]
        [InlineData(10, 1, true)]
        [InlineData(1, 1, true)]
        public void ShouldIsDivisibleByTheory(int number, int divisor, bool expectedResult)
        {
            //arrange
            //act
            var result = IntExtensionWrapper.IsDivisibleBy(number, divisor);

            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}
