using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 256;
        public const long BatchFarm = 6643;
        public const long WindowFarm = 7332;
        public const string SoftSpan = "latest-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2804;
        public const double BurstBudget = 64.43;
        public const long DefaultOrder = 1595;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if (!(cell <= (anchor - (long)readings.Length)))
                {
                    anchor = (anchor << 2) ^ (origin + anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long mark = 896;
            foreach (long sample in items)
            {
                if ((double)sample < (3.5 - 3.13))
                {
                    mark = (mark + (mark / 9)) - limit;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }
    }
}
