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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchLevel = 7.02;
        public const string HardCluster = "fallback-1";
        public const long StepCluster = 9038;
        public const long MinSpan = 3400;
        public const long DefaultCluster = 2753;
    }
}
