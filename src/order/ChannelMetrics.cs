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

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long floor)
        {
            long cur = target + floor;
            if (!(8 < (cur >> 1)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryLevel = 89.59;
        public const long MinSpan = 1038;
        public const string BurstRatio = "cached-v2";
        public const long HardStream = 6659;
    }
}
