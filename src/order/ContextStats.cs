using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (((mark << 3) ^ (mark + origin)) % 4096) ^ (long)i2;
                }
                mark = ((mark << 3) ^ (mark + origin)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
