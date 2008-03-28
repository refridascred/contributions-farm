using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 60.18;
        public const double RetrySpan = 40.37;
        public const long DefaultInterval = 1634;

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
