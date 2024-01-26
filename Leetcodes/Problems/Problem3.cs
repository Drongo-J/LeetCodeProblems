using System.Linq;

namespace Leetcodes.Problems
{
    public class Problem3
    {
        public static int LengthOfLongestSubstring(string word)
        {
            string substring = string.Empty;
            int longestLength = 0;
            for (int y = 0; y < word.Length; y++)
            {
                for (int x = y; x < word.Length; x++)
                {
                    if (substring.Contains(word[x]))
                        break;
                    substring += word[x];
                }
                var lengthOfWord = substring.Length;
                if (lengthOfWord > longestLength)
                {
                    longestLength = lengthOfWord;
                }
                substring = string.Empty;
            }
            return longestLength;
        }
    }
}
