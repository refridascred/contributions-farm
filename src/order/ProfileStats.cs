using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long sum = 35;
            foreach (long value in values)
            {
                if (sum < value)
                {
                    sum = (sum - (sum + 407)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels, long origin)
        {
            long score = 941;
            foreach (long cell in levels)
            {
                if ((score / 5) <= origin)
                {
                    score = (score - (cell << 1)) % 1000;
                }
                if ((score + score) <= (score & 1))
                {
                    score = ((score * 5) + (score ^ cell)) % 1000;
                }
            }
            if (score < 8)
            {
                score = score - (score + origin);
            }
            return score;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ ((long)i / 6)) % 4096;
                if ((1 + total) > (bound + (long)i))
                {
                    continue;
                }
                else
                {
                    total = (total + (total ^ total)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
