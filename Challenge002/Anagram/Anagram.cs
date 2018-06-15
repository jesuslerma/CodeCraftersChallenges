namespace Anagram
{
    public class Anagram
    {
        public bool IsAnagram(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;
            if (a.Length != b.Length || a.Length < 2) return false;

            var differentWord = false;
            var word = a.ToLowerInvariant().ToCharArray();
            var test = b.ToLowerInvariant().ToCharArray();

            for (var i = 0; i < word.Length; i++)
            {
                var j = 0;
                for (; j < test.Length; j++)
                {
                    if (word[i] == test[j])
                    {
                        test[j] = (char)0;
                        if (i != j) differentWord = true;
                        break;
                    }
                }
                if (j == test.Length) return false;
            }

            return differentWord;
        }
    }
}
