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

                while (index < s.Length)
                {
                    newString += s[index];

                    index = (index + numRows) + (numRows - 2);

                    if (i != 0 && i != numRows - 1 && index > numRows)
                    {
                        var inBetweenIndex = index - (i * 2);
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

//  P A Y P A L I S H I R  I  N  G
//  0 1 2 3 4 5 6 7 8 9 10 11 12 13

//  numRows = 4

//  i = 0: 0 6 12
//  i = 1: 1 5 7 11 13
//  i = 2: 2 4 8 10
//  i = 3: 3 9

//  i = 0: P I    N
//  i = 1: A L S  I G
//  i = 2: Y A   H R
//  i = 3: P I


//         0     6       12
//         1   5 7    11 13
//         2 4   8 10    
//         3     9       
	    	
//  0 6 12 1 5 7 11 13 2 4 8 10 3 9 
//  PAYPALISHIRING
//  PINALSIGYAHRPI


//    i = 0   0         10             20
//    i = 1   1       9 11          19 21
//    i = 2   2     8   12       18    22
//    i = 3   3   7     13    17       23
//    i = 4   4 6       14 16          24
//    i = 5   5         15             25