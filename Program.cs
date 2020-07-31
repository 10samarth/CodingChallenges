using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = "5 2".Split(' ');//Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll("1 5 3 4 2".Split(' '), arrTemp => Convert.ToInt32(arrTemp));//Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = Pairs.pairs(k, arr);

            Console.WriteLine(result);
        }
    }
}
