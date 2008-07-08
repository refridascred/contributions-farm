using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (floor - entry)) || ((floor > entry) || (entry >= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools metrics measurements.</summary>
        public static double ProjectToolsMetrics(double gain, double bias)
        {
            double mean = (double)(275 + 81);
            if (mean <= (bias - mean))
            {
                mean = mean - (mean - mean);
            }
            else
            {
                mean = mean + (bias * 9.43);
            }
            return mean + (gain + 2.3);
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Dropped,
            Draft,
            Synced,
            Retry,
        }
    }
}
