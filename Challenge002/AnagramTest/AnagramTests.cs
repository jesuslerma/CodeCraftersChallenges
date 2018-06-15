namespace AnagramTest
{
    using Xunit;
    using Shouldly;
    using Anagram;

    public class AnagramTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("R", "r")]
        [InlineData("aruba", null)]
        [InlineData("", "aruba")]
        [InlineData("Re", "rE")]
        [InlineData("ale", "alu")]
        [InlineData("mexico", "coxiee")]
        [InlineData("uruguay", "aragoyu")]
        [InlineData("clown", "lowny")]
        [InlineData("several", "laravel")]
        [InlineData("SameWord", "sameword")]
        public void ShouldWordsNotBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(false);
        }

        [Theory]
        [InlineData("RE", "er")]
        [InlineData("ale", "eal")]
        [InlineData("mexico", "ximeco")]
        [InlineData("uruguay", "yaruguu")]
        [InlineData("clown", "ownlc")]
        [InlineData("several", "lareves")]
        [InlineData("NotSameWord", "SameWordNot")]
        public void ShouldWordsBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(true);
        }
    }
}
