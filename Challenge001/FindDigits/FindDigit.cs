namespace FindDigits
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FindDigit
    {
        public int[] FindDigits(int[] numbers)
        {
            if (numbers == null) return new int[0];

            return numbers.Select(n => n.ToString().Replace("-", "").Count(d => d != '0' && n % Int32.Parse(d.ToString()) == 0)).ToArray();
        }
    }
}
