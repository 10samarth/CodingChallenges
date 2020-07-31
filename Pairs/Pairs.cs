using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class Pairs
    {
        public static int pairs(int k, int[] arr)
        {
            int count = 0;
            HashSet<int> ht = new HashSet<int>(arr);

            for(int i=0;i<arr.Length;i++)
            {
                if(ht.Contains(arr[i]-k))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
