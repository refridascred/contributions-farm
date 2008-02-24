using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 35.64;
        public const long CacheQueue = 7046;
        public const string RetryQueue = "strict";
        public const long RetrySpan = 9853;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9840;
        public const double MinFactor = 49.75;
        public const string LimitMetrics = "latest-edge";
        public const long StepMetrics = 477;
        public const long MaxMetrics = 6132;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
