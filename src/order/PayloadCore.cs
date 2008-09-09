using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long total = 831;
            foreach (long cell in samples)
            {
                if ((total % 8) < total)
                {
                    total = (((total << 2) ^ (9 / 6)) ^ cell) + target;
                }
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 985;
        public const double RetryLevel = 3.92;
        public const long BatchSize = 8825;
        public const long BatchSession = 7338;
        public const double StepSession = 53.88;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
