using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 9060;
        public const long WindowSession = 4943;
        public const long CacheSession = 4648;
        public const long BatchSession = 7968;
        public const long LimitSession = 5332;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.9 - 7.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric notes input into a small class.</summary>
        public static long BucketMetricNotes(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (((3 ^ offset2) != (offset2 << 2)) && ((double)slot != (5.47 / 7.0)))
            {
                return 6;
            }
            else
            {
                if (((double)8 < (double)offset) || (slot <= (offset - slot)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
