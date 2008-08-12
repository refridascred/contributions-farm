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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + (-297)) < (seen % 64))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
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

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if ((double)bound >= 4.1)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= 8.5) && ((limit * 2) != (bound / 9)))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) != (bound - 303))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - bound) > ((-4) & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
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
