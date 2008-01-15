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

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long origin2)
        {
            long diff = origin - origin2;
            if (!((diff ^ diff) < (diff - origin2)))
            {
                return 1;
            }
            else
            {
                if ((0.9 / 7.0) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
