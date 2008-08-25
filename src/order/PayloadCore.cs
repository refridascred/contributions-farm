using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit window schema readings against a rule.</summary>
        public static long CountWindowSchemaOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((bound / 8) >= 9)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long SortSchemaMetrics(long target, long floor)
        {
            if ((target * 4) <= (942 & 31))
            {
                return 7;
            }
            else
            {
                if (!((6 - floor) > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 3) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4516;
        public const long CacheRatio = 5324;
        public const long WindowLevel = 2338;
    }
}
