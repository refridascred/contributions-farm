using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double bias = (span / 8.0) - ratio;
            if (bias <= (bias / 7.0))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - (19.0 + ratio);
            }
            return bias + bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((offset + hits) < (offset % 2))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
