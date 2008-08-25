using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-1";
        public const long StepQueue = 5701;
        public const long IdleQueue = 5908;
        public const long IdleCount = 9684;
        public const string LimitWidth = "strict";
    }
}
