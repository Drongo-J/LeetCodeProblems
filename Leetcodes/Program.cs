using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodes
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            #region 1.Add Two Numbers
            //int[] nums = new int[] { 3, 2, 4 };
            //int target = 6;
            //var result = TwoSum(nums, target);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2.Add Two Numbers
            //var l3 = new ListNode(3);
            //var l2 = new ListNode(4, l3);
            //var l1 = new ListNode(2, l2);

            //var l6 = new ListNode(4);
            //var l5 = new ListNode(6, l6);
            //var l4 = new ListNode(5, l5);
            //var l9 = new ListNode(9, null);
            //var l8 = new ListNode(9, l9);
            //var l7 = new ListNode(9, l8);
            //var l6 = new ListNode(9, l7);
            //var l5 = new ListNode(9, l6);
            //var l4 = new ListNode(9, l5);
            //var l3 = new ListNode(9, l4);
            //var l2 = new ListNode(9, l3);
            //var l1 = new ListNode(9, l2);
            //var l0 = new ListNode(1, l1);

            //var l10 = new ListNode(9, null);

            //var node = AddTwoNumbers(l0, l10);
            //while (node != null)
            //{
            //    Console.Write(node.val);
            //    node = node.next;
            //}
            //Console.WriteLine();
            #endregion

            #region 3. Longest Substring Without Repeating Characters
            //Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            #endregion

            #region 4. Median of Two Sorted Arrays
            //var nums1 = new int[] { 1, 2 };
            //var nums2 = new int[] { 3, 4 };

            //var result = FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine(result);
            #endregion

            #region 5. Longest Palindromic Substring
            Console.WriteLine($"Longest Palindrome |{LongestPalindrome("abb")}|");
            #endregion
            
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time : {stopwatch.Elapsed.TotalSeconds} seconds");
            Console.Read();
        }

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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = GetNumberFromListNode(l1);
            var num2 = GetNumberFromListNode(l2);
            BigInteger sum = BigInteger.Parse(num1) + BigInteger.Parse(num2);
            //sum = ReverseNumber(sum);
            ListNode next = null;
            for (int i = 0; i < sum.ToString().Length; i++)
            {
                var ln = new ListNode(int.Parse(sum.ToString()[i].ToString()), next);
                next = ln;
            }

            return next;
        }

        public static string GetNumberFromListNode(ListNode l)
        {
            var str = "";
            while (l != null)
            {
                str += l.val;
                l = l.next;
            }
            return ReverseNumber(str);

        }

        public static string ReverseNumber(string str)
        {
            string reversed = string.Empty;
            for (int x = str.Length - 1; x >= 0; x--)
            {
                reversed += str[x];
            }
            return reversed;
        }

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
