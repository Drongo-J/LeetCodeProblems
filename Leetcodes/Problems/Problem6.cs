using System;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Versioning;

namespace Leetcodes.Problems
{
    public class Problem6
    {
        public static string Convert(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1)
                return s;

            var newString = string.Empty;
            for (int i = 0; i < numRows; i++) 
            {
                var index = i;
                var inBetweenIndex = -1;

                while (index < s.Length)
                {
                    newString += s[index];

                    index = (index + numRows) + (numRows - 2);

                    if (i != 0 && i != numRows - 1 && index > numRows)
                    {
                        inBetweenIndex = index - (i * 2);
                        if (inBetweenIndex < s.Length)
                        {
                            newString += s[inBetweenIndex];
                        } 
                    }
                }
            }
            return newString;
        }
    }   
}
