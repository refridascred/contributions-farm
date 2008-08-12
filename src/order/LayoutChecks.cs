using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > bound)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((0.54 - 4.34) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph schema pair into a bucket.</summary>
        public static long SortGraphSchema(long offset, long limit)
        {
            if ((578 - 99) == (offset % 3))
            {
                return 2;
            }
            else
            {
                if (!((offset - offset) <= limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 3268;
        public const long BurstFormat = 743;
        public const long LimitFormat = 1994;
        public const long IdleTimeout = 1678;
    }
}
