namespace SpiritualAdviceAlexaSkill.Infrastructure.Extension;

public static class IntExtension
{
    public static bool IsDivisibleBy(this int number, int divider)
    {
        if (divider == 0) return false;

        return number % divider == 0;
    }

    public static int IsFirstDivisibleBy(this int number, int divider) => IsFirstDivisibleBy(number, divider, (divider) => --divider);

    public static int IsFirstDivisibleBy(this int number, int divider, Func<int, int> changeDivider)
    {
        if (divider >= number) return number;

        bool isDivisible = false;

        while (!isDivisible)
        {
            isDivisible = number % divider == 0;

            divider = isDivisible ? divider : changeDivider(divider);
        }

        return divider;
    }
}
