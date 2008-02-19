using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark - (4 << 1)) - value;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item > (3 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}
