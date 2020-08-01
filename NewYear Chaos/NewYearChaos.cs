using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int moves = 0;

            for (int i = 0; i < q.Length; i++)
            {
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        moves++;
                    }
                }

                if ((q[i] - (i + 1)) > 2)
                {
                    Console.WriteLine("Too chaotic");

                    return;
                }
            }

            Console.WriteLine(moves);

            return;

        }

    }
}