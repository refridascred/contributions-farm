using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 263;
        public const double MinCluster = 65.98;
        public const string DefaultFactor = "open";

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
