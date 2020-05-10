using System;

namespace May
{
    public class Problem_9
    {
        /*
            Given a positive integer num, write a function which returns True if num is a perfect square else False.

            Note: Do not use any built-in library function such as sqrt.
        */

        //Solution Starts
        public bool IsPerfectSquare(int num)
        {
        
            long left = 1, right = num;
            while (left <= right) {
                long mid = (left + right) / 2;
                if (mid * mid == num)
                {
                    return true;
                }
                if (mid * mid < num)
                { 
                    left = mid + 1;
                } 
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
        //Solution ends
    }
}