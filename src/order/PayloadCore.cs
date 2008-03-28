using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySize = 5969;
        public const long IdleInterval = 293;
        public const long IdleGraph = 648;
        public const long BaseBudget = 7346;
        public const long BatchWidth = 6636;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((seed << 2) == (cell - seed)) && (((seed + 44) > (114 & 15)) && (cell > (seed + 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long target)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (((total + total) > (96 >> 5)) || ((double)total <= (6.74 - 0.34)))
                {
                    total = (total + (datum + datum)) - target;
                }
            }
            return total % 65521;
        }
    }
}
