using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Timers;

namespace Leetcodes.Problems
{
    public class Problem10
    {
        public static bool IsMatch(string s, string p)
        {
            var pattern = GetPattern(p);
            PrintPattern(pattern);
            var patternIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (patternIndex == pattern.Count) return false;
                var ch = s[i];
                var el = pattern.ElementAt(patternIndex);
                var count = el.Value;

                if (el.Key is '.')
                {
                    char nextKey = ' ';
                    if (patternIndex + 1 < pattern.Count)
                    {
                        nextKey = pattern.ElementAt(patternIndex + 1).Key;
                    }

                    while (i < s.Length && s[i] != nextKey)
                    {
                        i++;
                    }
                    i--;
                }
                else
                {
                    if (double.IsInfinity(count))
                    {
                        while (i < s.Length && ch == s[i])
                        {
                            i++;
                        }
                        i--;
                    }
                    else
                    {
                        for (int j = 0; j < count; j++)
                        {
                            if (ch != s[i + j])
                                return false;
                        }
                        i += (int)count;
                    }
                }
                patternIndex++;
            }
            return true;
        }

        private static List<KeyValuePair<char, double>> GetPattern(string p)
        {
            var pattern = new List<KeyValuePair<char, double>>();
            double counter = 0;
            for (int i = 0; i < p.Length; i++)
            {
                var el = p[i];
                if (el is '*') continue;

                if (i + 1 < p.Length)
                {
                    var nextChar = p[i + 1];
                    if (nextChar == el)
                        counter++;
                    else if (nextChar == '*')
                    {
                        counter = double.PositiveInfinity;
                        pattern.Add(new KeyValuePair<char, double>(el, counter));
                        counter = 0;
                    }
                    else
                    {
                        counter++;
                        pattern.Add(new KeyValuePair<char, double>(el, counter));
                        counter = 0;
                    }
                }
                else
                {
                    counter++;
                    pattern.Add(new KeyValuePair<char, double>(el, counter));
                    counter = 0;
                }
            }

            return pattern;
        }

        private static void PrintPattern(List<KeyValuePair<char, double>> pattern)
        {
            int maxKeyLength = 0;
            foreach (var pair in pattern)
            {
                int keyLength = pair.Key.ToString().Length;
                if (keyLength > maxKeyLength)
                    maxKeyLength = keyLength;
            }

            foreach (var pair in pattern)
            {
                Console.WriteLine($"Key: {pair.Key.ToString().PadRight(maxKeyLength)}  Value: {pair.Value}");
            }
        }
    }
}


// p = 'a'
// s = 'a'!

// p = 'a*'
// s = 'aa', 'aaa', 'aaaa'

// p = '.*'
// s = 'abbb', 'ba', 'aaab', 'avvvv', 'sdwfg'

// p = 'a.*'
// s = 'aferfer', 'aggcvfer', 'afgdfgre'

// p = '.a.'
// s = 'vav', 'vag', 'bag'


// p = 'aaaa*b*'
// p = 'b*c*'

// =======================================================
// Cases:

// p = 'a'
// p = 'a*'
// p = '.*'
// p = 'a.*'
// p = 'abccc*ee'
// p = 'aaa*bbcs'
// p = '.a.'
// p = 'aaaa*b*'
// p = 'b*c*'
// p = '.*c*' => 'asdadvdsvdccccc'
// p = '.*c' => 'asdadvdsvdqegfvfc'




