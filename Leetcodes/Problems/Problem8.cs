using System.Linq;

namespace Leetcodes.Problems
{
    public class Problem8
    {
        public static int MyAtoi(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int index = 0;
            while (index < s.Length && s[index] == ' ')
                index++;

            if (index == s.Length)
                return 0;

            bool isNegative = false;
            if (s[index] == '+' || s[index] == '-')
            {
                isNegative = (s[index] == '-');
                index++;
            }

            int result = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {
                int digit = s[index] - '0';

                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    return isNegative ? int.MinValue : int.MaxValue;

                result = result * 10 + digit;
                index++;
            }

            return isNegative ? -result : result;
        }
    }
}
