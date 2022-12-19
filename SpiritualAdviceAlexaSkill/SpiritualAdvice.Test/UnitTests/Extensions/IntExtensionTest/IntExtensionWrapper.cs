using SpiritualAdviceAlexaSkill.Infrastructure.Extension;
using System;

namespace SpiritualAdvice.Test.UnitTests.Extensions.IntExtensionTest
{
    internal class IntExtensionWrapper
    {
        internal static bool IsDivisibleBy(int number, int divider) => number.IsDivisibleBy(divider);
        internal static int IsFirstDivisibleBy(int number, int divider) => number.IsFirstDivisibleBy(divider);
        internal static int IsFirstDivisibleBy(int number, int divider, Func<int, int> changeDivider) => number.IsFirstDivisibleBy(divider, changeDivider);
    }
}
