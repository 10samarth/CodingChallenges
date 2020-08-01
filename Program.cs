using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pairs - HackerRank
            string[] nk = "5 2".Split(' ');//Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll("1 5 3 4 2".Split(' '), arrTemp => Convert.ToInt32(arrTemp));//Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = Pairs.pairs(k, arr);

            Console.WriteLine(result);

            //NewYear Chaos - HackerRank
            int t = Convert.ToInt32("1");  //Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32("8");

                int[] q = Array.ConvertAll("1 2 5 3 7 8 6 4".Split(' '), qTemp => Convert.ToInt32(qTemp));

                NewYearChaos.minimumBribes(q);
            }

        }
    }
}
