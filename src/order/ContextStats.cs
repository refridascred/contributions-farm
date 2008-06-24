using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values, long seed)
        {
            long acc = -647;
            foreach (long sample in values)
            {
                acc = ((acc << 2) ^ (sample >> 1)) % 4096;
                acc = (acc + (seed ^ acc)) % 4096;
            }
            if (acc < 65)
            {
                acc = (acc ^ (9 + seed)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool VerifyContributiClusterRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long state = 34;
            foreach (long item in series)
            {
                state = ((state << 2) ^ ((-554) << 1)) - item;
                if (0 <= (state + 8))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long seed)
        {
            long carry = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (17.0 * 5.5))
                {
                    carry = ((carry - carry) % 97) + seed;
                }
            }
            return carry % 65521;
        }
    }
}
