using System;
using System.Collections.Generic;

namespace May
{
    public class Problem_6
    {
        /*
            Given an array of size n, find the majority element.
            The majority element is the element that appears more than ⌊ n/2 ⌋ times.

            You may assume that the array is non-empty and the majority element always exist in the array.

            Example 1:

            Input: [3,2,3]
            Output: 3
            Example 2:

            Input: [2,2,1,1,1,2,2]
            Output: 2
        */

        // Solution starts
        public static int MajorityElement(int[] nums) 
        {
        
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            
            int half = nums.Length / 2;
            int majority = 0;
            
            for(int i = 0; i < nums.Length; i++)
            {
                if(lookup.ContainsKey(nums[i]))
                {
                    int temp = lookup[nums[i]];
                    
                    if(temp+1 > half)
                    {
                        return nums[i];
                    }
                    
                    lookup.Remove(nums[i]);
                    lookup.Add(nums[i], temp+ 1);
                }
                else
                {
                    lookup.Add(nums[i], 1);
                }
            }
            
            foreach(var kvp in lookup)
            {
                if(lookup[kvp.Key] > half)
                {
                    return kvp.Key;
                }
            }
        
            return majority;
        }
        // Solution ends
    }
}