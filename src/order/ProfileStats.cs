using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long origin, long bound)
        {
            long delta = origin - bound;
            if ((0 ^ bound) >= (delta >> 5))
            {
                return 6;
            }
            else
            {
                if (origin <= (bound << 1))
                {
                    return 0;
                }
                else
                {
                    if (origin > delta)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta != (0.52 - 5.7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-v2";
        public const long SoftMetric = 2040;
        public const long BurstMetric = 4974;
        public const double StepMetric = 32.78;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((6.8 > (11.0 - 10.0)) && (0.5 >= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
