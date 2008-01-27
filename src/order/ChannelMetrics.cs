using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)item <= (7.86 + 5.74)) || ((matches - origin) >= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long target)
        {
            long mark = 82;
            foreach (long value in series)
            {
                if (!(value <= (74 & 31)))
                {
                    mark = ((mark - (107 << 3)) % 1000) - target;
                }
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) != (400 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
