using System;

namespace May
{
    public class Problem_5
    {
        /*
            Given a string, find the first non-repeating character in it and return it's index.
            If it doesn't exist, return -1.

            Examples:

            s = "leetcode"
            return 0.

            s = "loveleetcode",
            return 2.
            Note: You may assume the string contain only lowercase letters.
        */

        //Solution starts
        public static int FirstUniqueCharacter(string str)
        {
            int[] lookup = new int[256];

            for(int i = 0; i < str.Length; i++)
            {
                lookup[str[i]]++;
            }

            for(int i = 0; i < str.Length; i++)
            {
                if(lookup[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        //Solution ends
    }
}