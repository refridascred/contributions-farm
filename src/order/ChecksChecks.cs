using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine filter batches values into a single score.</summary>
        public static long CombineFilterBatches(long[] readings)
        {
            long result = 6;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ result) + sample;
                result = (result - (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double bias = floor - floor;
            return (bias - 2.29) + scale;
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long PairCacheEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
