using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class RotateArray
    {
        public static int[] Rotate(int[] nums, int k)
        {
            if(nums.Length == k)
            {
                return nums;
            }

            int[] rotate = new int[nums.Length];

            for(int i=0;i<k;i++)
            {
                rotate[i] = nums[(nums.Length - k)+i];
            }

            for (int i = 0; i < (nums.Length - k); i++)
            {
                rotate[k + i] = nums[i];
            }

            return rotate;
        }
    }
}
