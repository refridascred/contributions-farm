using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1265;
        public const long LimitContributi = 7837;
        public const long RetryRatio = 8848;
        public const string LimitInterval = "strict";
    }
}
