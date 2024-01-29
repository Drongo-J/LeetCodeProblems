using Leetcodes.Problems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Leetcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            #region 1.Add Two Numbers
            //int[] nums = new int[] { 3, 2, 4 };
            //int target = 6;
            //var result = Problem1.TwoSum(nums, target);
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

            //var node = Problem2.AddTwoNumbers(l0, l10);
            //while (node != null)
            //{
            //    Console.Write(node.val);
            //    node = node.next;
            //}
            //Console.WriteLine();
            #endregion

            #region 3. Longest Substring Without Repeating Characters
            //Console.WriteLine(Problem3.LengthOfLongestSubstring("pwwkew"));
            #endregion

            #region 4. Median of Two Sorted Arrays
            //var nums1 = new int[] { 1, 2 };
            //var nums2 = new int[] { 3, 4 };

            //var result = Problem4.FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine(result);
            #endregion

            #region 5. Longest Palindromic Substring
            //Console.WriteLine($"Longest Palindrome |{Problem5.LongestPalindrome("abb")}|");
            #endregion

            #region 6. Zigzag Conversion
            //var s = "PAYPALISHIRING";
            //var numRows = 4;
            //var output = Problem6.Convert(s, numRows);
            //Console.WriteLine($"Output: {output}");
            //var answer = "PINALSIGYAHRPI";
            //Console.WriteLine($"{output} == {answer} : {output == answer}"); 
            #endregion

            #region 7. Reverse Integer
            var x = 123;
            var output = Problem7.Reverse(x);
            Console.WriteLine($"Input: {x}");
            Console.WriteLine($"Output: {output}");
            #endregion

            stopwatch.Stop();
            Console.WriteLine($"Elapased time : {stopwatch.Elapsed.TotalSeconds} seconds");
            Console.Read();
        }
    }
}
