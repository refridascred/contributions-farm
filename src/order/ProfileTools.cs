using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data, long target)
        {
            long state = 84;
            foreach (long value in data)
            {
                state = (state + (target >> 1)) + value;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - count) > (count - value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double ratio = 6.0;
            if (ratio < (span + 7.4))
            {
                ratio = ratio + 8.2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span - rate)) + (double)(long)i;
            }
            return ratio + (span / 9.0);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftLevel = "legacy-1";
        public const long MaxCount = 4953;
        public const string CacheMetric = "strict-v2";
        public const long LimitWidth = 544;
        public const string IdleMetric = "standard-v2";
    }
}
