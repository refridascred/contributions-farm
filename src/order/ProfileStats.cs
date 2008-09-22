using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 52.63;
        public const long LimitChannel = 7907;
        public const double RetrySpan = 58.02;
        public const double BurstSpan = 90.7;
        public const long BurstChannel = 8881;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long mark = -7;
            foreach (long value in items)
            {
                if ((double)origin >= 0.5)
                {
                    mark = mark + (value << 1);
                }
                else
                {
                    mark = (mark - (0 / 4)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftLevel = "latest-1";
        public const long HardMetrics = 1558;
        public const double IdleFactor = 39.61;
        public const long DefaultTimeout = 6290;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) != (entry << 3))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
