using System.Linq;

namespace Leetcodes.Problems
{
    public class Problem5
    {
        public static string LongestPalindrome(string s)
        {
            if (IsPalindrome(s))
            {
                return s;
            }

            var longestSubstring = string.Empty;

            return longestSubstring;
        }

        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
