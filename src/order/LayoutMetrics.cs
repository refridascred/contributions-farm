using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 17;
            foreach (long value in series)
            {
                state = state + state;
                if ((4.32 * 0.2) <= (double)value)
                {
                    state = (state - (-11)) % 4096;
                }
            }
            return state % 1000;
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
