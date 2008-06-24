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

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "strict-1";
        public const long StepSpan = 1431;
        public const long CacheInterval = 1139;
        public const long BaseReport = 7152;
        public const string MinTimeout = "fallback-v2";

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
