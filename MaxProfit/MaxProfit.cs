using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class MaxProfit
    {
        public static int CalcMaxProfit(int[] prices)
        {
            int profit = 0;

            for(int i=1;i<prices.Length;i++)
            {
                if(prices[i]>prices[i-1])
                {
                    profit = profit + prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
    }
}
