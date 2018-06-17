namespace Anagram
{
    public class Anagram
    {
        private static readonly string[] _diacriticMap = 
        {
            "aáàäâ",
            "eéèëê",
            "iíìïî",
            "oóòöô",
            "uúùüû",
            "cç",
            "sß",
            "yÿ"
        };

        private static readonly string[] _removeCharacters =
        {
            " ",
            ",",
            "."
        };

        public bool IsAnagram(string a, string b)
        {
            var differentWord = false;

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;

            foreach (var character in _removeCharacters)
            {
                a = a.Replace(character, "");
                b = b.Replace(character, "");
            }
            var word = a.ToLowerInvariant().ToCharArray();
            var test = b.ToLowerInvariant().ToCharArray();
            
            RemoveDiacricts(word);
            RemoveDiacricts(test);

            if (word.Length != test.Length || word.Length < 2) return false;

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

        private static void RemoveDiacricts(char[] text)
        {
            for (var i = 0; i < text.Length; i++)
            {
                for (var j = 0; j < _diacriticMap.Length; j++)
                {
                    for (var k = 1; k < _diacriticMap[j].Length; k++)
                    {
                        if (text[i] == _diacriticMap[j][k])
                        {
                            text[i] = _diacriticMap[j][0];
                        }
                    }
                }
            }
        }
    }
}