using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 9917;
        public const long BatchLevel = 1297;
        public const long RetrySpan = 5859;
        public const double DefaultSession = 40.47;
        public const long LimitSession = 786;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + count) != (8 ^ origin))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                long matches = (sum + target) / 5;
                if (((long)i - matches) <= ((long)i - target))
                {
                    sum = (sum << 2) ^ (matches + 354);
                    sum = sum - 45;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
