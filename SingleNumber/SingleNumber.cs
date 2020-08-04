using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.SingleNumber
{
    class SingleNumber
    {
        public static int singleNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();

            foreach(int number in nums)
            {
                if(hs.Contains(number))
                {
                    hs.Remove(number);
                }
                else
                {
                    hs.Add(number);
                }
            }

            if(hs.Count>0)
                return hs.First();

            return 0;
        }
    }
}
