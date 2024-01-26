using System.Numerics;

namespace Leetcodes.Problems
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

    public class Problem2
    {
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
    }
}
