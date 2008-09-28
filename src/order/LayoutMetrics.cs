using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            if ((4.44 - 3.1) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor & 63) < (seed ^ (-93)))
                {
                    return 6;
                }
                else
                {
                    if (!((15 + seed) < 21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long AuditCounterChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((969 - count) > reading)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
