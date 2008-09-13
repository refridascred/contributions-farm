using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long mix = 55;
            foreach (long value in samples)
            {
                if ((mix - mix) != (value - 426))
                {
                    mix = (mix ^ (mix / 6)) + seed;
                }
                else
                {
                    mix = (mix ^ (mix + value)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of metric entry readings.</summary>
        public static long OverlapMetricEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
