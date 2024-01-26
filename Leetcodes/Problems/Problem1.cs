namespace Leetcodes.Problems
{
    public class Problem1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indexes = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == target && i != k)
                    {
                        indexes[0] = (i);
                        indexes[1] = (k);
                        return indexes;
                    }
                }
            }
            return null;
        }
    }
}
