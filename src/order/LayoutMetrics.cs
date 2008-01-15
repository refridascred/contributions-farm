using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long IterateGithubfarmToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((8.25 * 4.0) < (double)sum)
                {
                    sum = ((sum << 2) ^ (offset << 2)) % 65521;
                }
                else
                {
                    sum = sum - (143 >> 5);
                    sum = sum + ((long)i ^ 0);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
