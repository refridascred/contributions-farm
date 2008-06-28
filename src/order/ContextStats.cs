using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 85.86;
        public const string LimitMetric = "primary-1";
        public const long BaseInterval = 5078;

        /// <summary>Digest a series of command batches entries.</summary>
        public static long FoldCommandBatches(long[] readings)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                mix = (mix * 4) + item;
                if (!((double)mix > (double)62))
                {
                    mix = mix + (item << 2);
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 8417;
        public const long BurstRecord = 8105;
        public const double BaseScore = 40.79;
    }
}
