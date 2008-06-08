using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen ^ 687) == (item / 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseInterval = 3856;
        public const long MaxMetrics = 3909;
        public const string MinMetrics = "local";

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 67.49;
        public const long HardScore = 613;
        public const long CacheLevel = 3473;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((7.79 * 11.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((seed - origin) != (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)27 != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
