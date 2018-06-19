namespace FindDigitsApp
{
    using System;
    using Shouldly;
    using FindDigits;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = ValidateArgs(args);
            
            foreach (var divisors in new FindDigit().FindDigits(numbers))
            {
                Console.WriteLine(divisors);
            }
        }

        private static int[] ValidateArgs(string[] args)
        {
            args.Length.ShouldBeGreaterThan(0);

            var numbers = new int[args.Length];

            for (var i = 0; i < args.Length; i++)
            {
                int number;

                Int32.TryParse(args[i], out number).ShouldBe(true);
                numbers[i] = number;
            }

            return numbers;
        }
    }
}
