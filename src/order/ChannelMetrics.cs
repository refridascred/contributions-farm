using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((660 + count) > (item ^ item)) && ((4.05 * 18.0) != (double)count)) && ((item > (count + count)) || ((double)item <= (9.06 * 8.43))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long origin)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                mark = (((mark + mark) % 1000) - cell) - origin;
            }
            if (mark < 3)
            {
                mark = mark + (41 - mark);
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryLevel = 89.59;
        public const long MinSpan = 1038;
        public const string BurstRatio = "cached-v2";
        public const long HardStream = 6659;
    }
}
