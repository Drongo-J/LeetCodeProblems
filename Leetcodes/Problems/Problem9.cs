namespace Leetcodes.Problems
{
    public class Problem9
    {
        public static bool IsPalindrome(int x)
        {
            int left = 0;
            var stringX = x.ToString();
            int right = stringX.Length - 1;

            while (left < right)
            {
                if (stringX[left] != stringX[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
