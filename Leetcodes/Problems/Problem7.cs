namespace Leetcodes.Problems
{
    public class Problem7
    {
        public static int Reverse(int x)
        {
            if (x == 0) return 0;

            bool returnNegative = false;
            if (x < 0)
            {
                returnNegative = true;
            }

            var number = x.ToString().TrimStart('-').TrimEnd('0');
            var newNumber = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                newNumber += number[i];
            }

            int result = 0;
            try
            {
                result = int.Parse(newNumber);
            }
            catch (System.Exception)
            {
                return 0;
            }

            if (returnNegative)
            {
                return -result;
            }
            return result;
        }
    }
}
