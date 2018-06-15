namespace AnagramApp
{
    using System;
    using Shouldly;
    using Anagram;

    public class Program
    {
        public static void Main(string[] args)
        {
            ValidateArgs(args);
            var anagramText = new Anagram().IsAnagram(args[0], args[1]) ? "are" : "are not";

            Console.WriteLine($"{args[0]} and {args[1]} {anagramText} anagrams.");
        }

        private static void ValidateArgs(string[] args)
        {
            args.Length.ShouldBe(2);
        }
    }
}
