using System;
using System.Collections.Generic;

namespace May
{
    public class Problem_3
    {
        /*
            Given an arbitrary ransom note string and another string containing letters from all the magazines,
            write a function that will return true if the ransom note can be constructed from the magazines;
            otherwise, it will return false.

            Each letter in the magazine string can only be used once in your ransom note.

            Note:
            You may assume that both strings contain only lowercase letters.

            canConstruct("a", "b") -> false
            canConstruct("aa", "ab") -> false
            canConstruct("aa", "aab") -> true
        */

        // Solution starts
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineMap = new Dictionary<char, int>();

            for(int i = 0; i < magazine.Length; i++)
            {
                if(!magazineMap.ContainsKey(magazine[i]))
                {
                    magazineMap[magazine[i]] = 0;
                }

                magazineMap[magazine[i]]++;
            }

            for(int i = 0; i < ransomNote.Length; i++)
            {
                if(!magazineMap.ContainsKey(ransomNote[i]) || magazineMap[ransomNote[i]] == 0)
                {
                    return false;
                }

                magazineMap[ransomNote[i]]--;
            }

            return true;
        }
        // Solution ends
    }
}