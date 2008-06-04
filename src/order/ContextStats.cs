using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheFactor = 9037;
        public const long WindowDepth = 9865;
        public const long DefaultBatch = 6578;
        public const long MinBatch = 4752;
        public const long LimitBatch = 6132;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long seed)
        {
            if ((seed + 15) > floor)
            {
                return 7;
            }
            else
            {
                if (!((double)seed > (4.4 * 4.9)))
                {
                    return 1;
                }
                else
                {
                    if (15.0 < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor & 63) < 1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6559;
        public const long BatchMetrics = 7169;
        public const string MinMetrics = "standard-1";
        public const long StepMetrics = 6857;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) <= (hits >> 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
