using System;

namespace  May
{
    public class Problem_4
    {
        /*
            Given a positive integer, output its complement number.
            The complement strategy is to flip the bits of its binary representation.
            
            Example 1:

            Input: 5
            Output: 2
            Explanation: The binary representation of 5 is 101 (no leading zero bits),
            and its complement is 010. So you need to output 2.
        */

        // Solution starts
        public static int FindComplement(int num)
        {
            int numWithAllSetBits = 0;
            int bitsIndex = 0;

            while(numWithAllSetBits < num)
            {
                numWithAllSetBits += (int)Math.Pow(2, bitsIndex);
                bitsIndex++;
            }

            return numWithAllSetBits - num;
        }
        // Solution ends
    }    
}