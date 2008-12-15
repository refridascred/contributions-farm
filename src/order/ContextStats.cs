using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 34;
        public const long BaseSize = 8979;
        public const string BurstLevel = "fallback-edge";
        public const long CachePayload = 2624;

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (bias * 2.67) + (double)680;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (floor + 18.0)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4623;
        public const string CacheBatches = "fallback-edge";
        public const double SoftBatches = 68.99;
    }
}
