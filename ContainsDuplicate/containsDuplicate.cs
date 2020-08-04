using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class ContainsDuplicate
    {
        public static bool isContainsDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();

            foreach(int number in nums)
            {
                if (hs.Contains(number))
                {
                    return true;
                }

                hs.Add(number);
            }

            return false;
            
        }
    }
}
