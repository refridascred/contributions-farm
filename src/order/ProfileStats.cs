using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
