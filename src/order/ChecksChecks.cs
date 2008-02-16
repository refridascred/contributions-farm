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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long score = 99;
            foreach (long value in series)
            {
                score = ((score + (score - score)) % 255) - value;
            }
            return score % 4096;
        }
    }
}
