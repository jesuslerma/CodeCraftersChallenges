namespace FindDigitsTest
{
    using Shouldly;
    using Xunit;
    using FindDigits;

    public class FindDigitTests
    {
        [Fact]
        public void ShouldFindDigits()
        {
            var findDigit = new FindDigit();

            var output = findDigit.FindDigits(new int[] { 1012, 12, 111 });

            output.Length.ShouldBe(3);
            output[0].ShouldBe(3);
            output[1].ShouldBe(2);
            output[2].ShouldBe(3);
        }

        [Fact]
        public void ShouldFindDigitsUsingNegatives()
        {
            var findDigit = new FindDigit();

            var output = findDigit.FindDigits(new int[] { -1012, -12, -111 });

            output.Length.ShouldBe(3);
            output[0].ShouldBe(3);
            output[1].ShouldBe(2);
            output[2].ShouldBe(3);
        }

        [Fact]
        public void ShouldFindDigitReturnZero()
        {
            var findDigit = new FindDigit();

            var output = findDigit.FindDigits(new int[] { 0, -0 });

            output.Length.ShouldBe(2);
            output[0].ShouldBe(0);
            output[1].ShouldBe(0);
        }

        [Fact]
        public void ShouldFindDigitsResolveBadInput()
        {
            var findDigit = new FindDigit();

            findDigit.FindDigits(new int[] { }).Length.ShouldBe(0);
            findDigit.FindDigits(null).Length.ShouldBe(0);
        }
    }
}
