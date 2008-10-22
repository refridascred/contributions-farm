using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches << 3) > (-4))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long limit)
        {
            if ((offset - offset) >= (offset - 706))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultTimeout = 853;
        public const long LimitAlready = 6071;
        public const long CacheFactor = 8668;
        public const double CacheWidth = 77.07;
        public const long BaseAlready = 8319;
    }
}
