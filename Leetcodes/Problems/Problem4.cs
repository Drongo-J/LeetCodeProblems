using System.Collections.Generic;
using System.Linq;

namespace Leetcodes.Problems
{
    public class Problem4
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var newList = new List<int>();
            newList.AddRange(nums1);
            newList.AddRange(nums2);
            newList.Sort();
            if (newList.Count % 2 == 0)
            {
                var r1 = newList.ElementAt(newList.Count / 2 - 1);
                var r2 = newList.ElementAt(newList.Count / 2);
                return double.Parse((r1 + r2).ToString()) / 2;
            }
            else
            {
                int index = newList.Count / 2;
                return newList.ElementAt(index);
            }
        }   
    }
}
