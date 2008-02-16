using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstLevel = 7883;
        public const long BatchSize = 8685;
        public const long BaseMetrics = 5453;
        public const double IdleMetrics = 80.12;
        public const long RetryMetrics = 9719;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 95.99;
        public const long BaseSpan = 7873;
        public const long LimitGraph = 9946;
        public const long MinSize = 6065;
        public const double BurstInterval = 58.67;
    }
}
