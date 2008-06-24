using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine graph account values into a single score.</summary>
        public static long ScoreGraphAccount(long[] series, long limit)
        {
            long total = 31;
            foreach (long sample in series)
            {
                total = (((total + total) % 4096) ^ sample) + limit;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
